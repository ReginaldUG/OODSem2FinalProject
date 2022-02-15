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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void LstBoxDisplaySeason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         //Testing the Itemsource for the Seasons choice Display   
            string[] testSeasons = { "2021/2022", "2020/2021", "2019/2020" };

            List<string> Seasons = new List<string>();
            foreach (string seasondates in testSeasons)
            {
                Seasons.Add(seasondates);
            }
            ComboBoxDisplaySeason.ItemsSource = Seasons;
            //WORKS

         //Testing the League choice selector
            string[] testLeagueschoice = {"La Liga", "Premier League", "Serie A", "Ligue 1", "Bundesliga" };
            List<string> LeagueChoice = new List<string>();
            foreach (string leaguechoices in testLeagueschoice)
            {
                LeagueChoice.Add(leaguechoices);
            }
            LstBoxLeagueChoice.ItemsSource = LeagueChoice;
            //WORKS
        }

        
    }
}
