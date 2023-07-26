using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

internal class CustomerViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public CustomerViewModel()
    {
        _pageModel = new PageModel();
        CustomerID = 100528;
    }

    public int CustomerID
    {
        get => _pageModel.CustomerCount;
        set
        {
            _pageModel.CustomerCount = value;
            OnPropertyChanged();
        }
    }
}