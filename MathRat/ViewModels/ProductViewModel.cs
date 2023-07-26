using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class ProductViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public ProductViewModel()
    {
        _pageModel = new PageModel();
        ProductAvailability = "Out of Stock";
    }

    public string ProductAvailability
    {
        get => _pageModel.ProductStatus;
        set
        {
            _pageModel.ProductStatus = value;
            OnPropertyChanged();
        }
    }
}