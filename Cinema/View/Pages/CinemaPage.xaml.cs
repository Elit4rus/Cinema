using System.Windows;
using System.Windows.Controls;

namespace Cinema.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CinemaPage.xaml
    /// </summary>
    public partial class CinemaPage : Page
    {
        public CinemaPage()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text == string.Empty)
            {
                MessageBox.Show("Укажите почту!", "Ошибка");
            }
            else
            {
                MessageBox.Show("Отчет отправлен на почту!", "Информация");
                EmailTb.Text = string.Empty;
            }
        }
    }
}
