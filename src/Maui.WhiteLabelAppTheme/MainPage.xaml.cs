using Maui.WhiteLabelAppTheme.Resources.Themes;
using Maui.WhiteLabelAppTheme.Services;

namespace Maui.WhiteLabelAppTheme;

public partial class MainPage : ContentPage
{
    private readonly IVisualService _visualService;

    public MainPage(IVisualService visualService)
    {
        InitializeComponent();
        _visualService = visualService;
    }

    private void LightModeButton_OnClicked(object? sender, EventArgs e)
    {
        this._visualService.SetAppTheme(AppTheme.Light);
    }

    private void DarkModeButton_OnClicked(object? sender, EventArgs e)
    {
        this._visualService.SetAppTheme(AppTheme.Dark);
    }

    private void BThemeButton_OnClicked(object? sender, EventArgs e)
    {
        this._visualService.SetTheme(Theme.BTheme);
    }

    private void NThemeButton_OnClicked(object? sender, EventArgs e)
    {
        this._visualService.SetTheme(Theme.NTheme);
    }
}