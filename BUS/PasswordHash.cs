using System;
using System.Security.Cryptography;

namespace BUS
{
    public sealed class PasswordHash
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;

        private readonly string _password;

        public PasswordHash(string password)
        {
            _password = password ?? string.Empty;
        }

        // Create a stored hash string: iterations.saltBase64.hashBase64
        public string Hash()
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, Iterations))
            {
                hash = pbkdf2.GetBytes(HashSize);
            }

            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        // Verify provided stored hash against the password passed to the constructor
        public bool Verify(string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash)) return false;

            var parts = storedHash.Split('.');
            if (parts.Length != 3) return false;

            if (!int.TryParse(parts[0], out int iterations)) return false;

            byte[] salt;
            byte[] hash;
            try
            {
                salt = Convert.FromBase64String(parts[1]);
                hash = Convert.FromBase64String(parts[2]);
            }
            catch
            {
                return false;
            }

            byte[] testHash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(_password, salt, iterations))
            {
                testHash = pbkdf2.GetBytes(hash.Length);
            }

            return FixedTimeEquals(testHash, hash);
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }

        // Static helpers
        public static string HashPassword(string password)
        {
            return new PasswordHash(password).Hash();
        }

        public static bool VerifyPassword(string storedHash, string password)
        {
            return new PasswordHash(password).Verify(storedHash);
        }
    }
}
