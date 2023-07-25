using System;
using MathRat.Models;

namespace MathRat.ViewModels;

public class ProductViewModel: Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;

    public string ProductAvailability
    {
        get { return _pageModel.ProductStatus; }
        set { _pageModel.ProductStatus = value; OnPropertyChanged(); }
    }

    public ProductViewModel()
    {
        _pageModel = new PageModel();
        ProductAvailability = "Out of Stock";
    }
}