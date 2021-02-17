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

        static string[] ArrayOfAttributesString = {"WW","US","K","Odp","Zr","Int","SW","Ogd","A","Zyw","S","Wt","Sz","Mag","PO","PP"};
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

        public static string GetArrayOfAttributesString(int i)
        {
            return ArrayOfAttributesString[i];
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
                if (dataReader.IsDBNull(0))
                {
                    return 0;
                }
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

        public static int[] GetArrayOfRaseAttributes()
        {
            int[] arr = new int[16];

            for (int i = 0; i < 16; i++)
            {
                arr[i] = DataBaseReader.Get1IntValue($"SELECT {ArrayOfAttributesString[i]} FROM RaseAttributes WHERE ID = '{Player.RaseID}'");
            }

            return arr;
        }
        public static int[] GetArrayOfProfessionAttributes(int ID)
        {
            int[] arr = new int[16];

            for (int i = 0; i < 16; i++)
            {
                arr[i] = DataBaseReader.Get1IntValue($"SELECT {ArrayOfAttributesString[i]} FROM ProfessionsAttributes WHERE ID = '{ID}'");
            }

            return arr;
        }
        public static string GetRaseName()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseName From Rase Where ID = '{Player.RaseID}'"));
        }
        public static string GetRaseName(int id)
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseName From Rase Where ID = '{id}'"));
        }
        public static string GetRaseDescription()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseDescrioption From Rase Where id = '{Player.RaseID}'"));
        }

        public static string GetRaseAbilites()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseAbilites From Rase Where id = '{Player.RaseID}'"));
        }
        public static string GetRaseSkills()
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseSkils From Rase Where id = '{Player.RaseID}'"));
        }

        public static string GetRaseAbilites(int ID)
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseAbilites From Rase Where id = '{ID}'"));
        }
        public static string GetRaseSkills(int ID)
        {
            return (DataBaseReader.Get1StringValue($"SELECT RaseSkils From Rase Where id = '{ID}'"));
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
            return (DataBaseReader.Get1StringValue($"Select ProfessionsUpgrades From Professions Where id = '{professionID}'"));
        }
        public static string GetProfessionDescription(int professionID)
        { 
            return (DataBaseReader.Get1StringValue($"Select ProfessionDescription From Professions Where id = '{professionID}'"));
        }


        public static int GetPPPointsValue(int raseID, int rollValue)
        {
            return (DataBaseReader.Get1IntValue($"SELECT PPPoints FROM PPPointsRoll WHERE RaseID = '{raseID}' AND Roll = '{rollValue}'"));
        }


    }
}
