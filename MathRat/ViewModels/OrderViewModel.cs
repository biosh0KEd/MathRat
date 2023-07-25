using System;
using MathRat.Models;

namespace MathRat.ViewModels;

public class OrderViewModel: Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;

    public DateOnly DisplayOrderDate
    {
        get { return _pageModel.OrderDate; }
        set { _pageModel.OrderDate = value; OnPropertyChanged(); }
    }

    public OrderViewModel()
    {
        _pageModel = new PageModel();
        DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
    }
}