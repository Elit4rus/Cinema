using Cinema.Model;
using System.Windows;

namespace Cinema
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CinemaEntities context = new CinemaEntities();
    }
}
