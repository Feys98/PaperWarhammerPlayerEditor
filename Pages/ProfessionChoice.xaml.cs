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

namespace WHeditor
{
    /// <summary>
    /// Logika interakcji dla klasy ProfessionChoice.xaml
    /// </summary>
    public partial class ProfessionChoice : Page
    {

        private void DisplayAtributesOfRase(int[] t)
        {
            WWValue.Content = t[0];
            USValue.Content = t[1];
            KValue.Content = t[2];
            OdpValue.Content = t[3];
            ZrValue.Content = t[4];
            IntValue.Content = t[5];
            SWValue.Content = t[6];
            OgdValue.Content = t[7];
            AValue.Content = t[8];
            ZywValue.Content = t[9];
            SValue.Content = t[10];
            WtValue.Content = t[11];
            SzValue.Content = t[12];
            MagValue.Content = t[13];
            POValue.Content = t[14];
            PPValue.Content = t[15];
            
        }
        private void DisplayAtributesOfProfession(int[] t, int[] t2)
        {
            WWValue.Content = t[0]+ t2[0];
            USValue.Content = t[1] + t2[1];
            KValue.Content = t[2] + t2[2];
            OdpValue.Content = t[3] + t2[3];
            ZrValue.Content = t[4] + t2[4];
            IntValue.Content = t[5] + t2[5];
            SWValue.Content = t[6] + t2[6];
            OgdValue.Content = t[7] + t2[7];
            AValue.Content = t[8] + t2[8];
            ZywValue.Content = t[9] + t2[9];
            SValue.Content = t[10] + t2[10];
            WtValue.Content = t[11] + t2[11];
            SzValue.Content = t[12] + t2[12];
            MagValue.Content = t[13] + t2[13];
            POValue.Content = t[14] + t2[14];
            PPValue.Content = t[15] + t2[15];
        }
        private string[] GetLeft(int _professionID)
        {
            string[] s = new string[4];
            s[0] = $"{DataBaseReader.GetProfessionAbilities(_professionID)}";
            s[1] = $"{DataBaseReader.GetProfessionSkills(_professionID)}";
            s[2] = $"{DataBaseReader.GetProfessionEQ(_professionID)}";
            s[3] = $"{DataBaseReader.GetProfessionUpgrades(_professionID)}";
            return s;
        }
        private void SetLeft(string[] s)
        {
            UMtxt.Text = s[0]; 
            ZDtxt.Text = s[1];
            EQtxt.Text = s[2];
            Nexttxt.Text = s[3];
        }
        private void DisplayDescription ()
        {

        }

        private int roll = 0;
        private int button = 0 ;
        private int professionID,profesionID1, profesionID2, profesionID3;
        private int[] ProfAtt1, ProfAtt2, ProfAtt3;
        private string ProfName1, ProfName2, ProfName3;
        private string ProfDes1, ProfDes2, ProfDes3;
        private string[] ProfLeft1, ProfLeft2, ProfLeft3;


        public ProfessionChoice()
        {
            InitializeComponent();
            DisplayAtributesOfRase(DataBaseReader.GetArrayOfRaseAttributes());
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Hidden;
            ProfessionChoiceButtonChoice3.Visibility = Visibility.Hidden;
            ProfessionChoiceButtonChoice2.Visibility = Visibility.Hidden;
            ProfessionChoiceButtonChoice1.Visibility = Visibility.Hidden;
            IMGBorder.Visibility = Visibility.Hidden;

        }

        private void ProfessionChoiceButtonDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            
            roll++;

            if (roll == 1)
            {
                profesionID1 = ProfessionRollValue.RollProfessionAndGetID();

                ProfessionChoiceButtonChoice1.Visibility = Visibility.Visible;
                ProfName1 = DataBaseReader.GetProfessionName(profesionID1);
                ProfessionChoiceButtonChoice1.Content = ProfName1;
                ProfAtt1 = DataBaseReader.GetArrayOfProfessionAttributes(profesionID1);
                ProfDes1 = DataBaseReader.GetProfessionDescription(profesionID1);
                ProfLeft1 = GetLeft(profesionID1);


            }
            if (roll == 2)
            {
                do
                {
                    profesionID2 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID2 == profesionID1);

                ProfName2 = DataBaseReader.GetProfessionName(profesionID2);
                ProfessionChoiceButtonChoice2.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice2.Content = ProfName2; //TODO
                ProfDes2 = DataBaseReader.GetProfessionDescription(profesionID2);
                ProfAtt2 = DataBaseReader.GetArrayOfProfessionAttributes(profesionID2);
                ProfLeft2 = GetLeft(profesionID2);
            }
            if (roll == 3)
            {

                do
                {
                    profesionID3 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID3 == profesionID1 || profesionID3 == profesionID2);

                ProfName3 = DataBaseReader.GetProfessionName(profesionID3);
                ProfessionChoiceButtonChoice3.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice3.Content = ProfName3; //TODO
                ProfDes3 = DataBaseReader.GetProfessionDescription(profesionID3);
                ProfAtt3 = DataBaseReader.GetArrayOfProfessionAttributes(profesionID3);
                ProfLeft3 = GetLeft(profesionID3);

                ProfessionChoiceButtonDiceRoll.Visibility = Visibility.Hidden;
            }
        }


        

        private void ProfessionChoiceButtonChoice1_Click(object sender, RoutedEventArgs e)
        {
            ProfessionName.Text = ProfName1;
            IMGBorder.Visibility = Visibility.Visible;
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 1;
            professionID = profesionID1;

            ProfessionChoiceDescTextBlock.Text = ProfDes1;
            SetLeft(ProfLeft1);
            DisplayAtributesOfProfession(Player.Attributes, ProfAtt1);

            ProfessionRollProfessionImage.Source = new BitmapImage(new Uri($"../Images/Professions/ProfessionIMG{profesionID1}.png", UriKind.Relative));
        }

        private void ProfessionChoiceButtonChoice2_Click(object sender, RoutedEventArgs e)
        {
            ProfessionName.Text = ProfName2;
            IMGBorder.Visibility = Visibility.Visible;
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 2;
            professionID = profesionID2;

            ProfessionChoiceDescTextBlock.Text = ProfDes2;
            SetLeft(ProfLeft2);
            DisplayAtributesOfProfession(Player.Attributes, ProfAtt2);

            ProfessionRollProfessionImage.Source = new BitmapImage(new Uri($"../Images/Professions/ProfessionIMG{profesionID2}.png", UriKind.Relative));

        }

        private void ProfessionChoiceButtonChoice3_Click(object sender, RoutedEventArgs e)
        {
            ProfessionName.Text = ProfName3;
            IMGBorder.Visibility = Visibility.Visible;
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 3;
            professionID = profesionID3;

            ProfessionChoiceDescTextBlock.Text = ProfDes3;
            SetLeft(ProfLeft3);
            DisplayAtributesOfProfession(Player.Attributes, ProfAtt3);

            ProfessionRollProfessionImage.Source = new BitmapImage(new Uri($"../Images/Professions/ProfessionIMG{profesionID3}.png", UriKind.Relative));

        }


        private void IfButtonThen(string[] s)
        {
            //UMtxt.Text = s[0];
            //ZDtxt.Text = s[1];
            //EQtxt.Text = s[2];
            //Nexttxt.Text = s[3];

            string[] s1, s2, s3, s4;

            s1 = StringReader.Convert(s[0]);
            s2 = StringReader.Convert(s[1]);
            s3 = StringReader.Convert(s[2]);
            s4 = StringReader.Convert(s[3]);
            Player.SetAbilites (s1);
            Player.SetSkills (s2);
            Player.SetEQ (s3);
            Player.SetNextProf (s4);
        }
        private void ProfessionChoiceButtonNextPage_Click(object sender, RoutedEventArgs e)
        {
            if (button!= 0)
            {
                switch (button)
                {
                    case 1:
                        IfButtonThen(ProfLeft1);
                        Player.SetProffesionID(profesionID1);
                        break;
                    case 2:
                        IfButtonThen(ProfLeft2);
                        Player.SetProffesionID(profesionID2);
                        break;
                    case 3:
                        IfButtonThen(ProfLeft3);
                        Player.SetProffesionID(profesionID3);
                        break;
                    default:
                        break;
                }
                NavigationService.Navigate(new SummaryPage());
            }
        }
    }
}
