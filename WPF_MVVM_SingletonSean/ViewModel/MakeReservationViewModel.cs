using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_SingletonSean.Command;

namespace WPF_MVVM_SingletonSean.ViewModel
{
    public class MakeReservationViewModel : ViewModelBase
    {
		//UserName
		private string _username;

		public string Username
		{
			get { return _username; }
			set { _username = value;
				OnPropertyChanged(nameof(Username));
			}
		}
		//RoomNo
		private int _roomNumber;

		public int RoomNumber
		{
			get { return _roomNumber; }
			set { _roomNumber = value;
				OnPropertyChanged(nameof(RoomNumber));

			}
		}
        //FloorNo
        private int _floorNumber;

        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));

            }
        }
        //StartDate
        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));

            }
        }
        //EndDate
        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));

            }
        }
        //SubmitCommand
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public MakeReservationViewModel()
        {
            SubmitCommand = new MakeReservationCommand();
        }

    }
}
