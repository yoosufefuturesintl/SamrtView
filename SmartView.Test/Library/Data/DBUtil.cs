using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace SmartView.Test.Library.Data
{
    class DBUtil
    {
        private static String DB_SOURCE = "";
        private static String DB_INITAL_CATALOGE = "";
        private static String DB_USER_NAME = "";
        private static String DB_PASSWORD = "";
        private static String DB_TRUSTED_CONNECTION = "";
        private static String DB_CONNECTION_TIMEOUT = "";
        private static String DB_CONNECTION_STRING = "";

        public DBUtil()
        {
            DB_SOURCE = "Data Source=" + ConfigurationSettings.AppSettings["dbSource"] + ";";
            DB_INITAL_CATALOGE = "Initial Catalog=" + ConfigurationSettings.AppSettings["dbInitialCatalog"] + ";";
            DB_USER_NAME = "User id=" + ConfigurationSettings.AppSettings["dbUserId"] + ";";
            DB_PASSWORD = "Password=" + ConfigurationSettings.AppSettings["dbPassword"] + ";";
            DB_TRUSTED_CONNECTION = "Trusted_Connection=" + ConfigurationSettings.AppSettings["dbTrustedConnection"] +
                                    ";";
            DB_CONNECTION_TIMEOUT = "Trusted_Connection=" +
                                    ConfigurationSettings.AppSettings["dbConnectionTimeout"] + ";";
            DB_CONNECTION_STRING = DB_SOURCE + DB_INITAL_CATALOGE + DB_USER_NAME + DB_PASSWORD + DB_TRUSTED_CONNECTION;
        }

      

        public String getData(String sql) 
        {
            String data = "";
            //try
            //{
                var comm = new SqlCommand();
                comm.Connection = new SqlConnection(DB_CONNECTION_STRING);

                comm.CommandText = sql;
                comm.Connection.Open();


                SqlDataReader cursor = comm.ExecuteReader();
                cursor.Read();
                data = cursor.GetValue(0).ToString();
                comm.Connection.Close();
            //}
            //catch (Exception e)
            //{
                
              //  Debugger.Log(1, " EXCPTION", "============== db exception ==========    " + e.StackTrace);
            //}
            
            return data;
        }

        public void UpdateDb(String sql)
        {
            String data = "";
            try
            {
                var comm = new SqlCommand();
                comm.Connection = new SqlConnection(DB_CONNECTION_STRING);

                comm.CommandText = sql;
                comm.Connection.Open();
                comm.ExecuteNonQuery();

                comm.Connection.Close();
            }
            catch (Exception e)
            {
               // Debugger.Log(1, " EXCPTION", "============== db exception ==========    " + e.StackTrace);
            }
        }
    }
}
