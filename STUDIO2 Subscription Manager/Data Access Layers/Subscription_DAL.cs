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
    public class Subscription_DAL
    {
        public Subscription_DAL() 
        { 
        }

        // local variable used by DAL for connecting to SQL database
        private static string _connectionString = ConfigurationManager.ConnectionStrings["STUDIO2 Subscription Manager SQL"].ConnectionString;

        // returns name of plan corresponding to passed in PlanID
        public static string RetrievePlanName(int planID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT Name FROM [Plan] WHERE PlanID = " + planID + ";";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    return command.ExecuteScalar().ToString();
                }
                catch
                {
                    return "N/A";
                }
            }
        }

        // executes SQL query to update the Amount value of a plan record
        public static int UpdatePlan(string plan, decimal newPrice)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();
        
                    string sqlQuery = "UPDATE [Plan] SET Amount=" + newPrice + " WHERE Name ='" + plan + "';";
       
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

        // executes SQL query to create a new subscription record
        public static int CreateSubscription(int memberID, string planName, string recurring)
        {
            // return values:
            // 0 = Unexpected error
            // 1 = Subscription created
            // 2 = Existing subscription
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {                
                try
                {
                    connection.Open();
                    // retrieves subscriptions records for corresponding to specified MemberID
                    string sqlQuery = "SELECT * FROM Subscription WHERE MemberID = " + memberID + ";";              
                    SqlCommand sqlcommand = new SqlCommand(sqlQuery, connection);           
                    SqlDataReader dataReader = sqlcommand.ExecuteReader();           
                    dataReader.GetSchemaTable();
             
                    // retrieves SStatus from all selected subscription records
                    string sStatus = "";                   
                    while(dataReader.Read())
                    {
                        sStatus += "# " + (dataReader.GetValue(dataReader.GetOrdinal("SStatus")).ToString());                                                    
                    }
                   
                    dataReader.Close();
                    /* if Active is found the member already has a subscription and cannot create another 
                    ELSE a new subscription is created */
                    if(sStatus.Contains("Active"))
                    {
                        return 2;
                    }
                    else
                    {
                        DateTime today = DateTime.Today;
                        // retrieves all plan record corresponding to PlanName passed in
                        sqlQuery = "SELECT * FROM [Plan] WHERE Name = '" + planName + "';";
                      
                        sqlcommand = new SqlCommand(sqlQuery, connection);
                 
                        int planID=0, planMonths=0;
                        string planInterval="";

                        SqlDataReader dataReader2 = sqlcommand.ExecuteReader();
                  
                        dataReader2.GetSchemaTable();
                   
                        while(dataReader2.Read())
                        {
                            planID = Convert.ToInt32((dataReader2.GetValue(dataReader2.GetOrdinal("PlanID"))));
                        
                            planMonths = Convert.ToInt32((dataReader2.GetValue(dataReader2.GetOrdinal("Months"))));
                       
                            planInterval = (dataReader2.GetValue(dataReader2.GetOrdinal("Interval"))).ToString();
                      
                        }
                        
                        DateTime endDate = today.AddMonths(planMonths).Date;
                        DateTime nextInvoice = new DateTime();
                        if(planInterval == "month")
                        {
                            nextInvoice = today.AddMonths(1).Date;
                        }
                        else
                        {
                            nextInvoice = endDate.Date;
                        }

                        int recurringValue; 
                        if(recurring == "True")
                        {
                            recurringValue = 1;
                        }
                        else
                        {
                            recurringValue = 0;
                        }

                        sqlQuery = "INSERT INTO Subscription VALUES(" + memberID + "," + planID + "," + recurringValue + ",'" + today.Date.ToString("yyyy-MM-dd") + "','" + today.Date.ToString("yyyy-MM-dd") + "','" + endDate.Date.ToString("yyyy-MM-dd") + "',NULL,'" + nextInvoice.Date.ToString("yyyy-MM-dd") + "','Active'); SELECT SCOPE_IDENTITY();";
                     
                        sqlcommand = new SqlCommand(sqlQuery, connection);
                       
                        dataReader2.Close();

                        int subID = Convert.ToInt32(sqlcommand.ExecuteScalar());                     
                        sqlQuery = "INSERT INTO Invoice VALUES('" + today.Date.ToString("yyyy-MM-dd") +"'," + subID + ",'Pending');";
                      
                        sqlcommand = new SqlCommand(sqlQuery, connection);
                                                               
                        return sqlcommand.ExecuteNonQuery();
                    }                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return 0;
                }
            }
        }

        // executes SQL query to retrieve all records from Member table matching a specified column (field) and value (input)
        public static DataSet SearchSubscription(string field, string input)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string sqlQuery = "SELECT * FROM Subscription WHERE " + field + " LIKE '%" + input + "%';";
                    Console.WriteLine(sqlQuery);
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

        // executes SQL query to update a subscription record
        public static int UpdateSubscription(int subID, string input)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();
       
                    string sqlQuery="";
                    if (input == "Cancel")
                    {                        
                        sqlQuery = "UPDATE Subscription SET SStatus = 'Canceled' WHERE SubscriptionID =" + subID + "; UPDATE Subscription SET CanceledDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID =" + subID + ";";
                        SqlCommand updateCommand = new SqlCommand(sqlQuery, connection);
                        rowsAffected = updateCommand.ExecuteNonQuery();
                        Console.WriteLine("UPDATE SUB #### " + rowsAffected);
                        sqlQuery = "UPDATE Invoice SET IStatus = 'Canceled' WHERE SubscriptionID = " + subID + " AND IStatus = 'Pending';";
                        Console.WriteLine(sqlQuery);
                        updateCommand = new SqlCommand(sqlQuery, connection);
                        rowsAffected = rowsAffected + updateCommand.ExecuteNonQuery();
                        Console.WriteLine("UPDATE SUB 2#### " + rowsAffected);
                        return rowsAffected;
                    }
                    else
                    {
                        sqlQuery = "UPDATE Subscription SET Recurring = '" + input + "' WHERE SubscriptionID =" + subID + ";";
                        SqlCommand updateCommand = new SqlCommand(sqlQuery, connection);
                        rowsAffected = updateCommand.ExecuteNonQuery();
                        return 2;
                    }                                                            
                }
                catch
                {
                    rowsAffected = 4;
                }

                connection.Close();

                return rowsAffected;
            }
        } 

        // retrieves Amount value of specified plan associated with PlanName passed in
        public static decimal RetrievePlanPrice(string planName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT Amount FROM [Plan] WHERE Name = '" + planName + "';";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    return Math.Round(Convert.ToDecimal(command.ExecuteScalar()), 2);
                }
                catch
                {
                    return -1;
                }
            }
        }

        // method for retrieving analytics based on Subscriptions table - used by Analytics Form
        public static int[] RetrieveAnalytics()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int[] values = new int[7];
                try
                {
                    connection.Open();
                    string[] sqlQuery = new string[7];

                    sqlQuery[0] = "SELECT COUNT(*) FROM Subscription;";
                    sqlQuery[1] = "SELECT COUNT(*) FROM Subscription Where SStatus = 'Active';"; 
                    sqlQuery[2] = "SELECT COUNT(*) FROM Subscription Where PlanID BETWEEN 1 AND 4;";
                    sqlQuery[3] = "SELECT COUNT(*) FROM Subscription Where PlanID BETWEEN 5 AND 8;";
                    sqlQuery[4] = "SELECT COUNT(*) FROM Subscription Where PlanID BETWEEN 9 AND 12;";
                    sqlQuery[5] = "SELECT COUNT(*) FROM Subscription Where PlanID BETWEEN 13 AND 16;";
                    sqlQuery[6] = "SELECT COUNT(*) FROM Subscription Where PlanID BETWEEN 17 AND 20;";

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
