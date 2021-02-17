using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Logika interakcji dla klasy SummaryPage.xaml
    /// </summary>
    public partial class SummaryPage : Page
    {
        public SummaryPage()
        {
            InitializeComponent();
            rasaName.Text = DataBaseReader.GetRaseName(Player.RaseID);
            profName.Text = DataBaseReader.GetProfessionName(Player.ProffesionID);
            string help1 = "";
            foreach (var x in Player.Abilites)
            {
                help1 += $"{x}, ";
            }
            UMtxt.Text = help1;
            string help2 = "";
            foreach (var x in Player.Skills)
            {
                help2 += $"{x}, ";
            }
            ZDtxt.Text = help2;
            string help3 = "";
            foreach (var x in Player.EQ)
            {
                help3 += $"{x}, ";
            }
            EQtxt.Text = help3;
            string help4 = "";
            foreach (var x in Player.NextProf)
            {
                help4 += $"{x}, ";
            }
            Nexttxt.Text = help4;
            DisplayAtributes(Player.Attributes);
            ProfessionImage.Source = new BitmapImage(new Uri($"../Images/Professions/ProfessionIMG{Player.ProffesionID}.png", UriKind.Relative));

        }

        private void DisplayAtributes(int[] t)
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

        private void saveAndExitButton_Click(object sender, RoutedEventArgs e)
        {

            ExitButton.Visibility = Visibility.Hidden;
            saveAndExitButton.Visibility = Visibility.Hidden;

            UIElement element = scrollViewer.Content as UIElement;

            string pathh = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save\\screenshot.png");

            Uri path = new Uri(pathh);
            ScreenShot.CaptureScreen(element, path);
            string pathhh = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save");
            Process.Start(pathhh);
            App.Current.Shutdown();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
