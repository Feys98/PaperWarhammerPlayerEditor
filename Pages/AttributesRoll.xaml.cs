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
    /// Logika interakcji dla klasy AttributesRoll.xaml
    /// </summary>
    public partial class AttributesRoll : Page
    {
        public AttributesRoll()
        {
            InitializeComponent();

            AttributoRollPageButtonNextPage.Visibility = Visibility.Hidden;

            switch (Player.RaseID)
            {
                case 1:
                    AttributeRollRaseImage.Source= new BitmapImage(new Uri("../Images/PageRaseChoice/HumanImg.png", UriKind.Relative));
                    break;
                case 2:
                    AttributeRollRaseImage.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative));
                    break;
                case 3:
                    AttributeRollRaseImage.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/DwarfImg.png", UriKind.Relative));
                    break;
                case 4:
                    AttributeRollRaseImage.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HalflingImg.png", UriKind.Relative));
                    break;
                default:
                    throw new Exception();//todo
                    break;
            }

            DisplayAtributesOfRase(Player.Attributes);

        }

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
        int roll = 0, rollValue = 0;
        private void RollHelper1(int roll,out int rollValue)
        {
            roll--;
            rollValue = DiceRoll.K_Twenty();
            AttributeRollTitleTextBlock.Text = $"Losowanie Atrybutów dla ({DataBaseReader.GetArrayOfAttributesString(roll+1)}) K20";
            AttributeRollValueTextBlock.Text = $"({DataBaseReader.GetArrayOfAttributesString(roll)}) = {Player.Attributes[roll]} + {rollValue}";
            Player.SetOneAttribute(roll, Player.Attributes[roll]+rollValue );
            DisplayAtributesOfRase(Player.Attributes);
        }



        private void AttributeRollDiceButton_Click(object sender, RoutedEventArgs e)
        {        
            roll++;
            switch (roll)
            {
                case 1:
                    //ww
                    RollHelper1(roll, out rollValue);
                    break;
                case 2:
                    //us
                    RollHelper1(roll, out rollValue);
                    break;
                case 3:
                    //k                   
                    RollHelper1(roll, out rollValue);
                    //s
                    Player.SetOneAttribute(10,Player.Attributes[2]/10);
                    break;
                case 4:
                    //odp
                    RollHelper1(roll, out rollValue);
                    //wt
                    Player.SetOneAttribute(11,Player.Attributes[3]/10);
                    break;
                case 5:
                    //zr
                    RollHelper1(roll, out rollValue);
                    break;
                case 6:
                    //int
                    RollHelper1(roll, out rollValue);
                    break;
                case 7:
                    //sw
                    RollHelper1(roll, out rollValue);
                    break;
                case 8:
                    //ogd
                    RollHelper1(roll, out rollValue);
                    AttributeRollTitleTextBlock.Text = $"Losowanie Atrybutów dla ({DataBaseReader.GetArrayOfAttributesString(9)}) K4";
                    break;
                case 9:
                    //zyw

                    int r = DiceRoll.K_Ten(), value = 0, valueDefault=0, newRoll=0;

                    switch (Player.RaseID)
                    {
                        case 1:
                            valueDefault = 10;
                            break;
                        case 2:
                            valueDefault = 9;
                            break;
                        case 3:
                            valueDefault = 11;
                            break;
                        case 4:
                            valueDefault = 8;
                            break;
                        default:
                            break;
                    }

                    do
                    {
                        switch (r)
                        {
                            case 3:
                                value = valueDefault+0;
                                newRoll = 0;
                                break;
                            case 6:
                                value = valueDefault+1;
                                newRoll = 0;
                                break;
                            case 9:
                                value = valueDefault+2;
                                newRoll = 0;
                                break;
                            case 10:
                                value = valueDefault+3;
                                newRoll = 0;
                                break;
                            default:
                                r++;
                                break;
                        }
                        if (r>11)
                        {
                            throw new OutOfRollRangeException();
                        }
                    } while (value == 0);


                    AttributeRollValueTextBlock.Text = $"({DataBaseReader.GetArrayOfAttributesString(9)}) = {Player.Attributes[9]} + {newRoll}";
                    Player.SetOneAttribute(9, value);
                    DisplayAtributesOfRase(Player.Attributes);
                    AttributeRollTitleTextBlock.Text = $"Losowanie Atrybutów dla ({DataBaseReader.GetArrayOfAttributesString(15)}) K4";
                    break;
                case 10:
                    r = DiceRoll.K_Ten();
                    value = 0;
                    do
                    {
                        switch (r)
                        {
                            case 4:
                                value = 1;
                                break;
                            case 7:
                                value = 2;
                                break;
                            case 10:
                                value = 3;
                                break;
                            default:
                                r++;
                                break;
                        }
                        if (r > 11)
                        {
                            throw new OutOfRollRangeException();
                        }
                    } while (value == 0);

                    int ppValue = DataBaseReader.GetPPPointsValue(Player.RaseID, value);
                    AttributeRollValueTextBlock.Text = $"({DataBaseReader.GetArrayOfAttributesString(15)}) = {Player.Attributes[15]} + {ppValue}";
                    Player.SetOneAttribute(15, ppValue);
                    DisplayAtributesOfRase(Player.Attributes);
                    AttributeRollButtonDiceRoll.Visibility = Visibility.Hidden;
                    AttributeRollTitleTextBlock.Text = $"";
                    NameOfAttributesBorder.Visibility = Visibility.Hidden;
                    AttributoRollPageButtonNextPage.Visibility = Visibility.Visible;
                    break;
                default:
                    AttributeRollButtonDiceRoll.Visibility = Visibility.Hidden;
                    break;
            }
           
        }


        private void AttributoRollPageButtonNextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfessionChoice());
        }

    }
}
