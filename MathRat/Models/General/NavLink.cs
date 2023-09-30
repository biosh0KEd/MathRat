using System.Collections.ObjectModel;

namespace MathRat.Models.General;

public class NavLink
{
    public string Title { get; set; } 
    public ObservableCollection<NavLink> Items { get; set; }
    
    public NavLink()
    {
        Items = new ObservableCollection<NavLink>();
    }
}