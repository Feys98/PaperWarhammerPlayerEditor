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
        }

        private void RaceChoiceImgWariorIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new TEST());
        }

        private void MouseTestFunc(object sender, MouseEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new TEST());
        }


    }
}
