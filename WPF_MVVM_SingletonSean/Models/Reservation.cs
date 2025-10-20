using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_SingletonSean.Models
{
    //reservations => for a specific Room => has room id
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName  { get;}
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);
        public Reservation(RoomID roomID, DateTime startTime,
            DateTime endTime, string userName)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
            UserName = userName;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartTime < EndTime &&
                reservation.EndTime > StartTime;
        }
    }
}
