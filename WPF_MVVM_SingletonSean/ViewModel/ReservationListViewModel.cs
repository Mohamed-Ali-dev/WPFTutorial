using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_SingletonSean.Models;

namespace WPF_MVVM_SingletonSean.ViewModel
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations ;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2),  DateTime.Now, DateTime.Now, "Costa")));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2),  DateTime.Now, DateTime.Now, "ali")));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 4),  DateTime.Now, DateTime.Now, "harem")));
        }
    }
}
