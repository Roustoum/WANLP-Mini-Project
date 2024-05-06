using Avalonia.Input;

namespace WANLP_Mini_Project.Views;

public partial class MainWindow : Window
{
    private MainView MainView { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        GeneralClasse.MainViewModel.w = this;
        DataContext = GeneralClasse.MainViewModel;
        GeneralClasse.MainViewModel.windows_stylerCommand.Execute(null);
        GeneralClasse.ParamètreModel.Bare = true;
        GeneralClasse.ParamètreModel.Parametrebare = true;
        MainView = new MainView();
        GridPrincipal.Children.Add(MainView);
        messge_entre();
    }

    private void Menu_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (!((MainViewModel)DataContext!).MenuHorizional)
        {
            ((MainViewModel)DataContext!).MenuVertical = !((MainViewModel)DataContext!).MenuVertical;
            ((MainViewModel)DataContext!).Menuouvert_windows = ((MainViewModel)DataContext!).MenuVertical;
        }
        else
        {
            ((MainViewModel)DataContext!).Menuouvert_windows = true;
        }
    }
    private void Chatbot_taped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        messge_entre();
    }


    private void paramaitre_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (!paramaitre_menu.Selectioner)
        {
            paramaitre_menu.Selectioner = true;
            apropos_menu.Selectioner = false;
            Chatbot_menu.Selectioner = false;
            MainView.parametre_entre();
        }
    }

    private void apropos_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (!apropos_menu.Selectioner)
        {
            apropos_menu.Selectioner = true;
            Chatbot_menu.Selectioner = false;
            paramaitre_menu.Selectioner = false;
            MainView.apropos_entre();
        }
    }

    private void messge_entre()
    {
        if (!Chatbot_menu.Selectioner)
        {
            Chatbot_menu.Selectioner = true;
            paramaitre_menu.Selectioner = false;
            apropos_menu.Selectioner = false;
            MainView.message_entre();
        }
    }

    private void Grid_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        ((MainViewModel)DataContext!).Menuouvert_windows = false;
        ((MainViewModel)DataContext!).MenuVertical = false;
    }

    private void Changerthemeicon(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        GeneralClasse.ParamètreModel.changer_Sombre_Lumier();
    }

    private void Fermer_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }

    private void Maximiser_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
    }

    private void Minimiser_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void Border_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {
        this.BeginMoveDrag(e);
        if (GeneralClasse.MainViewModel.Windows)
        {
            if (WindowState == WindowState.Maximized)
            {
                GridRacine.Margin = new Thickness(5);
            }
            else
            {
                GridRacine.Margin = new Thickness(0);
            }
        }
    }
    protected override void OnPointerEntered(PointerEventArgs e)
    {
        if (GeneralClasse.MainViewModel.Windows)
        {
            if (WindowState == WindowState.Maximized)
            {
                GridRacine.Margin = new Thickness(5);
            }
            else
            {
                GridRacine.Margin = new Thickness(0);
            }
        }
        base.OnPointerEntered(e);
    }

    protected override void OnResized(WindowResizedEventArgs e)
    {
        if (GeneralClasse.MainViewModel.Windows)
        {
            if (WindowState == WindowState.Maximized)
            {
                GridRacine.Margin = new Thickness(5);
            }
            else
            {
                GridRacine.Margin = new Thickness(0);
            }
        }
        base.OnResized(e);
    }
    protected override void OnSizeChanged(SizeChangedEventArgs e)
    {
        if (GeneralClasse.MainViewModel.Windows)
        {
            if (WindowState == WindowState.Maximized)
            {
                GridRacine.Margin = new Thickness(5);
            }
            else
            {
                GridRacine.Margin = new Thickness(0);
            }
        }
        base.OnSizeChanged(e);
    }
}
