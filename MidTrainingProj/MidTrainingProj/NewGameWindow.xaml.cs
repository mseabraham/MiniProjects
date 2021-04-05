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
using MidTrainingProj.Models;
using MidTrainingProj.Classes;

namespace MidTrainingProj
{
    /// <summary>
    /// Interaction logic for NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        private CRUD operation = new CRUD();
        public NewGameWindow()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            DateTime? release = datePicker.SelectedDate;
            if ((title != "") && release.HasValue)
            {
                using (var db = new Gam3Sp0tContext())
                {
                    var newGa = new Game()
                    {

                        GameTitle = title,
                        ReleaseDate = release
                    };
                    db.Add(newGa);
                    db.SaveChanges();
                }

                operation.BindGames();
                btnCancel_Click(sender, e);
            }
              
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newWin = this;

            newWin.Close();

        }
    }
}
