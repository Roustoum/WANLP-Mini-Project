using Avalonia.Controls.Primitives;

namespace WANLP_Mini_Project;

public class Rparamaitre : TemplatedControl
{
    public static readonly StyledProperty<string> NomProperty = AvaloniaProperty.Register<RMenu, string>(nameof(Nom));
    public string Nom
    {
        get => GetValue(NomProperty);
        set => SetValue(NomProperty, value);
    }
}