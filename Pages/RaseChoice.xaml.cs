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
        private string[] RaseAbilArr, RaseSkArr;
        private string[] randomAbilHuman = new string[2];
        private string[] randomAbilHalf = new string[1];
        public RaseChoice()
        {
            InitializeComponent();
            RaseChoiceButtonNextPage.Visibility = Visibility.Hidden;
            IMGBorder.Visibility = Visibility.Hidden;

            //humanAbb = DataBaseReader.GetRaseAbilites(1);
            //elfSkills = DataBaseReader.GetRaseAbilites(2);
            //dwarfAbb = DataBaseReader.GetRaseAbilites(3);
            //halfAbb = DataBaseReader.GetRaseAbilites(4);

            //humanSkills = DataBaseReader.GetRaseSkills(1);
            //elfSkills = DataBaseReader.GetRaseSkills(2);
            //dwarfSkills = DataBaseReader.GetRaseSkills(3);
            //halfSkills = DataBaseReader.GetRaseSkills(4);

            randomAbilHuman[0] = RandomAbility.Run(1);
            randomAbilHuman[1] = RandomAbility.Run(1);
            randomAbilHalf [0] = RandomAbility.Run(4);


        }

       

        private void RaseAbbAndSkills()
        {
            zd1.Text = $"{DataBaseReader.GetRaseAbilites()}";    
            zd2.Text= $"{DataBaseReader.GetRaseSkills()}";

            RaseAbilArr = StringReader.Convert(DataBaseReader.GetRaseAbilites());
            int RaseAbilOrOrValue;
            List<string> RaseAbilList;
            List<string> RaseAbilOrOrList= StringReader.orOr(RaseAbilArr, out RaseAbilOrOrValue, out RaseAbilList);


            RaseSkArr = StringReader.Convert(DataBaseReader.GetRaseSkills());
            int RaseSkOrOrValue;
            List<string> RaseSkList;
            List<string> RaseSkOrOrList = StringReader.orOr(RaseSkArr, out RaseSkOrOrValue, out RaseSkList);
        }

        private void RaceChoiceButtonHumanIcon_Click (object sender, RoutedEventArgs e)
        {

            Player.SetRaceID(1);
            RaseChoiceTextBlockRaseName.Text = "Człowiek";
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HumanImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
            zd2.Text = "dwie losowo wybrane umiejętności";
        }
        private void RaceChoiceButtonElfIcon_Click(object sender, RoutedEventArgs e)
        {

            Player.SetRaceID(2);

            RaseChoiceTextBlockRaseName.Text = "Elf";
            RaseChoiceTextBlockRaseDescription.Text = DataBaseReader.GetRaseDescription();
            RaseAbbAndSkills();
            RaseChoiceImageRaseImg.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative)); IMGBorder.Visibility = Visibility.Visible;
            RaseChoiceButtonNextPage.Visibility = Visibility.Visible;
        }
        private void RaceChoiceButtonDwarfIcon_Click(object sender, RoutedEventArgs e)
        {
            Player.SetRaceID(3);

            RaseChoiceTextBlockRaseName.Text = "Krasnolud";
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
            zd2.Text += ", jedna dodatkowa losowo wybrana umiejętność";
        }



        private void RaceChoiceButtonNexyPage_Click(object sender, RoutedEventArgs e)
        {
            Player.SetAttributes(DataBaseReader.GetArrayOfRaseAttributes());

            Player.SetAbilites(RaseAbilArr);
            Player.SetSkills(RaseSkArr);

            if (Player.RaseID == 1)
            {
                Player.SetAbilites(randomAbilHuman);
            }
            if (Player.RaseID == 4)
            {
                Player.SetAbilites(randomAbilHalf);
            }

            NavigationService.Navigate(new AttributesRoll());
        }
    }
}
