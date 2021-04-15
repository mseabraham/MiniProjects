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

using MidProjClasses;
using MidProjData;

namespace MidProjWPF
{
    /// <summary>
    /// Interaction logic for MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        private GameCRUD _operation;
        public List<Game> _gameFill;
        private bool _gameEdit;
        private string _ogTitle;
        private DateTime _ogRelease;

        public MainAdminWindow()
        {
            InitializeComponent();
            _gameEdit = false;
            _gameFill = new List<Game>();
            _operation = new GameCRUD();
            PopulateGameListView();

        }

        public void PopulateGameListView()
        {
            _gameFill.Clear();
            _gameFill = _operation.GetGames();
            lvGameSelection.ItemsSource = _gameFill;

        }

        private void PopulateGameViewWithSelectedItem(object sender, MouseButtonEventArgs e)
        {
            if (gameGrid.Visibility != Visibility.Visible) gameGrid.Visibility = Visibility.Visible;
            var item = (sender as ListViewItem).DataContext;
            if ((item != null) && _gameEdit is false)
            {
                _operation.SelectedGame = (Game)item;
                viewGameTitle.Text = _operation.SelectedGame.GameTitle;
                editDate.SelectedDate = _operation.SelectedGame.ReleaseDate;
                //---need to do the platform and developers
                tbRating.Text = _operation.SelectedGame.Rating.ToString();

                //Select star image
                switch (_operation.SelectedGame.Rating)
                {
                    case 1:
                        imgStar.Source = new BitmapImage(new Uri(@"Images/Star_rating_1_of_5.png", UriKind.Relative));
                        break;
                    case 2:
                        imgStar.Source = new BitmapImage(new Uri(@"Images/Star_rating_2_of_5.png", UriKind.Relative));
                        break;
                    case 3:
                        imgStar.Source = new BitmapImage(new Uri(@"Images/Star_rating_3_of_5.png", UriKind.Relative));
                        break;
                    case 4:
                        imgStar.Source = new BitmapImage(new Uri(@"Images/Star_rating_4_of_5.png", UriKind.Relative));
                        break;
                    case 5:
                        imgStar.Source = new BitmapImage(new Uri(@"Images/Star_rating_5_of_5.png", UriKind.Relative));
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
            _gameEdit = true;
            _ogTitle = viewGameTitle.Text;
            _ogRelease = editDate.SelectedDate.Value;

            //Hide edit button and show save and cancel
            inEdit.Visibility = Visibility.Visible;
            btnEditGame.Visibility = Visibility.Hidden;

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
                _operation.UpdateGame(viewGameTitle.Text, editDate.SelectedDate.Value);
              
                // RELOAD LIST VIEW WITH UPDATED GAME
                lvGameSelection.ItemsSource = null;
                lvGameSelection.ItemsSource = _operation.gameFill;

            }
            else
            {
                //If canceled then return to orignal values
                viewGameTitle.Text = _ogTitle;
                editDate.SelectedDate = _ogRelease;

            }

            _gameEdit = false;

            //Show edit button and hide save and cancel
            inEdit.Visibility = Visibility.Hidden;
            btnEditGame.Visibility = Visibility.Visible;

            //Disable editing for date and title
            editDate.Focusable = false;
            viewGameTitle.IsReadOnly = true;
        }

        private void BtnEditDeveloper_Click(object sender, RoutedEventArgs e)
        {
            EditDevelopersWindow window = new EditDevelopersWindow();
            window.ShowDialog();

        }

        private void BtnEditPlatform_Click(object sender, RoutedEventArgs e)
        {
            EditPlatformWindow window = new EditPlatformWindow();
            window.ShowDialog();

        }

        private void BtnDeleteGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this game?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                _operation.DeleteGame();
                PopulateGameListView();
                _gameEdit = false;
                gameGrid.Visibility = Visibility.Hidden;
                
            }
        }
    }
}
