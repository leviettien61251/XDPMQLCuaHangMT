using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        private string connString = @"Data Source=tim\SQLEXPRESS;
                                      Initial Catalog=cuaHangMayTinh2;
                                      Integrated Security=True;
                                      Encrypt=True;TrustServerCertificate=True";
        public DataTable Load(string query)
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
                    if (parameter != null)
                    {
                        string[] listParameters = query.Split(' ');
                        int i = 0;
                        foreach (string para in listParameters)
                        {
                            if (para.Contains('@'))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue(para, parameter[i]);
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }

                            }
                        }
                    }

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
                    if (parameter != null)
                    {
                        string[] listParameters = query.Split(' ');
                        int i = 0;
                        foreach (string para in listParameters)
                        {
                            if (para.Contains('@'))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue(para, parameter[i]);
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }
                            }
                        }
                    }


                    try
                    {
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        EventLog.WriteEntry("Application", ex.ToString(), EventLogEntryType.Error);
                        return -1;
                        throw;
                    }

                }
                conn.Close();
            }
            return rowAffected;
        }

    }
}
