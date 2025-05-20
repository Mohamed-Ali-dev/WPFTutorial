using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Windows;
using winForms = System.Windows.Forms;
namespace WPFStartTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }
    }
}  