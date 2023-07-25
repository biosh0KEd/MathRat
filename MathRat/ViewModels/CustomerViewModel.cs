using System.Printing;
using MathRat.Models;

namespace MathRat.ViewModels;

class CustomerViewModel : Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;

    public int CustomerID
    {
        get { return _pageModel.CustomerCount;}
        set
        {
            _pageModel.CustomerCount = value; 
            OnPropertyChanged();
        }
    }

    public CustomerViewModel()
    {
        _pageModel = new PageModel();
        CustomerID = 100528;
    }
}