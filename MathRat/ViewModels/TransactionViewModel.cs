using MathRat.Models;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class TransactionViewModel : ViewModelBase
{
    private readonly PageModel _pageModel;

    public TransactionViewModel()
    {
        _pageModel = new PageModel();
        TransactionAmount = 5638;
    }

    public decimal TransactionAmount
    {
        get => _pageModel.TransactionValue;
        set
        {
            _pageModel.TransactionValue = value;
            OnPropertyChanged();
        }
    }
}