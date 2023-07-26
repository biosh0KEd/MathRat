using System;
using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class ShipmentViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public ShipmentViewModel()
    {
        _pageModel = new PageModel();
        ShipmentTracking = TimeOnly.FromDateTime(DateTime.Now);
    }

    public TimeOnly ShipmentTracking
    {
        get => _pageModel.ShipmentDelivery;
        set
        {
            _pageModel.ShipmentDelivery = value;
            OnPropertyChanged();
        }
    }
}