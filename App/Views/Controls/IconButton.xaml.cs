namespace ImHungryNow.Views.Controls;

public partial class IconButton : ContentView
{
    public enum IconFontFamily
    {
        FaBrand,
        FaRegular,
        FaSolid
    }

    public static readonly BindableProperty IconFontProperty =
        BindableProperty.Create(nameof(IconFont), typeof(IconFontFamily), typeof(IconButton), IconFontFamily.FaSolid);

    public IconFontFamily IconFont
    {
        get => (IconFontFamily)GetValue(IconFontProperty);
        set => SetValue(IconFontProperty, value);
    }

    public static readonly BindableProperty IconNameProperty =
        BindableProperty.Create(nameof(IconName), typeof(string), typeof(IconButton), default(string));

    public string IconName
    {
        get => (string)GetValue(IconNameProperty);
        set => SetValue(IconNameProperty, value);
    }

    public IconButton()
    {
        InitializeComponent();
        BindingContext = this;
    }
}