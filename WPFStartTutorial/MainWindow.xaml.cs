using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Navigation;

namespace WPFStartTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click( object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Your message here.","ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement.",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblInfo.Text = "Agreed";
            }
            else
            {
                tblInfo.Text = "Not Agreed";
            }
        }
    }
} 