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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        UserCRUD userCRUD;
        public LoginWindow()
        {
            InitializeComponent();
            userCRUD = new UserCRUD();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((txtUsername.Text != "") && (txtPassword.Password != ""))
            {
                if ((userCRUD.Login(txtUsername.Text, txtPassword.Password)) is null) 
                {
                    MessageBoxResult result = MessageBox.Show("Account information was incorrect.\nTry Again!",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                else //Establish admin or user and log in
                {
                    
                    if(userCRUD.LoggedIn.IsAdmin is true)
                    {
                        MainAdminWindow window = new MainAdminWindow();
                        Application.Current.MainWindow.Close();
                        Application.Current.MainWindow = window;
                    }
                    else
                    {
                        MainWindow window = new MainWindow();
                        Application.Current.MainWindow.Close();
                        Application.Current.MainWindow = window;
                    } 
                    Application.Current.MainWindow.Show();
                }
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow window = new RegisterWindow();
            window.ShowDialog();
        }
    }
}
