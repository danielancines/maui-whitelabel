using Maui.WhiteLabelAppTheme.Resources.Themes;

namespace Maui.WhiteLabelAppTheme;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void LightModeButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    private void DarkModeButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.UserAppTheme = AppTheme.Dark;
    }

    private void BThemeButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Add(new BTheme());
    }

    private void NThemeButton_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Add(new NTheme());
    }
}