namespace Maui.WhiteLabelAppTheme.Services;

public interface IVisualService
{
    /// <summary>
    /// Change color theme
    /// </summary>
    /// <param name="theme">White label theme</param>
    void SetTheme(Theme theme);
    
    /// <summary>
    /// Change app theme (Dark, Light)
    /// </summary>
    /// <param name="appTheme">Set to Dark or Light</param>
    void SetAppTheme(AppTheme appTheme);
}

public enum Theme
{
    NTheme,
    BTheme
}