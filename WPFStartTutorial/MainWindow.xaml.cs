
using System.Reflection.Metadata;
using System.Windows;
using WPFStartTutorial.ViewModel;
//using winForms = System.Windows.Forms;
namespace WPFStartTutorial
{
//    3. MainWindow.xaml.cs
//•	Purpose: Code-behind for the main window; handles window initialization.
//•	Flow:
//•	Calls InitializeComponent() to load the XAML UI.
//•	Creates an instance of MainWindowViewModel.
//•	Sets the window’s DataContext to the ViewModel, enabling data binding between the UI and the ViewModel.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}
//Overall Flow
//1.	App starts → App.xaml launches MainWindow.
//2.	MainWindow loads UI from XAML and sets up data binding to MainWindowViewModel.
//3.	ViewModel provides data (Items) and tracks the selected item (SelectedItem).
//4.	UI displays the list and allows editing of the selected item.
//5.	ViewModelBase ensures UI updates automatically when data changes.