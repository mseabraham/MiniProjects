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
using MidTrainingProj.Models;


namespace MidTrainingProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

          List<Game> gameFill = new List<Game>();
        public MainWindow()
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
    }
}
