using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using StarfieldCompanion.Presentation.Services;
using StarfieldCompanion.Presentation.ViewModel;
using Syncfusion.Windows.Shared;
using System;

namespace StarfieldCompanion.Presentation.View;

/// <inheritdoc />
public sealed partial class RootNavigation : ChromelessWindow
{
    public RootNavigation()
    {
        this.InitializeComponent();
        this.DataContext = Ioc.Default.GetService<RootNavigationViewModel>();
    }

    /// <inheritdoc />
    protected override void OnInitialized(EventArgs e)
    {
        base.OnInitialized(e);


        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .AddSingleton<INavigationService>(new NavigationService(this.RootFrame.))
                .AddScoped<RootNavigationViewModel>()
                .BuildServiceProvider());
    }
}
