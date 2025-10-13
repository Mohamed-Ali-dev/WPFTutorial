using System.Collections.ObjectModel;
using System.Windows.Documents;
using WPFStartTutorial.Model;
using WPFStartTutorial.MVVM;

namespace WPFStartTutorial.ViewModel
{

//    5. MainWindowViewModel.cs (not shown, but inferred)
        //•	Purpose: The main ViewModel for the window; holds the data and logic for the UI.
        //•	Flow:
        //•	Inherits from ViewModelBase.
        //•	Exposes an Items collection (for the DataGrid).
        //•	Exposes a SelectedItem property(for editing in the StackPanel).
        //•	Notifies the UI of changes using OnPropertyChanged.

    //inhites INotifyPropertyChanged to notify the view of property changes
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        // ICommand 
        // We bind the buttons to relay commands that execute methods in the ViewModel
        // we need to create RelayCommand which is a class that implements the ICommand interface
        // We cretaed the relay command in the MVVM folder
        // Command to add a new item (currently does nothing)
        public RelayComman AddCommand => new RelayComman(execute => AddItem());
        public RelayComman DeleteCommand => new RelayComman(execute => DeleteItem(), canExecute => selectedItem != null);
        public RelayComman SaveCommand => new RelayComman(execute => Save(), canExecute => CanSave());
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }
  
        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                selectedItem = value;
                //  Notify the view that the SelectedItem property has changed
                OnPropertyChanged();
            }
        }
        
     private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "xxxxx",
                Quantity = 0
            });
        }
        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }
        private void Save()
        {

        }
        private bool CanSave()
        {
            return true;
        }
    }

}
