namespace WANLP_Mini_Project.Views;

public partial class MainView : UserControl
{
    private apropos apropos;
    private Paramètre paramaitre;
    private massage_view massage_View;
    private Apprentissage_Automatique Apprentissage_Automatique;
    public MainView()
    {
        DataContext = GeneralClasse.MainViewModel;
        InitializeComponent();
        apropos = new apropos { DataContext = this.DataContext };
        massage_View = new massage_view { DataContext = this.DataContext };
        paramaitre = new Paramètre { DataContext = GeneralClasse.ParamètreModel };
        Apprentissage_Automatique = new Apprentissage_Automatique { DataContext = GeneralClasse.AAModel };
        Chatbot_menu.Selectioner = true;
        message_entre();
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
        if (!Chatbot_menu.Selectioner)
        {
            Chatbot_menu.Selectioner = true;
            paramaitre_menu.Selectioner = false;
            apropos_menu.Selectioner = false;
            message_entre();
        }
    }

    private void paramaitre_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (!paramaitre_menu.Selectioner)
        {
            paramaitre_menu.Selectioner = true;
            apropos_menu.Selectioner = false;
            Chatbot_menu.Selectioner = false;
            parametre_entre();
        }
    }

    private void apropos_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (!apropos_menu.Selectioner)
        {
            apropos_menu.Selectioner = true;
            Chatbot_menu.Selectioner = false;
            paramaitre_menu.Selectioner = false;
            apropos_entre();
        }
    }

    public void message_entre()
    {
        if (!Chatbot_menu.Selectioner)
        {
            Chatbot_menu.Selectioner = true;
            paramaitre_menu.Selectioner = false;
            apropos_menu.Selectioner = false;
        }
        GridNavigation.Children.Clear();
        GridNavigation.Children.Add(massage_View);
    }

    public void apprentissage_entre()
    {
        GridNavigation.Children.Clear();
        GridNavigation.Children.Add(Apprentissage_Automatique);
    }

    public void parametre_entre()
    {
        GridNavigation.Children.Clear();
        GridNavigation.Children.Add(paramaitre);
    }

    public void apropos_entre()
    {
        GridNavigation.Children.Clear();
        GridNavigation.Children.Add(apropos);
    }

    protected override void OnSizeChanged(SizeChangedEventArgs e)
    {
        ((MainViewModel)DataContext!).MenuHorizional = (this.Bounds.Width > 150 * 5);
        if (((MainViewModel)DataContext!).MenuHorizional)
        {
            ((MainViewModel)DataContext!).MenuVertical = false;
            ((MainViewModel)DataContext!).Menuouvert_windows = true;
        }
        else
        {
            if (!((MainViewModel)DataContext!).MenuVertical)
                ((MainViewModel)DataContext!).Menuouvert_windows = false;
        }
        /*        Debug.WriteLine("ani fel menu horizontal :" + ((MainViewModel)DataContext!).MenuHorizional);
                Debug.WriteLine("ani fel menu vertical :" + ((MainViewModel)DataContext!).MenuVertical);
                Debug.WriteLine("ani fel menu Menuouvert_windows :" + ((MainViewModel)DataContext!).Menuouvert_windows);*/
        base.OnSizeChanged(e);
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
}
