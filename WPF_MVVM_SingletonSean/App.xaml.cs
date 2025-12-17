using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_SingletonSean.Exceptions;
using WPF_MVVM_SingletonSean.Models;
using WPF_MVVM_SingletonSean.ViewModel;

namespace WPF_MVVM_SingletonSean
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("The Singleton");

        
       
            IEnumerable<Reservation> reservations =
                hotel.GetReservationsForUser("SingltonSean");
            base.OnStartup(e);
            MainWindow = new MainWindow() { 
                DataContext = new MainViewModel()
                };

            MainWindow.Show();
        }
    }

}
