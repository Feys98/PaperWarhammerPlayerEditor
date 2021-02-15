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
        private string GetDescription(int _professionID)
        {
            return $"Umiejętności:\n{DataBaseReader.GetProfessionAbilities(_professionID)}\n" +
                $"Zdolności:\n{DataBaseReader.GetProfessionAbilities(_professionID)}\n" +
                $"Wyposażenie:\n{DataBaseReader.GetProfessionEQ(_professionID)}\n" +
                $"Profesje wyjściowe:\n{DataBaseReader.GetProfessionUpgrades(_professionID)}";
        }
        private int roll = 0;
        private int button = 0 ;
        private int professionID,profesionID1, profesionID2, profesionID3;


        public ProfessionChoice()
        {
            InitializeComponent();
            DisplayAtributesOfRase(DataBaseReader.GetArrayOfRaseAttributes());
        }

        private void ProfessionChoiceButtonDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            
            roll++;

            if (roll == 1)
            {
                profesionID1 = ProfessionRollValue.RollProfessionAndGetID();

                ProfessionChoiceButtonChoice1.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice1.Content = DataBaseReader.GetProfessionName(profesionID1);
                

            }
            if (roll == 2)
            {
                do
                {
                    profesionID2 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID2 == profesionID1);

                ProfessionChoiceButtonChoice2.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice2.Content = DataBaseReader.GetProfessionName(profesionID2); //TODO
            }
            if (roll == 3)
            {

                do
                {
                    profesionID3 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID3 == profesionID1 && profesionID3 == profesionID2);

                ProfessionChoiceButtonChoice3.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice3.Content = DataBaseReader.GetProfessionName(profesionID3); //TODO
                ProfessionChoiceButtonDiceRoll.Visibility = Visibility.Hidden;
            }
        }


        

        private void ProfessionChoiceButtonChoice1_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 1;
            professionID = profesionID1;

            ProfessionChoiceTextBlock.Text = GetDescription(professionID);

            DisplayAtributesOfProfession(DataBaseReader.GetArrayOfRaseAttributes(), DataBaseReader.GetArrayOfProfessionAttributes(profesionID1));
        }

        private void ProfessionChoiceButtonChoice2_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 2;
            professionID = profesionID2;

            ProfessionChoiceTextBlock.Text = GetDescription(professionID);
            DisplayAtributesOfProfession(DataBaseReader.GetArrayOfRaseAttributes(), DataBaseReader.GetArrayOfProfessionAttributes(profesionID2));
        }

        private void ProfessionChoiceButtonChoice3_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 3;
            professionID = profesionID3;

            ProfessionChoiceTextBlock.Text = GetDescription(professionID);
            DisplayAtributesOfProfession(DataBaseReader.GetArrayOfRaseAttributes(), DataBaseReader.GetArrayOfProfessionAttributes(profesionID3));
        }



        private void ProfessionChoiceButtonNextPage_Click(object sender, RoutedEventArgs e)
        {
            if (button!= 0)
            {
                Player.SetRaceID(professionID);
                App.Current.Shutdown();
            }
        }
    }
}
