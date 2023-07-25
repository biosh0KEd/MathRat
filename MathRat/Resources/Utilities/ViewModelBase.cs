using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MathRat.Resources.Utilities;

public class ViewModelBase
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}