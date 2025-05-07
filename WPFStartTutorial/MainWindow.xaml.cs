using System.Collections;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            //object item = lvEntries.SelectedItem;

            var items = lvEntries.SelectedItems;
            var result = System.Windows.MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure?", MessageBoxButton.YesNo);
            //If the items list have one value after removing it the foreach loop
            //will be crashed so we create another loop to iterate on 
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
    }
}  