using Cinema.Model;
using System.Linq;
using System.Windows;

namespace Cinema.AppData
{
    public class AuthHelper
    {
        public static Worker currentWorker;
        public static bool CheckData(string idNumber, string password)
        {
            currentWorker = App.context.Worker.FirstOrDefault(d => d.IdNumber == idNumber && d.Password == password);
            if (currentWorker != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                return false;
            }
        }
    }
}
