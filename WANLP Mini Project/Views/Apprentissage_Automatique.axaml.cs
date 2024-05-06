using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WANLP_Mini_Project;

public partial class Apprentissage_Automatique : UserControl
{
    public Apprentissage_Automatique()
    {
        InitializeComponent();
        DataContext = GeneralClasse.AAModel;
    }
}