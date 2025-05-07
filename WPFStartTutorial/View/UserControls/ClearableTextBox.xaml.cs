using System.Windows;
using System.Windows.Controls;

namespace WPFStartTutorial.View.UserControls
{

    public partial class ClearableTextBox : System.Windows.Controls.UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }
        private string placeHolder;

        public string PlaceHolder
        {
            get { return placeHolder; }
            set 
            {
                placeHolder = value;
                tbPlaceholder.Text = placeHolder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else 
                tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
