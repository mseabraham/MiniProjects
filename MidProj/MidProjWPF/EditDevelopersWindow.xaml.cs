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
    /// Interaction logic for MultiEditWindow.xaml
    /// </summary>
    public partial class EditDevelopersWindow : Window
    {
        private List<Developer> developers;
        private GameCRUD game;
        public EditDevelopersWindow()
        {
            InitializeComponent();
            game = new GameCRUD();
            PopulateListView();

        }

        public void PopulateListView()
        { 
            developers = game.GetDevelopers();
            lvDevelopers.ItemsSource = developers;

        }


        private void PopulateDevSelectionWithListView(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListViewItem).DataContext;
            if (item != null)
            {
                game.SelectedDev = (Developer)item;
                txtSelectOne.Text = (game.SelectedDev.DeveloperId).ToString();
                txtSelectTwo.Text = game.SelectedDev.CompanyName;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(txtAddOne.Text is not null)
            {
                game.CreateDeveloper(txtAddOne.Text);
                txtAddOne.Clear();
                lvDevelopers.ItemsSource = null;
                PopulateListView();
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this developer?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                game.DeleteDeveloper();
                txtSelectOne.Clear();
                txtSelectTwo.Clear();
                PopulateListView();
            }

        }
    }
}