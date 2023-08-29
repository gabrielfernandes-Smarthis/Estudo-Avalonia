using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TesteAvalonia.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string tituloBold = "Avalonia";

    [ObservableProperty]
    private string tituloNormal = "LOUDNESS METER";
}
