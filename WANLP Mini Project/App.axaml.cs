using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;

using WANLP_Mini_Project.ViewModels;
using WANLP_Mini_Project.Views;

namespace WANLP_Mini_Project;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        BindingPlugins.DataValidators.RemoveAt(0);
        GeneralClasse.ParamètreModel = new ParamètreModel();
        GeneralClasse.MainViewModel = new MainViewModel();
        GeneralClasse.AAModel = new AAModel();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new chargement();
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = GeneralClasse.MainViewModel
            };
    }

        base.OnFrameworkInitializationCompleted();
    }
}
