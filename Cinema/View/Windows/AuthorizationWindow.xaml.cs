using Cinema.AppData;
using System.Windows;
using System.Windows.Media;

namespace Cinema.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            LoginTb.Text = "IdNumber";
            PasswordTb.Text = "Password";
            LoginTb.Foreground = Brushes.Gray;
            PasswordTb.Foreground = Brushes.Gray;
        }

        private void LoginTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "IdNumber")
            {
                LoginTb.Text = "";
                LoginTb.Foreground = Brushes.Black;
            }
        }

        private void LoginTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "")
            {
                LoginTb.Text = "IdNumber";
                LoginTb.Foreground = Brushes.Gray;
            }
        }

        private void PasswordTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "Password")
            {
                PasswordTb.Text = "";
                PasswordTb.Foreground = Brushes.Black;
            }
        }

        private void PasswordTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                PasswordTb.Text = "Password";
                PasswordTb.Foreground = Brushes.Gray;
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthHelper.CheckData(LoginTb.Text, PasswordTb.Text) == true)
            {
                Close();
            }
        }
    }
}
