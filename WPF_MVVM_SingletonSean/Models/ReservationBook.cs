using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_SingletonSean.Exceptions;

namespace WPF_MVVM_SingletonSean.Models
{
    // ReservationBook => its own set of reservations => for a specific Room => has room id
    public class ReservationBook
    {
        private readonly List<Reservation> _reservation;
        public ReservationBook()
        {
            _reservation = new List<Reservation>();
        }
        /// <summary>
        /// Get all reservations.
        /// </summary>
        /// <returns>All reservations in the reservation book</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
    
                return _reservation;
        }
        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservation)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(
                        existingReservation, reservation);
                }
            }
            _reservation.Add(reservation);
        }
    }
}
