using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MathRat.Models.General;
using MathRat.Resources.Utilities;
using MathRat.Views;

namespace MathRat.ViewModels;

public class NavigationViewModel : ViewModelBase
{
    private List<NavLink> _navLinks;
    public List<NavLink> NavLinks
    {
        get => _navLinks;
        set
        {
            _navLinks = value;
            OnPropertyChanged();
        }
    }
    
    private object _currentView;
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
    public ICommand CloseWindowCommand { get; set; }
    public ICommand MinimizeWindowCommand { get; set; }
    
    public NavigationViewModel()
    {
        HomeCommand = new RelayCommand(Home);
        CustomerCommand = new RelayCommand(Customer);
        ProductsCommand = new RelayCommand(Products);
        OrdersCommand = new RelayCommand(Orders);
        TransactionsCommand = new RelayCommand(Transactions);
        ShipmentsCommand = new RelayCommand(Shipments);
        SettingsCommand = new RelayCommand(Settings);
        CloseWindowCommand = new RelayCommand(CloseWindow);
        MinimizeWindowCommand = new RelayCommand(MinimizeWindow);
        
        // Startup Page
        CurrentView = new Home();
        
        NavLinks = new List<NavLink>
        {
            new ()
            {
                Title = "Home",
                //IsSelected = true,
                //Command = HomeCommand
            },
            new ()
            {
                Title = "Customers",
                //Command = CustomerCommand
            },
            new ()
            {
                Title = "Products",
                //Command = ProductsCommand
            },
            new ()
            {
                Title = "Orders",
                Items =  new ObservableCollection<NavLink>()
                {
                    new ()
                    {
                        Title = "Home",
                        //IsSelected = true,
                        //Command = HomeCommand
                    },
                    new ()
                    {
                        Title = "Customers",
                        //Command = CustomerCommand
                    },
                    new ()
                    {
                        Title = "Products",
                        //Command = ProductsCommand
                    },
                    new ()
                    {
                        Title = "Orders",
                        //CommandBindings = { new CommandBinding(OrdersCommand) }
                        //Command = OrdersCommand
                    },
                    new ()
                    {
                        Title = "Transactions",
                        //Command = TransactionsCommand
                    },
                    new ()
                    {
                        Title = "Shipments",
                        //Command = ShipmentsCommand
                    },
                    new()
                    {
                        Title = "Settings",
                        //Command = SettingsCommand
                    }
                }
                //CommandBindings = { new CommandBinding(OrdersCommand) }
                //Command = OrdersCommand
            },
            new ()
            {
                Title = "Transactions",
                //Command = TransactionsCommand
            },
            new ()
            {
                Title = "Shipments",
                //Command = ShipmentsCommand
            },
            new()
            {
                Title = "Settings",
                //Command = SettingsCommand
            }
        };
    }


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
    
    public void CloseWindow(object obj)
    {
        Application.Current.Shutdown();
    }
    
    public void MinimizeWindow(object obj)
    {
        if (Application.Current.MainWindow != null) Application.Current.MainWindow.WindowState = WindowState.Minimized;
    }
}