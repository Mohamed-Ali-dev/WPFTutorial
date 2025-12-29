using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_SingletonSean.Exceptions;
using WPF_MVVM_SingletonSean.Models;
using WPF_MVVM_SingletonSean.ViewModel;

namespace WPF_MVVM_SingletonSean
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        public App()
        {
            _hotel = new Hotel("The Singleton");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_hotel)
            };

            MainWindow.Show();
            base.OnStartup(e);
    
        }
    }

}
