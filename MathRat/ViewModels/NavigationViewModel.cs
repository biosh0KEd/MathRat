using System.Windows.Input;
using MathRat.Resources.Utilities;
using MathRat.Views;

namespace MathRat.ViewModels;

public class NavigationViewModel : ViewModelBase
{
    private object _currentView;

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
        CurrentView = new Home();
    }

    public object CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public ICommand HomeCommand { get; set; }
    public ICommand CustomerCommand { get; set; }
    public ICommand ProductsCommand { get; set; }
    public ICommand OrdersCommand { get; set; }
    public ICommand TransactionsCommand { get; set; }
    public ICommand ShipmentsCommand { get; set; }
    public ICommand SettingsCommand { get; set; }

    public void Home(object obj)
    {
        CurrentView = new Home();
    }

    public void Customer(object obj)
    {
        CurrentView = new Customers();
    }

    public void Products(object obj)
    {
        CurrentView = new Products();
    }

    public void Orders(object obj)
    {
        CurrentView = new Orders();
    }

    public void Transactions(object obj)
    {
        CurrentView = new Transactions();
    }

    public void Shipments(object obj)
    {
        CurrentView = new Shipments();
    }

    public void Settings(object obj)
    {
        CurrentView = new Settings();
    }
}