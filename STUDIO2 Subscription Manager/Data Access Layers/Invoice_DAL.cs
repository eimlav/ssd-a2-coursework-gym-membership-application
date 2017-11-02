using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace STUDIO2_Subscription_Manager
{
    public class Invoice_DAL
    {
        public Invoice_DAL() 
        { 
        }

        // local variable used by DAL for connecting to SQL database
        private static string _connectionString = ConfigurationManager.ConnectionStrings["STUDIO2 Subscription Manager SQL"].ConnectionString;

        // executes SQL query to retrieve all records from Invoice table with IStatus equal to a value (input)
        public static DataSet FilterInvoices(string input)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {                
                try
                {
                    string sqlQuery;             
                    if(input == "All")
                    {
                        sqlQuery = "SELECT * FROM Invoice";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM Invoice WHERE IStatus = '" + input + "';";
                    }
                    
                    connection.Open();                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection); 
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    return ds;                 
                }
                catch
                {                    
                }

                connection.Close();

                return null;
            }
        }

        // executes SQL query to retrieve all records from Invoice table matching a specified column (field) and value (input)
        public static DataSet SearchInvoice(string field, string input)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM Invoice WHERE " + field + " LIKE '%" + input + "%';";
                    connection.Open();                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    return ds;
                }
                catch
                {
                }

                connection.Close();

                return null;
            }
        }

        // executes SQL query to update the IStatus of an invoice record 
        public static int UpdateInvoice(string invoiceID, string status)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();                   
                    string sqlQuery = "UPDATE Invoice SET IStatus='" + status + "' WHERE InvoiceID = " + invoiceID + ";";

                    SqlCommand updateCommand = new SqlCommand(sqlQuery, connection);

                    rowsAffected = updateCommand.ExecuteNonQuery();
                }
                catch
                {
                    rowsAffected = 3;
                }

                connection.Close();

                return rowsAffected;
            }
        }

        // method for retrieving analytics based on Invoice table - used by Analytics Form
        public static int[] RetrieveAnalytics()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int[] values = new int[5];
                try
                {
                    connection.Open();
                    string[] sqlQuery = new string[5];

                    sqlQuery[0] = "SELECT COUNT(*) FROM Invoice;";
                    sqlQuery[1] = "SELECT COUNT(*) FROM Invoice Where IStatus = 'Paid';";
                    sqlQuery[2] = "SELECT COUNT(*) FROM Invoice Where IStatus = 'Not Paid';";
                    sqlQuery[3] = "SELECT COUNT(*) FROM Invoice Where IStatus = 'Pending';";
                    sqlQuery[4] = "SELECT COUNT(*) FROM Invoice Where IStatus = 'Canceled';";

                    for (int i = 0; i < 5; i++)
                    {
                        SqlCommand insertCommand = new SqlCommand(sqlQuery[i], connection);
                        values[i] = Convert.ToInt32(insertCommand.ExecuteScalar());
                    }
                }
                catch
                {
                    return values;
                }

                connection.Close();

                return values;
            }
        }
    }
}
