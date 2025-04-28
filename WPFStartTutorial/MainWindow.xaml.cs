using System.ComponentModel;
using System.Windows;
using System.Windows.Navigation;

namespace WPFStartTutorial
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
             {
                //whenever this setter is set invoke the event that this property(BoundText) has changed

                boundText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }
    }
} 