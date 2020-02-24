using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Image_panorama.MVVM;

namespace Image_panorama
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _mainWindow;
        protected void OnStartup(object sender, StartupEventArgs startupEventArgs)
        {
            _mainWindow = new MainWindow { ViewModel = new MainWindowViewModel() };
            Current.MainWindow = _mainWindow;
            Current.MainWindow?.Show();
        }
    }
    
}
