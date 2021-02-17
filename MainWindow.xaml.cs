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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string pathhh = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Save");
            System.IO.Directory.CreateDirectory(pathhh);


            DataBaseReader.Load();
            App.ParentWindowRef = this;
            this.ParentFrame.Navigate(new MainMenu());
        }
    }
}
