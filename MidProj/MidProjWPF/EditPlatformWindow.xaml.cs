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
using System.Windows.Shapes;
using MidProjClasses;
using MidProjData;

namespace MidProjWPF
{
    /// <summary>
    /// Interaction logic for EditPlatformWindow.xaml
    /// </summary>
    public partial class EditPlatformWindow : Window
    {
        private List<Platform> _platforms;
        public GameCRUD _game;
        public EditPlatformWindow()
        {
            InitializeComponent();
            _game = new GameCRUD();
            PopulateListView();
        }

        public void PopulateListView()
        {
            _platforms = _game.GetPlatforms();
            lvPlatforms.ItemsSource = _platforms;

        }

        private void PopulatePlatformSelectionWithListView(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListViewItem).DataContext;
            if (item != null)
            {
                _game.SelectedPlat = (Platform)item;
                txtSelectOne.Text = (_game.SelectedPlat.PlatformId).ToString();
                txtSelectTwo.Text = _game.SelectedPlat.PlatformName;
                txtSelectThree.Text = _game.SelectedPlat.Brand;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if ((txtAddOne.Text != null) & (txtAddTwo.Text != null))
            {
                _game.CreatePlatform(txtAddOne.Text, txtAddTwo.Text);
                txtAddOne.Clear();
                txtAddTwo.Clear();
                lvPlatforms.ItemsSource = null;
                PopulateListView();
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this platform?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                _game.DeletePlatform();
                txtSelectOne.Clear();
                txtSelectTwo.Clear();
                PopulateListView();
            }

        }
    }
}
