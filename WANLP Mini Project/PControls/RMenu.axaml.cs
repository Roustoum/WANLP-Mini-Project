using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace WANLP_Mini_Project;

public class RMenu : TemplatedControl
{
    public static readonly StyledProperty<bool> SelectionerProperty = AvaloniaProperty.Register<RMenu, bool>(nameof(Selectioner));
    public bool Selectioner
    {
        get => GetValue(SelectionerProperty);
        set => SetValue(SelectionerProperty, value);
    }

    public static readonly StyledProperty<bool> InvisibleProperty = AvaloniaProperty.Register<RMenu, bool>(nameof(Invisible));
    public bool Invisible
    {
        get => GetValue(InvisibleProperty);
        set => SetValue(InvisibleProperty, value);
    }

    public static readonly StyledProperty<bool> ZeroHeightProperty = AvaloniaProperty.Register<RMenu, bool>(nameof(ZeroHeight));
    public bool ZeroHeight
    {
        get => GetValue(ZeroHeightProperty);
        set => SetValue(ZeroHeightProperty, value);
    }

    public static readonly StyledProperty<StreamGeometry> DataProperty = AvaloniaProperty.Register<RMenu, StreamGeometry>(nameof(Data));
    public StreamGeometry Data
    {
        get => GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }

    public static readonly StyledProperty<string> NomProperty = AvaloniaProperty.Register<RMenu, string>(nameof(Nom));
    public string Nom
    {
        get => GetValue(NomProperty);
        set => SetValue(NomProperty, value);
    }
}