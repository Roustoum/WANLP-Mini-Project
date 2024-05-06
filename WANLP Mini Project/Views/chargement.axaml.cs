using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WANLP_Mini_Project.Views;

public partial class chargement : Window
{
    public chargement()
    {
        InitializeComponent();
        DataContext = GeneralClasse.MainViewModel;
        chargement_windows();
    }

    private async Task chargement_windows()
    {
        await Task.Delay(3000);

        MainWindow b = new MainWindow{DataContext = GeneralClasse.MainViewModel};
        b.Show();
        var currentWindow = ((IClassicDesktopStyleApplicationLifetime)Application.Current!.ApplicationLifetime!).MainWindow;
        currentWindow!.Close();
        ((IClassicDesktopStyleApplicationLifetime)Application.Current!.ApplicationLifetime!).MainWindow = b;
    }

    private void Border_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {
        this.BeginMoveDrag(e);
    }

    private void Fermer_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}