using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Caliburn.Micro;
using MusicPlayer.Views.MainWindow;

namespace MusicPlayer
{
    public class Bootstrapper : BootstrapperBase
    {
        // Initializes caliburn micro and services


        // this is a very barebones bootstrapper right now, and it will later include a lot more (fancy) stuff  

        public Bootstrapper()
        {
            base.Initialize();
        }



        protected override void OnStartup(object sender, StartupEventArgs e)
        {

            // Creating a new window
            var windowManager = new WindowManager();
            var settings = new WindowSettings(500, 300, SizeToContent.Manual);

            windowManager.ShowWindow(new MainWindowViewModel(), null, settings.Get());
        }
    }
}
