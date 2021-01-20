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
    /// Logika interakcji dla klasy RaseChoice.xaml
    /// </summary>
    public partial class RaseChoice : Page
    {

        
        public RaseChoice()
        {
            InitializeComponent();
            SimpleLabel.Content = "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala TwojaStaraNapierdala " +
                "TwojaStaraNapierdala ";
            //SimpleIMG.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/WariorImg.png", UriKind.Relative));
        }


        private void RaceChoiceButtonWariorIcon_Click (object sender, RoutedEventArgs e)
        {
            SimpleIMG.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/WariorImg.png", UriKind.Relative));
        }
        private void RaceChoiceButtonElfIcon_Click(object sender, RoutedEventArgs e)
        {
            SimpleIMG.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/ElfImg.png", UriKind.Relative));
        }
        private void RaceChoiceButtonDwarfIcon_Click(object sender, RoutedEventArgs e)
        {
            SimpleIMG.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/DwarfImg.png", UriKind.Relative));
        }
        private void RaceChoiceButtonHalflingIcon_Click(object sender, RoutedEventArgs e)
        {
            SimpleIMG.Source = new BitmapImage(new Uri("../Images/PageRaseChoice/HalflingImg.png", UriKind.Relative));
        }
    }
}
