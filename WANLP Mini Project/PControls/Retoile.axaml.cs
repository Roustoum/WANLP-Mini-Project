namespace WANLP_Mini_Project;

public partial class Retoile : UserControl
{
    public Retoile()
    {
        InitializeComponent();
        DataContext = new RetoileModel();
    }
    public int a { get; set; } = 0;

    private void Grid1_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = true;
        ((RetoileModel)DataContext!).Demietoile1 = true;
    }

    private void Grid1_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = false;
        ((RetoileModel)DataContext!).Demietoile1 = false;
    }

    private void Grid2_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = true;
        ((RetoileModel)DataContext!).Demietoile1 = true;
        ((RetoileModel)DataContext!).Demietoile2 = true;

    }

    private void Grid2_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = false;
        ((RetoileModel)DataContext!).Demietoile1 = false;
        ((RetoileModel)DataContext!).Demietoile2 = false;
    }

    private void Grid3_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = true;
        ((RetoileModel)DataContext!).Demietoile1 = true;
        ((RetoileModel)DataContext!).Demietoile2 = true;
        ((RetoileModel)DataContext!).Demietoile3 = true;
    }

    private void Grid3_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = false;
        ((RetoileModel)DataContext!).Demietoile1 = false;
        ((RetoileModel)DataContext!).Demietoile2 = false;
        ((RetoileModel)DataContext!).Demietoile3 = false;
    }

    private void Grid4_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = true;
        ((RetoileModel)DataContext!).Demietoile1 = true;
        ((RetoileModel)DataContext!).Demietoile2 = true;
        ((RetoileModel)DataContext!).Demietoile3 = true;
        ((RetoileModel)DataContext!).Demietoile4 = true;
    }

    private void Grid4_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        ((RetoileModel)DataContext!).Demietoile0 = false;
        ((RetoileModel)DataContext!).Demietoile1 = false;
        ((RetoileModel)DataContext!).Demietoile2 = false;
        ((RetoileModel)DataContext!).Demietoile3 = false;
        ((RetoileModel)DataContext!).Demietoile4 = false;
    }

    private void Grid_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        a = 1;
        ((RetoileModel)DataContext!).Etoile0 = true;
        ((RetoileModel)DataContext!).Etoile1 = false;
        ((RetoileModel)DataContext!).Etoile2 = false;
        ((RetoileModel)DataContext!).Etoile3 = false;
        ((RetoileModel)DataContext!).Etoile4 = false;
    }

    private void Grid_Tapped_1(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        a = 2;
        ((RetoileModel)DataContext!).Etoile0 = true;
        ((RetoileModel)DataContext!).Etoile1 = true;
        ((RetoileModel)DataContext!).Etoile2 = false;
        ((RetoileModel)DataContext!).Etoile3 = false;
        ((RetoileModel)DataContext!).Etoile4 = false;
    }

    private void Grid_Tapped_2(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        a = 3;
        ((RetoileModel)DataContext!).Etoile0 = true;
        ((RetoileModel)DataContext!).Etoile1 = true;
        ((RetoileModel)DataContext!).Etoile2 = true;
        ((RetoileModel)DataContext!).Etoile3 = false;
        ((RetoileModel)DataContext!).Etoile4 = false;
    }

    private void Grid_Tapped_3(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        a = 4;
        ((RetoileModel)DataContext!).Etoile0 = true;
        ((RetoileModel)DataContext!).Etoile1 = true;
        ((RetoileModel)DataContext!).Etoile2 = true;
        ((RetoileModel)DataContext!).Etoile3 = true;
        ((RetoileModel)DataContext!).Etoile4 = false;
    }

    private void Grid_Tapped_4(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        a = 5;
        ((RetoileModel)DataContext!).Etoile0 = true;
        ((RetoileModel)DataContext!).Etoile1 = true;
        ((RetoileModel)DataContext!).Etoile2 = true;
        ((RetoileModel)DataContext!).Etoile3 = true;
        ((RetoileModel)DataContext!).Etoile4 = true;
    }
}

public partial class RetoileModel : ObservableObject
{
    [ObservableProperty]
    private bool _etoile0 = false;
    [ObservableProperty]
    private bool _etoile1 = false;
    [ObservableProperty]
    private bool _etoile2 = false;
    [ObservableProperty]
    private bool _etoile3 = false;
    [ObservableProperty]
    private bool _etoile4 = false;

    [ObservableProperty]
    private bool _demietoile0 = false;
    [ObservableProperty]
    private bool _demietoile1 = false;
    [ObservableProperty]
    private bool _demietoile2 = false;
    [ObservableProperty]
    private bool _demietoile3 = false;
    [ObservableProperty]
    private bool _demietoile4 = false;

}