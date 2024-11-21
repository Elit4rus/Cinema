using Cinema.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Cinema.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RepPage.xaml
    /// </summary>
    public partial class RepPage : Page
    {
        List<Address> district = App.context.Address.ToList();
        List<Cinemas> cinemas = App.context.Cinemas.ToList();
        List<Repertoire> repertoires = App.context.Repertoire.ToList();
        public RepPage()
        {
            InitializeComponent();
            DistrictCmb.ItemsSource = district;
            DistrictCmb.DisplayMemberPath = "District";
            DistrictCmb.SelectedValuePath = "ID";
        }

        private void DistrictCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DistrictCmb.SelectedItem is Address selectedDistrict)
            {
                CinemaLv.ItemsSource = cinemas.Where(c => c.AddressID == selectedDistrict.ID).ToList();
            }
        }

        private void CinemaLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CinemaLv.SelectedItem is Cinemas selectedCinema)
            {
                MovieLv.ItemsSource = repertoires.Where(r => r.CinemaID == selectedCinema.ID).ToList();
            }
        }


    }
}
