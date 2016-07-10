using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Caliburn.Micro;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MusicPlayer.Services.AudioService;
using MusicPlayer.Services.Test;
using MusicPlayer.Views.MainWindow;
using MusicPlayer.Views.TestWindow;

namespace MusicPlayer
{
    public class Bootstrapper : BootstrapperBase
    {
        // Initializes caliburn micro and services


        // this is a very barebones bootstrapper right now, and it will later include a lot more (fancy) stuff  

        private readonly IWindsorContainer _windsorContainer;


        public Bootstrapper()
        {
            base.Initialize();

            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.This());
        }



        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Creating a new window
            
            // Have to set minimum Height
            var windowManager = new WindowManager();
            var settings = new WindowSettings(150, 700, SizeToContent.Manual);
            
            windowManager.ShowWindow(new MainWindowViewModel(), null, settings.Get());
        }
    }
}
