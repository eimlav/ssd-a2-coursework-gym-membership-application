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
    public class Start_DAL
    {
        public Start_DAL()
        {            
        }

        // local variable used by DAL for connecting to SQL database
        private static string _connectionString = ConfigurationManager.ConnectionStrings["STUDIO2 Subscription Manager SQL"].ConnectionString; 

        // performs automatic validation of all subscriptions to check for any new subscriptions that need made, expired or suspended
        // and generates invoices to correspond to these
        public static int FullSystemCheck()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // 1 = application needs restarted to refresh connectionStrings
                // 2 = application does not need restarted
                int restartApp = 1;
                try
                {
                    int rowsAffected = -1;
                    DateTime today = DateTime.Today.Date;
                    // retieves active subscription records
                    string sqlQuery = "SELECT * FROM Subscription WHERE SStatus = 'Active'";                
                    connection.Open();
                    // application does not need restarted
                    restartApp = 0;
                    SqlCommand commandStart = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(commandStart);                    
                    DataTable ds = new DataTable();
                    dataAdapter.Fill(ds);
                    //                                  //
                    //  SUBSCRIPTION INVOICE GENERATION //
                    //                                  //
                    // for each subscription record...
                    foreach(DataRow row in ds.Rows)
                    {                       
                        DateTime nextInvoice = Convert.ToDateTime(row["NextInvoice"]);

                        // Todays date = NextInvoice - 7 days OR Todays date = PeriodEndDate
                        if (today.Date.ToString("yyyy-MM-dd") == nextInvoice.AddDays(-7).Date.ToString("yyyy-MM-dd") || today.Date.ToString("yyyy-MM-dd") == Convert.ToDateTime(row["PeriodEndDate"]).ToString("yyyy-MM-dd"))
                        {                                     
                            string subID = row["SubscriptionID"].ToString();
                            SqlCommand command;

                            // Check if an invoice has already been issued today
                            // -1 = No invoice generated OR Todays date = PeriodEndDate -> Generate invoice
                            // 1 = Invoice already generated
                            if (today.Date.ToString("yyyy-MM-dd") == nextInvoice.AddDays(-7).Date.ToString("yyyy-MM-dd"))
                            {
                                sqlQuery = "SELECT * FROM Invoice WHERE IssueDate = '" + today.Date.ToString("yyyy-MM-dd") + "' AND SubscriptionID = " + subID + ";";
                                command = new SqlCommand(sqlQuery, connection);
                                rowsAffected = command.ExecuteNonQuery();
                            }
                            else if (today.Date.ToString("yyyy-MM-dd") == Convert.ToDateTime(row["PeriodEndDate"]).ToString("yyyy-MM-dd"))
                            {
                                rowsAffected = -1;
                            }                                           
                                         
                            // Generate invoice ELSE move onto next subscription record
                            if(rowsAffected == -1)
                            {                                     
                                // retrieve plan record corresponding to the PlanID of the current susbcription record
                                sqlQuery = "SELECT * FROM [Plan] WHERE PlanID = '" + row["PlanID"].ToString() + "';";
                                
                                command = new SqlCommand(sqlQuery, connection);

                                int planID = 0, planMonths = 0;
                                string planInterval = "";

                                SqlDataReader dataReader = command.ExecuteReader();

                                dataReader.GetSchemaTable();

                                // assign values retrieved from Plan table to local variables
                                while (dataReader.Read())
                                {
                                    planID = Convert.ToInt32((dataReader.GetValue(dataReader.GetOrdinal("PlanID"))));

                                    planMonths = Convert.ToInt32((dataReader.GetValue(dataReader.GetOrdinal("Months"))));

                                    planInterval = (dataReader.GetValue(dataReader.GetOrdinal("Interval"))).ToString();
                                }
                                dataReader.Close();

                                DateTime endDate = Convert.ToDateTime(row["PeriodEndDate"].ToString());
                             
                                // check to see whether invoice is issued monthly or at PeriodEndDate                                                              
                                if(planInterval == "month")
                                {                                  
                                    // determines whether an invoice is issued, a new subscription cycle is started or to end the subscription
                                    if (nextInvoice < endDate)
                                    {                   
                                        nextInvoice = today.AddMonths(1).Date;
                                        sqlQuery = "UPDATE Subscription SET NextInvoice = '" + nextInvoice.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";                                
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                        sqlQuery = "INSERT INTO Invoice VALUES('" + today.Date.ToString("yyyy-MM-dd") + "'," + subID + ",'Pending');";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                    } 
                                    else if (today.Date == endDate && row["Recurring"].ToString() == "True")
                                    {                             
                                        nextInvoice = today.AddMonths(1).Date;
                                        sqlQuery = "UPDATE Subscription SET NextInvoice = '" + nextInvoice.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";                             
                                        command = new SqlCommand(sqlQuery, connection);
                                        rowsAffected = command.ExecuteNonQuery();

                                        sqlQuery = "UPDATE Subscription SET PeriodStartDate = '" + today.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        rowsAffected = command.ExecuteNonQuery();    

                                        sqlQuery = "UPDATE Subscription SET PeriodEndDate = '" + endDate.AddMonths(planMonths).Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";                                        
                                        command = new SqlCommand(sqlQuery, connection);
                                        rowsAffected = command.ExecuteNonQuery();                

                                        sqlQuery = "INSERT INTO Invoice VALUES('" + today.Date.ToString("yyyy-MM-dd") + "'," + subID + ",'Pending');";                                       
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                    }
                                    else if (today.Date == endDate && row["Recurring"].ToString() == "False")
                                    {                                   
                                        nextInvoice = today.AddMonths(12).Date;
                                        sqlQuery = "UPDATE Subscription SET SStatus = 'Expired' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();
                                    }
                                }
                                else
                                {                                    
                                    // determines whether a new subscription cycle is started or to end the subscription
                                    if (today.Date == endDate && row["Recurring"].ToString() == "True")
                                    {
                                        nextInvoice = today.AddMonths(planMonths).Date;
                                        sqlQuery = "UPDATE Subscription SET NextInvoice = '" + nextInvoice.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                        sqlQuery = "UPDATE Subscription SET PeriodStartDate = '" + today.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        rowsAffected = command.ExecuteNonQuery();  

                                        sqlQuery = "UPDATE Subscription SET PeriodEndDate = '" + nextInvoice.Date.ToString("yyyy-MM-dd") + "' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                        sqlQuery = "INSERT INTO Invoice VALUES('" + today.Date.ToString("yyyy-MM-dd") + "'," + subID + ",'Pending');";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();

                                    }
                                    else if (today.Date == endDate && row["Recurring"].ToString() == "False")
                                    {                                       
                                        sqlQuery = "UPDATE Subscription SET SStatus = 'Expired' WHERE SubscriptionID = " + subID + ";";
                                        command = new SqlCommand(sqlQuery, connection);
                                        command.ExecuteNonQuery();
                                    }
                                }                              
                            }
                        }
                    }
                    //                       //
                    //  INVOICE VERIFICATION //
                    //                       //      
                    // retrieves pending invoices records
                    sqlQuery = "SELECT * FROM Invoice WHERE IStatus = 'Pending'";
                    commandStart = new SqlCommand(sqlQuery, connection);
                    dataAdapter = new SqlDataAdapter(commandStart);
                    ds = new DataTable();
                    dataAdapter.Fill(ds);              
                    // for each invoice record...
                    foreach (DataRow row in ds.Rows)
                    {
                        SqlCommand command = new SqlCommand(sqlQuery, connection);                        
                        // check if invoice was issued  more than 7 days ago -> set IStatus to 'Not Paid' and suspend subscription if so
                        if (Convert.ToDateTime(row["IssueDate"]).AddDays(7).Date < today.Date)
                        {
                            sqlQuery = "UPDATE Invoice SET IStatus = 'Not Paid' WHERE SubscriptionID = " + row["SubscriptionID"].ToString() + " ;";                  
                            command = new SqlCommand(sqlQuery, connection);
                            command.ExecuteNonQuery();

                            sqlQuery = "UPDATE Subscription SET SStatus = 'Suspended' WHERE SubscriptionID = " + row["SubscriptionID"].ToString() + " ;";                           
                            command = new SqlCommand(sqlQuery, connection);
                            command.ExecuteNonQuery();
                        }                       
                    }

                    // FullSystemCheck successful
                    return 1;
                }
                catch(Exception e)
                {                   
                    if(restartApp == 1)
                    {
                        // application is restarted
                        return 2;
                    }
                    else
                    {
                        // error encountered
                        return 3;
                    }
                    
                }
            }
        }
        
    }
}
