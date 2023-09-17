using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StarfieldCompanion.Presentation.Services;

namespace StarfieldCompanion.Presentation.ViewModel;
internal sealed partial class RootNavigationViewModel : ObservableRecipient
{
    private readonly INavigationService _navigationService;

    public RootNavigationViewModel(
        INavigationService navigationService)
    {
        this._navigationService = navigationService;
    }

    [RelayCommand]
    public void NavigateTo()
    {
        this._navigationService.Navigate<HomeViewModel>(null!);
    }
}
