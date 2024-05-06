namespace WANLP_Mini_Project.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _menuHorizional = false;

    [ObservableProperty]
    private bool _menuVertical = false;

    [ObservableProperty]
    private bool _menuouvert_windows = false;

    [ObservableProperty]
    private bool _erreur = false;

    [ObservableProperty]
    private bool _alert = false;

    [ObservableProperty]
    private bool _succee = false;

    [ObservableProperty]
    private bool _information = false;

    [ObservableProperty]
    private bool _windows = false;

    [ObservableProperty]
    private string _message_erreur = "test";

    [ObservableProperty]
    private bool _commantaire = false;

    [ObservableProperty]
    private string _microphone_path = "M12,2A3,3 0 0,1 15,5V11A3,3 0 0,1 12,14A3,3 0 0,1 9,11V5A3,3 0 0,1 12,2M19,11C19,14.53 16.39,17.44 13,17.93V21H11V17.93C7.61,17.44 5,14.53 5,11H7A5,5 0 0,0 12,16A5,5 0 0,0 17,11H19Z";

    [ObservableProperty]
    private bool _captureaudio = false;

    [RelayCommand]
    private void afficher_information()
    {
        Erreur = false;
        Succee = false;
        Alert = false;
        Information = !Information;
    }

    public Window? w { get; set; }
    [RelayCommand]
    private void windows_styler()
    {
        Windows = !Windows;
        if(w != null)
        {
            if (Windows)
            {
                w.ExtendClientAreaChromeHints = Avalonia.Platform.ExtendClientAreaChromeHints.NoChrome;
                w.ExtendClientAreaToDecorationsHint = true;
                w.ExtendClientAreaTitleBarHeightHint = -1;
            }
            else
            {
                w.ExtendClientAreaToDecorationsHint = false;
            }
            
        }
    }

    [RelayCommand]
    private void cacher_commentaire() => Commantaire = false;
    [RelayCommand]
    private void afficher_commentaire() => Commantaire = true;
}
