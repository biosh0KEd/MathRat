using System;
using MathRat.Models;

namespace MathRat.ViewModels;

public class ShipmentViewModel : Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;

    public TimeOnly ShipmentTracking
    {
        get { return _pageModel.ShipmentDelivery; }
        set { _pageModel.ShipmentDelivery = value; OnPropertyChanged(); }
    }
    
    public ShipmentViewModel()
    {
        _pageModel = new PageModel();
        ShipmentTracking = TimeOnly.FromDateTime(DateTime.Now);
    }
}