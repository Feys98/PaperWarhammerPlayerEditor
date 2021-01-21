using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


using Dapper;

namespace WHeditor
{
    /// <summary>
    /// Logika interakcji dla klasy RaseChoice.xaml
    /// </summary>
    /// 




    public partial class RaseChoice : Page
    {

        public RaseChoice()
        {
            InitializeComponent();
        }  





        private void RaceChoiceButtonWariorIcon_Click (object sender, RoutedEventArgs e)
        {
            //----------------

            string connectionString;
            SqlConnection cnn;

            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\WHPE_db.mdf;Integrated Security=True";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select RaseName From Rase Where id = '1'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) ;
            }


            cnn.Close();

            //----------------

            RaseChoiceTextBlockRaseDescription.Text = Output;
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/WariorImg.png", UriKind.Relative));
        }
        private void RaceChoiceButtonElfIcon_Click(object sender, RoutedEventArgs e)
        {
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative));
            RaseChoiceTextBlockRaseDescription.Text = "simpletextElf";
        }
        private void RaceChoiceButtonDwarfIcon_Click(object sender, RoutedEventArgs e)
        {
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/DwarfImg.png", UriKind.Relative));
            RaseChoiceTextBlockRaseDescription.Text = "Simple text Dwarf";

        }
        private void RaceChoiceButtonHalflingIcon_Click(object sender, RoutedEventArgs e)
        {
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HalflingImg.png", UriKind.Relative));
            RaseChoiceTextBlockRaseDescription.Text = "simpleTextHalfling";

        }
    }
}
