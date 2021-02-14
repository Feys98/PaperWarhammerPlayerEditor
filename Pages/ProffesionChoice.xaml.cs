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
    /// Logika interakcji dla klasy ProffesionChoice.xaml
    /// </summary>
    public partial class ProffesionChoice : Page
    {
        public int RollValue { get; set; }
        int Roll = 0;
        public ProffesionChoice()
        {
            InitializeComponent();
        }

        private void ProffesionChoiceButtonDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            RollValue = DiceRoll.K_OneHundred();
            Roll++;

            if (Roll == 1)
            {
                ProffesionChoiceButtonChoice1.Visibility = Visibility.Visible;
                ProffesionChoiceButtonChoice1.Content = "ProffesionNameNo.1"; //TODO


                Player.SetProffesionID(RollValue);

            }
            if (Roll == 2)
            {
                ProffesionChoiceButtonChoice2.Visibility = Visibility.Visible;
                ProffesionChoiceButtonChoice2.Content = "ProffesionNameNo.2"; //TODO
            }
            if (Roll == 3)
            {
                ProffesionChoiceButtonChoice3.Visibility = Visibility.Visible;
                ProffesionChoiceButtonChoice3.Content = "ProffesionNameNo.3"; //TODO
                ProffesionChoiceButtonDiceRoll.Visibility = Visibility.Hidden;
            }
        }


        

        private void ProffesionChoiceButtonChoice1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ProffesionChoiceButtonChoice2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProffesionChoiceButtonChoice3_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
