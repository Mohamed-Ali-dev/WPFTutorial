using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_SingletonSean.Models
{
    //Each Hotel will have its own ReservationBook
    //=> its own set of reservations => for a specific Room => has room id
    public class Hotel
    {
        public readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        /// <summary>
        ///     Get all reservations for a given user
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <returns>The reservations for the user</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {

            return _reservationBook.GetAllReservations();
        }
        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation"> The incoming reservation.</param>
        /// <exception cref="Exceptions.ReservationConflictException">"
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
