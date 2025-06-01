using System.Windows;

namespace WPFStartTutorial.View
{
    public partial class ModelWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModelWindow(Window parentWindow)
        {
            //First add WindowStartupLocation="CenterOwner" to the XAML file this will center the Model window in the parent window

            Owner = parentWindow;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtInput.Text))
            {
                btnOk.IsEnabled = false;
            }
            else
            {
                btnOk.IsEnabled = true;
            }
        }
    }
}
