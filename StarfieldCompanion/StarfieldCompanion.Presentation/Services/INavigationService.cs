using System;

namespace StarfieldCompanion.Presentation.Services;
internal interface INavigationService
{
    bool CanGoBack { get; }
    void GoBack();
    void GoToStartingPage();
    void Navigate<T>(object args);
    void Navigate<T>(T pageType, object args)
        where T : Type;
}
