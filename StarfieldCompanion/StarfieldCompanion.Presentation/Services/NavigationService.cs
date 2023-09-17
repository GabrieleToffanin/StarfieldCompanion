using StarfieldCompanion.Presentation.View;
using StarfieldCompanion.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace StarfieldCompanion.Presentation.Services;
internal sealed class NavigationService : INavigationService
{
    private readonly Frame _navigationFrame;

    private readonly Dictionary<Type, Type> _viewModelToViewNavigationMapping =
        new()
        {
            [typeof(HomeViewModel)] = typeof(HomePage)
        };

    public NavigationService(Frame rootFrame)
    {
        this._navigationFrame = rootFrame;
    }

    /// <inheritdoc />
    public bool CanGoBack => this._navigationFrame.CanGoBack;

    /// <inheritdoc />
    public void GoBack()
    {
        this._navigationFrame.GoBack();
    }

    /// <inheritdoc />
    public void GoToStartingPage()
    {
    }

    /// <inheritdoc />
    public void Navigate<T>(object args)
    {
        this._navigationFrame.Navigate(
            this._viewModelToViewNavigationMapping[typeof(T)],
            args);
    }

    /// <inheritdoc />
    public void Navigate<T>(T pageType, object args)
        where T : Type
    {
        this._navigationFrame.Navigate(
            this._viewModelToViewNavigationMapping[pageType],
            args);
    }
}
