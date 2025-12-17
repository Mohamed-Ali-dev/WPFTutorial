using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_SingletonSean.Models;

namespace WPF_MVVM_SingletonSean.ViewModel
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID  => 
            _reservation.RoomID?.ToString();
        public string UserName => _reservation.UserName;
        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;
        public ReservationViewModel(Reservation reservation)
        {
        this._reservation = reservation;
        }
    }
}
