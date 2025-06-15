
using System.Windows;
using WPFStartTutorial.View;
//using winForms = System.Windows.Forms;
namespace WPFStartTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            //Open a new window and the main window will not be blocked
            normalWindow.Show();
        }

        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            //pass the current window as the owner of the model window
            ModelWindow modelWindow = new ModelWindow(this);
            Opacity = 0.7;
            //Open a new window and the main window and any other windows 
            //will be blocked  
            //the execute for Main window stops untill the Model window is closed
            modelWindow.ShowDialog();
            Opacity = 1.0;
            if (modelWindow.Success)
                txtInput.Text = modelWindow.Input;
        }
    }
}  