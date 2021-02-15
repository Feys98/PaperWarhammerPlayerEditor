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


        public static string GetRaseName()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseName From Rase Where ID = '{Player.RaseID}'"));
        }
        public static string GetRaseDescription()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseDescrioption From Rase Where id = '{Player.RaseID}'"));
        }
        public static string GetProfessionName(int professionID)
        {
            return (DataBaseReader.Get1StringValue($"Select ProfessionName From Professions Where id = '{professionID}'"));
        }
        //public static string GetProfessionDescription(int professionID)
        //{
        //    return (DataBaseReader.Get1StringValue($"Select ProfessionDescription From Professions Where id = '{professionID}'"));
        //}
        public static string GetProfessionAbilities(int professionID)
        {
            return (DataBaseReader.Get1StringValue($"Select ProfessionAbilites From Professions Where id = '{professionID}'"));
        }
        public static string GetProfessionSkills(int professionID)
        {
            return (DataBaseReader.Get1StringValue($"Select ProfessionSkills From Professions Where id = '{professionID}'"));
        }
        public static string GetProfessionEQ(int professionID)
        {
            return (DataBaseReader.Get1StringValue($"Select ProfessionEQ From Professions Where id = '{professionID}'"));
        }
        public static string GetProfessionUpgrades(int professionID)
        {
            return (DataBaseReader.Get1StringValue($"Select ProfessionUpgrades From Professions Where id = '{professionID}'"));
        }
    }
}
