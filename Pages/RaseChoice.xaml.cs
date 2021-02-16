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
    public partial class RaseChoice : Page
    {
        public RaseChoice()
        {
            InitializeComponent(); 
        }


        private void RaceChoiceButtonHumanIcon_Click (object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(1);
            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HumanImg.png", UriKind.Relative));
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonElfIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(2);

            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative));
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonDwarfIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(3);

            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/DwarfImg.png", UriKind.Relative));
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonHalflingIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(4);

            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HalflingImg.png", UriKind.Relative));
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }



        private void RaceChoiceButtonNexyPage_Click(object sender, RoutedEventArgs e)
        {

            Player.SetAttributes(DataBaseReader.GetArrayOfRaseAttributes());
            NavigationService.Navigate(new AttributesRoll());

        }
    }
}
