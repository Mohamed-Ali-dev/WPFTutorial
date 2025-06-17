using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace WPFStartTutorial.MVVM
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        //4. ViewModelBase.cs
        //•	Purpose: Base class for all ViewModels, implements property change notification.
        //•	Flow:
        //•	Implements INotifyPropertyChanged interface.
        //•	Provides OnPropertyChanged method to notify the UI when a property value changes.
        //•	Enables automatic UI updates when ViewModel properties change (essential for data binding).
        public event PropertyChangedEventHandler? PropertyChanged;
        //Method to raise the PropertyChanged event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Check if there are any subscribers to the event before invoking it
            //this refers to the current instance of the class

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
//How it works:
//1.INotifyPropertyChanged Interface
//•	The ViewModel implements INotifyPropertyChanged, which defines the PropertyChanged event.
//•	WPF data binding listens for this event to know when a property value has changed.
//2.	OnPropertyChanged Method
//•	When a property in your ViewModel changes, you call OnPropertyChanged(nameof(PropertyName)) in the property setter.
//•	This method raises the PropertyChanged event, passing the name of the changed property.
//3.	WPF Data Binding
//•	When the PropertyChanged event is raised, WPF automatically updates any UI elements bound to that proper