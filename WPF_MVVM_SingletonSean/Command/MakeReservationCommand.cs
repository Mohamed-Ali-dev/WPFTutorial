using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM_SingletonSean.Exceptions;
using WPF_MVVM_SingletonSean.Models;
using WPF_MVVM_SingletonSean.ViewModel;

namespace WPF_MVVM_SingletonSean.Command
{
    class MakeReservationCommand : CommadBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            this._makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            //this event handler will listen for property changes in the ViewModel
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        //override CanExecute to check if Username is not null or empty and FloorNumber > 0
        //whateber the property changed is Username or FloorNumber we call OnCanExecuteChanged
        // we should caal the event to notify the UI that the command's ability to execute may have changed.
        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username)  && 
                _makeReservationViewModel.FloorNumber > 0 &&
                base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.StartDate,
                 _makeReservationViewModel.EndDate
                , _makeReservationViewModel.Username);
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Successfully reserved room", "Success",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException ex)
            {
                MessageBox.Show("This room is already booked for the selected dates.", "Reservation Conflict",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //whatever the property changed is Username or FloorNumber we call OnCanExecuteChanged
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Username)||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecuteChanged();
            }
        }

    }
}
