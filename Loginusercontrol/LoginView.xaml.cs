using System;
using System.Windows;
using System.Windows.Controls;

namespace Loginusercontrol
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string envpw = Environment.GetEnvironmentVariable("Loginusercontrol") ?? "default_value";

            if (envpw != null)
            {
                if (passwordEntered == envpw)
                {
                    MessageBox.Show("Entered Correct Password");
                }
                else
                {
                    MessageBox.Show("Entered Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
