using Syncfusion.Licensing;
using System.Windows;

namespace StarfieldCompanion.Presentation;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        SyncfusionLicenseProvider.RegisterLicense("Super Secret !");
    }
}
