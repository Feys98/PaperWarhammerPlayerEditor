﻿using System;
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
        private int roll = 0;
        private int button = 0 ;
        private int professionID,profesionID1, profesionID2, profesionID3;
        public ProfessionChoice()
        {
            InitializeComponent();
        }

        private void ProfessionChoiceButtonDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            
            roll++;

            if (roll == 1)
            {
                profesionID1 = ProfessionRollValue.RollProfessionAndGetID();

                ProfessionChoiceButtonChoice1.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice1.Content = profesionID1.ToString(); //TODO
        

            }
            if (roll == 2)
            {
                do
                {
                    profesionID2 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID2 == profesionID1);

                ProfessionChoiceButtonChoice2.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice2.Content = profesionID2.ToString(); //TODO
            }
            if (roll == 3)
            {

                do
                {
                    profesionID3 = ProfessionRollValue.RollProfessionAndGetID();
                } while (profesionID3 == profesionID1 && profesionID3 == profesionID2);

                ProfessionChoiceButtonChoice3.Visibility = Visibility.Visible;
                ProfessionChoiceButtonChoice3.Content = profesionID3.ToString(); //TODO
                ProfessionChoiceButtonDiceRoll.Visibility = Visibility.Hidden;
            }
        }


        

        private void ProfessionChoiceButtonChoice1_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 1;
            professionID = profesionID1;
        }

        private void ProfessionChoiceButtonChoice2_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 2;
            professionID = profesionID2;
        }

        private void ProfessionChoiceButtonChoice3_Click(object sender, RoutedEventArgs e)
        {
            ProfessionChoiceButtonNextPage.Visibility = Visibility.Visible;
            button = 3;
            professionID = profesionID3;
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
