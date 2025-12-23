using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DAL
{
    public class Connect
    {
        private string connString = @"Data Source=tim\SQLEXPRESS;Initial Catalog=cuaHangMayTinh3;Integrated Security=True;TrustServerCertificate=True";

        private void BindParameters(SqlCommand cmd, string query, object[] parameters)
        {
            if (parameters == null)
                return;

            // Use regex to extract all parameter names in order
            Regex paramRegex = new Regex(@"@\w+");
            MatchCollection matches = paramRegex.Matches(query);

            for (int i = 0; i < matches.Count && i < parameters.Length; i++)
            {
                string paramName = matches[i].Value;
                object paramValue = parameters[i] ?? DBNull.Value;
                cmd.Parameters.AddWithValue(paramName, paramValue);
            }
        }

        public DataTable Load(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException)
                {
                    // Handle exception (e.g., log it)
                    throw; // Re-throw the exception after handling
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            da.Fill(dt);
                        }
                        catch (SqlException ex)
                        {

                            EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
                            return dt;// preserve stack trace
                            throw;
                        }
                    }
                }
                conn.Close();
            }

            return dt;
        }



        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    // Handle exception (e.g., log it)
                    throw; // Re-throw the exception after handling
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    BindParameters(cmd, query, parameter);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            da.Fill(dt);
                        }
                        catch (SqlException ex)
                        {
                            // Handle exception (e.g., log it)
                            EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
                            return dt;
                            throw; // Re-throw the exception after handling

                        }


                    }
                }

                conn.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int rowAffected = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    // Handle exception (e.g., log it)
                    throw; // Re-throw the exception after handling
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    BindParameters(cmd, query, parameter);

                    try
                    {
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
                        throw;
                    }

                }
                conn.Close();
            }
            return rowAffected;
        }

        public object ExecuteScalar(string script, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(script, conn);

                BindParameters(cmd, script, parameter);

                try
                {
                    data = cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
                    throw;
                }

                conn.Close();

            }

            return data;

        }
    }

}
