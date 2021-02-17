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
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void MainMenuButtonNewPlayer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RaseChoice());

        }
        private void MainMenuButtonLoadPlayer_Click(object sender, RoutedEventArgs e)
        {
            string pathh = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save");
            Process.Start(pathh);
        }

        private void MainMenuButtonExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        //test
    }
}
