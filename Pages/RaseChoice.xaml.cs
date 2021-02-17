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
            RaseChoiceButtonNextPage.Visibility = Visibility.Hidden;
            IMGBorder.Visibility = Visibility.Hidden;
        }

        private void RaseAbbAndSkills()
        {
            //RaseChoiceTextBlockRaseSkillsAndAbbilities.Text = 
            //    $"Zdolności:\n" +
            //    $"{DataBaseReader.GetRaseAbilites()}\n" +
            //    $"Umiejętności:\n" +
            //    $"{DataBaseReader.GetRaseSkills()}";



            string [] s1 = StringReader.Convert(DataBaseReader.GetRaseAbilites());
            List<string> ss1= new List<string>();
            int value1;
            ss1 = StringReader.orOr(s1,out value1);



            string newS1 = "";

            foreach (var x in s1)
            {
                newS1 += $"{x} ";
            }


            string newS2= "";

            foreach (var x in ss1)
            {
                newS2 += $"{x} ";
            }


            //zd1.Text = $"{DataBaseReader.GetRaseAbilites()}";
            //zd2.Text = $"{DataBaseReader.GetRaseSkills()}";
            zd1.Text = $"{newS1} !AND! " +
                $"{newS2}";
            zd2.Text = $"{value1}";
        }

        private void RaceChoiceButtonHumanIcon_Click (object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(1);
            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HumanImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonElfIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(2);

            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonDwarfIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(3);

            RaseChoiceTextBlockRaseName.Text = DataBaseReader.GetRaseName();
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/DwarfImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonHalflingIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(4);

            RaseChoiceTextBlockRaseName.Text = "Niziołek";
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HalflingImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }



        private void RaceChoiceButtonNexyPage_Click(object sender, RoutedEventArgs e)
        {

            Player.SetAttributes(DataBaseReader.GetArrayOfRaseAttributes());
            NavigationService.Navigate(new AttributesRoll());

        }
    }
}
