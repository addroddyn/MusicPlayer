using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MusicPlayer.Services.AudioService;
using MusicPlayer.Services.Test;

namespace MusicPlayer.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ITestService>().ImplementedBy<TestService>().LifestyleSingleton(),
                Component.For<IAudioService>().ImplementedBy<AudioService>().LifestyleSingleton()
                );

        }
    }
}
