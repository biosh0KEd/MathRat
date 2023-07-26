using System;
using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class OrderViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public OrderViewModel()
    {
        _pageModel = new PageModel();
        DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
    }

    public DateOnly DisplayOrderDate
    {
        get => _pageModel.OrderDate;
        set
        {
            _pageModel.OrderDate = value;
            OnPropertyChanged();
        }
    }
}