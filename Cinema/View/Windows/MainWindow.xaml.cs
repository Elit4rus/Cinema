using Cinema.AppData;
using Cinema.View.Windows;
using System.Windows;

namespace Cinema
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.repFrame = RepFrame;
            FrameHelper.cinemaFrame = CinemaFrame;
            RepFrame.Navigate(new View.Pages.RepPage());
            CinemaFrame.Navigate(new View.Pages.CinemaPage());
            FullNameTbl.Text = AuthHelper.currentWorker.Fullname.ToString();
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }
    }
}
