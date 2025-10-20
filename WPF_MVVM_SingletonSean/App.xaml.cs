using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_SingletonSean.Exceptions;
using WPF_MVVM_SingletonSean.Models;

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

            try
            {
                hotel.AddReservation(new Reservation(
                   new RoomID(1, 3),

                   new DateTime(2025, 1, 1),
                   new DateTime(2025, 1, 5),
                  "SingltonSean"
                   ));
                hotel.AddReservation(new Reservation(
                    new RoomID(1, 3),

                    new DateTime(2025, 1, 1),
                    new DateTime(2025, 1, 2),
                   "SingltonSean"
                    ));
            }
            catch (ReservationConflictException ex)
            {

                throw;
            }
       
            IEnumerable<Reservation> reservations =
                hotel.GetReservationsForUser("SingltonSean");
            base.OnStartup(e);
            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }

}
