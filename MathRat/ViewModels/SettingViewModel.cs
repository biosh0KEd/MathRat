using System.Windows.Controls;
using MathRat.Models;
namespace MathRat.ViewModels;

public class SettingViewModel : Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;

    public bool Settings
    {
        get { return _pageModel.LocationStatus; }
        set { _pageModel.LocationStatus = value; OnPropertyChanged(); }
    }
    
    public SettingViewModel()
    {
        _pageModel = new PageModel();
        Settings = true;
    }
}