using Microsoft.Win32;
using System.Windows;

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
            OpenFileDialog fileDialog = new OpenFileDialog();
            //Select just the .pdf files
            fileDialog.Filter = "pdf Source Files | *.pdf";
            //specify initial directory to open. 
            //if the path is not found it will open the default directory 
            fileDialog.InitialDirectory = "D:\\Projects\\WPF\\WPFStartTutorial";
            //To add a title for the dialog 
            fileDialog.Title = "Please select  pdf file(s)";
            //Allow multi selection
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if(success == true)
            {
                string[] paths = fileDialog.FileNames;
                //The file name with no path
                string[] fileNames = fileDialog.SafeFileNames;
                foreach (var fileName in fileNames)
                {
                    tblInfo.Text = fileName;

                }
            }
            else
            {

            }
        }
    }
}  