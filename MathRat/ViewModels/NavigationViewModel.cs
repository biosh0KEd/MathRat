using System.Windows.Input;
using MathRat.Resources.Utilities;

namespace MathRat.ViewModels;

public class NavigationViewModel : ViewModelBase
{
    private object _currentView;

    public object CurrentView
    {
        get { return _currentView; }
        set { _currentView = value; OnPropertyChanged(); }
    }
    
    public ICommand HomeCommand { get; set; }
    public ICommand CustomerCommand { get; set; }
    public ICommand ProductsCommand { get; set; }
    public ICommand OrdersCommand { get; set; }    
    public ICommand TransactionsCommand { get; set; }
    public ICommand ShipmentsCommand { get; set; }
    public ICommand SettingsCommand { get; set; }
    
    public void Home(object obj) => CurrentView = new HomeViewModel();
    public void Customer(object obj) => CurrentView = new CustomerViewModel();
    public void Products(object obj) => CurrentView = new ProductViewModel();
    public void Orders(object obj) => CurrentView = new OrderViewModel();
    public void Transactions(object obj) => CurrentView = new TransactionViewModel();
    public void Shipments(object obj) => CurrentView = new ShipmentViewModel();
    public void Settings(object obj) => CurrentView = new SettingViewModel();

    public NavigationViewModel()
    {
        HomeCommand = new RelayCommand(Home);
        CustomerCommand = new RelayCommand(Customer);
        ProductsCommand = new RelayCommand(Products);
        OrdersCommand = new RelayCommand(Orders);
        TransactionsCommand = new RelayCommand(Transactions);
        ShipmentsCommand = new RelayCommand(Shipments);
        SettingsCommand = new RelayCommand(Settings);
        
        // Startup Page
        CurrentView = new HomeViewModel();
    }
}