using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class SettingViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public SettingViewModel()
    {
        _pageModel = new PageModel();
        Settings = true;
    }

    public bool Settings
    {
        get => _pageModel.LocationStatus;
        set
        {
            _pageModel.LocationStatus = value;
            OnPropertyChanged();
        }
    }
}