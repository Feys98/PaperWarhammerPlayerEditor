using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WHeditor
{
    public static class DataBaseReader
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\WHPE_db.mdf;Integrated Security=True";
        public static string ConnectionString
        {
            get { return connectionString; }
        }

        public static void Load()
        {
            String Query="";
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            SqlCommand command;



            command = new SqlCommand(Query, cnn);

            cnn.Close();
        }



        public static string Get1StringValue(string Query)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String Output = "";

            command = new SqlCommand(Query, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0).ToString();
            }

            cnn.Close();
            return Output;
        }
        public static int Get1IntValue(string Query)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(ConnectionString);

            cnn.Open();

            SqlCommand command = new SqlCommand(Query, cnn);
            SqlDataReader dataReader = command.ExecuteReader(); ;

            if (dataReader.HasRows)
            {
                dataReader.Read();
                var Output = dataReader.GetInt32(0);
                return Output;
            }
            else
            {
                cnn.Close();
                return 0;             
            }  
        }



        //--------------------------------

        public static int GetRaseID()
        {
            return (DataBaseReader.Get1IntValue($"Select ID From Rase Where id = '{Player.RaseID}'"));
        }
        public static string GetRaseName()
        {
            return (DataBaseReader.Get1StringValue($"Select RaseName From Rase Where id = '{Player.RaseID}'"));
        }
        public static string GetRaseDescription()
        {
            return (DataBaseReader.Get1StringValue($"Select RaseDescription From Rase Where id = '{Player.RaseID}'"));
        }
    }
}
