using System.Windows;

namespace My_First_WPF_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            BootStrapper bootStrapper = new BootStrapper();
            bootStrapper.Run();

        }
    }
}
