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
    public class Member_DAL
    {
        public Member_DAL() 
        { 
        }

        // local variable used by DAL for connecting to SQL database
        private static string _connectionString = ConfigurationManager.ConnectionStrings["STUDIO2 Subscription Manager SQL"].ConnectionString;

        // executes SQL query to create a new member record
        public static int CreateMember(string title, string firstName, string surname, string street, string city, string county, string postcode, string dateOfBirth, string emergencyContact, string gender, string phone, string email)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();
                    
                    string sqlQuery = "INSERT INTO Member VALUES('" + title + "','" + firstName + "','" + surname + "','" + street + "','" + city + "','" + county + "','" + postcode + "','" + dateOfBirth + "','" + emergencyContact + "','" + gender + "','" + phone + "','" + email + "')";
            
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                 
                    rowsAffected = insertCommand.ExecuteNonQuery();
               
                }
                catch
                {
                    rowsAffected = 3;
                }

                connection.Close();

                return rowsAffected;
            }
        }

        // executes SQL query to update a member record
        public static int UpdateMember(string title, string firstName, string surname, string street, string city, string county, string postcode, string dateOfBirth, string emergencyContact, string gender, string phone, string email, int memberID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();
                    
                    string sqlQuery = "UPDATE Member SET Title='" + title + "', FirstName='" + firstName + "',Surname='" + surname + "',AddressLine='" + street + "',AddressCity='" + city + "',AddressCounty='" + county + "',AddressPostcode='" + postcode + "',DateOfBirth='" + dateOfBirth + "',EmergencyContactNumber='" + emergencyContact + "',Gender='" + gender + "',Phone='" + phone + "',Email='" + email + "' WHERE MemberID=" + memberID + ";";                   
  
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

        // executes SQL query to retrieve all records from Member table matching a specified column (field) and value (input)
        public static DataSet SearchMember(string field, string input)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {                
                try
                {                                       
                    string sqlQuery = "SELECT * FROM Member WHERE " + field + " LIKE '%" + input + "%';";
                    connection.Open();
                    
                    // executes SQL query and fills DataSet ds with results and returns ds
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

        // executes SQL query to delete member and all records containing a reference to the specified member record's MemberID
        public static int DeleteMember(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                Console.WriteLine("member id for delete is  " + memberID);
                try
                {
                    connection.Open();                          
                   
                    string[] sqlQuery = new string[4];
                    // retrieves all subscriptions with MemberID corresponding with the passed in MemberiD
                    sqlQuery[0] = "SELECT SubscriptionID FROM Subscription WHERE MemberID = " + memberID.ToString() + " ;";
                    SqlCommand subIDCommand = new SqlCommand(sqlQuery[0], connection);                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(subIDCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    // deletes invoices of corresponding to each SubscriptionID retrieved
                    foreach (DataRow row in dataTable.Rows)
                    {                      
                        sqlQuery[1] = "DELETE FROM Invoice WHERE SubscriptionID = " + row["SubscriptionID"] + ";";
                        SqlCommand deleteInvoiceCommand = new SqlCommand(sqlQuery[1], connection);
                        deleteInvoiceCommand.ExecuteNonQuery();
                    }         
           
                    sqlQuery[2] = "DELETE FROM Subscription WHERE MemberID = " + memberID.ToString() + ";";
                    sqlQuery[3] = "DELETE FROM Member WHERE MemberID = " + memberID.ToString() + ";";
                               
                    // deletes subscriptions and invoices with MemberID corresponding with the passed in MemberID
                    SqlCommand deleteCommand = new SqlCommand(sqlQuery[2], connection);
                    deleteCommand.ExecuteNonQuery();
                    deleteCommand = new SqlCommand(sqlQuery[3], connection);
                    deleteCommand.ExecuteNonQuery();                   
                    rowsAffected = 1;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    rowsAffected = 3;
                }

                connection.Close();

                return rowsAffected;
            }
        }

        // method for retrieving analytics based on Member table - used by Analytics Form
        public static int[] RetrieveAnalytics()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int[] values = new int[5];
                try
                {
                    connection.Open();                    
                    string[] sqlQuery = new string[5];

                    sqlQuery[0] = "SELECT COUNT(*) FROM Member;";
                    sqlQuery[1] = "SELECT COUNT(*) FROM Member;"; //ACTIVE MEMBER QUERY NEEDS DONE
                    sqlQuery[2] = "SELECT COUNT(*) FROM Member WHERE Gender = 'Male';";
                    sqlQuery[3] = "SELECT COUNT(*) FROM Member WHERE Gender = 'Female';";
                    sqlQuery[4] = "SELECT AVG(DATEDIFF(year,DateOfBirth,GETDATE())) FROM Member;";

                    // executes each SQL query and assigns to return array
                    for(int i = 0; i < 5; i++)
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
