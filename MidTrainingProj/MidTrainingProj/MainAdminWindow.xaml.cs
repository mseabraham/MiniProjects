using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using MidTrainingProj.Models;

namespace MidTrainingProj
{
    /// <summary>
    /// Interaction logic for MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        List<Game> gameFill = new List<Game>();
        public MainAdminWindow()
        {
            InitializeComponent();


            using (var db = new Gam3Sp0tContext())
            {
                // FILL GAME SELECTION WITH INFORMATION OF GAMES IN THE DATABASE

                var query1 =
                    from g in db.Games
                    select g;
                foreach (var game in query1)
                {
                    gameFill.Add(game);
                }
            }

            // LOAD THE LIST VIEW WITH RETRIEVED GAMES
            lvGameSelection.Items.Clear();
            lvGameSelection.ItemsSource = gameFill;
        }

        private void btnAddGame_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow win2 = new NewGameWindow();
            win2.ShowDialog();
        }

    }
}
