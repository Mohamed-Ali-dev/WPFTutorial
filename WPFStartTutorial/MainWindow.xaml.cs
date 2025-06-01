using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Windows;
//using winForms = System.Windows.Forms;
namespace WPFStartTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimiaze_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized; //minimize the window
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal; //if the window is maximized, set it to normal
            }
            else
            {
                WindowState = WindowState.Maximized; //if the window is not maximized, set it to maximized
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //close the application from the main window,
            //if used in another window, it will close that window only
            //Close();
            System.Windows.Application.Current.Shutdown(); //this will close the application
        }
    }
}  