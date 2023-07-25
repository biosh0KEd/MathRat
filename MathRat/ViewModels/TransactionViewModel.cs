using System;
using MathRat.Models;

namespace MathRat.ViewModels;

public class TransactionViewModel: Resources.Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;
    public decimal TransactionAmount
    {
        get { return _pageModel.TransactionValue; }
        set { _pageModel.TransactionValue = value; OnPropertyChanged(); }
    }
    
    public TransactionViewModel()
    {
        _pageModel = new PageModel();
        TransactionAmount = 5638;
    }
}