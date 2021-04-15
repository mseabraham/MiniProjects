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

namespace MidProjWPF
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private UserCRUD _userCRUD;
        public RegisterWindow()
        {
            InitializeComponent();
            _userCRUD = new UserCRUD();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            bool createAdmin = false;

            if (rbAdmin.IsChecked is true) createAdmin = true; 
            
            if (txtPassword.Password == txtRePass.Password)
            {
                if ((txtFName.Text != "") && (txtLName.Text != "") && (txtUsername.Text != "") && (txtPassword.Password != ""))
                {
                    _userCRUD.CreateUser(txtUsername.Text, txtFName.Text, txtLName.Text, txtPassword.Password, createAdmin);

                    MessageBoxResult result = MessageBox.Show("Account Created!",
                                          "Confirmation",
                                          MessageBoxButton.OK);
                    if (result == MessageBoxResult.OK)
                    {
                        //Go to login screen
                        RegisterWindow regWindow = this;
                        regWindow.Close();
                    }
                }
            }
        }
                
    }
}
