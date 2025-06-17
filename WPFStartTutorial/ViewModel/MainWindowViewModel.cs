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
        public MainWindowViewModel()
        {
            
        }
        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                selectedItem = value;
                // Notify the view that the SelectedItem property has changed
                OnPropertyChanged();
            }
        }
        
     
    }

}
