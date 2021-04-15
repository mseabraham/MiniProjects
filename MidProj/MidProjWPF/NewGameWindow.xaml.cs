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
using MidProjData;
using MidProjClasses;

namespace MidProjWPF
{
    /// <summary>
    /// Interaction logic for NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        private GameCRUD _operation;
        public NewGameWindow()
        {
            InitializeComponent();
            _operation = new GameCRUD();

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
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

                _operation.BindGames();
                BtnCancel_Click(sender, e);
            }

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newWin = this;

            newWin.Close();

        }
    }
}
