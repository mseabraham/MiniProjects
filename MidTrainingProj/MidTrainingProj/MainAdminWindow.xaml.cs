using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using MidTrainingProj.Models;
using MidTrainingProj.Classes;
namespace MidTrainingProj
{
    /// <summary>
    /// Interaction logic for MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        private CRUD operation = new CRUD();
        private bool gameEdit;
        private string ogTitle;
        private DateTime ogRelease;

        public MainAdminWindow()
        {
            InitializeComponent();
            gameEdit = false;
            operation.BindGames();
            // LOAD THE LIST VIEW WITH RETRIEVED GAMES
            lvGameSelection.ItemsSource = operation.gameFill;

        }

        private void PopulateGameViewWithSelectedItem(object sender, MouseButtonEventArgs e)
        {
            if (gameGrid.Visibility != Visibility.Visible) gameGrid.Visibility = Visibility.Visible;
            var item = (sender as ListViewItem).DataContext;
            if ((item != null) && gameEdit is false)
            {
                operation.selected = (Game)item;
                viewGameTitle.Text = operation.selected.GameTitle;
                editDate.SelectedDate = operation.selected.ReleaseDate;
                //---need to do the platform and developers
                tbRating.Text = operation.selected.Rating.ToString();

                //Select star image
                switch (operation.selected.Rating)
                {
                    case 1:
                        imgStar.Source = new BitmapImage(new Uri(@"\Images\Star_rating_1_of_5.png"));
                        break;
                    case 2:
                        imgStar.Source = new BitmapImage(new Uri(@"\Images\Star_rating_2_of_5.png"));
                        break;
                    case 3:
                        imgStar.Source = new BitmapImage(new Uri(@"\Images\Star_rating_3_of_5.png"));
                        break;
                    case 4:
                        imgStar.Source = new BitmapImage(new Uri(@"\Images\Star_rating_4_of_5.png"));
                        break;
                    case 5:
                        imgStar.Source = new BitmapImage(new Uri(@"\Images\Star_rating_5_of_5.png"));
                        break;

                }
            }
        }
        private void BtnAddGame_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow win2 = new NewGameWindow();
            win2.ShowDialog();
        }

        private void BtnEditGame_Click(object sender, RoutedEventArgs e)
        {
            //Store values current values for retrival
            gameEdit = true;
            ogTitle = viewGameTitle.Text;
            ogRelease = editDate.SelectedDate.Value;

            //Hide edit button and show save and cancel
            inEdit.Visibility = System.Windows.Visibility.Visible;
            btnEditGame.Visibility = System.Windows.Visibility.Hidden;

            //Allow editing for date and title
            editDate.Focusable = true;
            viewGameTitle.IsReadOnly = false;
        }

        private void BtnEditDone_Click(object sender, RoutedEventArgs e)
        {
            string newTitle = viewGameTitle.Text;
            DateTime newDate = editDate.SelectedDate.Value;
            if (((e.Source as Button).Content.ToString()).Contains("Save"))
            {
                if ( newTitle != operation.selected.GameTitle)
                {
                    operation.UpdateGame(newTitle);
                }
                if ((newTitle != operation.selected.GameTitle) && ( newDate != operation.selected.ReleaseDate))
                {
                    operation.UpdateGame(viewGameTitle.Text, editDate.SelectedDate.Value);
                }
                // RELOAD LIST VIEW WITH UPDATED GAME
                lvGameSelection.ItemsSource = null;
                lvGameSelection.ItemsSource = operation.gameFill;

            }
            else
            {
                //If canceled then return to orignal values
                viewGameTitle.Text = ogTitle;
                editDate.SelectedDate = ogRelease;

            }

            gameEdit = false;

            //Show edit button and hide save and cancel
            inEdit.Visibility = System.Windows.Visibility.Hidden;
            btnEditGame.Visibility = System.Windows.Visibility.Visible;

            //Disable editing for date and title
            editDate.Focusable = false;
            viewGameTitle.IsReadOnly = true;
        }
    }
}
