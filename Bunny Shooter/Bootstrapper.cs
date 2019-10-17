using Bunny_Shooter.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace Bunny_Shooter
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
