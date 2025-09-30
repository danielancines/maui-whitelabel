using Maui.WhiteLabelAppTheme.Resources.Themes;

namespace Maui.WhiteLabelAppTheme.Services;

public sealed class VisualService : IVisualService
{
    #region Fields

    private readonly BTheme _bTheme = new();
    private readonly NTheme _nTheme = new();

    #endregion

    #region Public Methods

    public void SetTheme(Theme theme)
    {
        if (Application.Current == null)
            return;

        switch (theme)
        {
            case Theme.BTheme:
                Application.Current.Resources.MergedDictionaries.Add(this._bTheme);
                Application.Current.Resources.MergedDictionaries.Remove(this._nTheme);
                break;
            case Theme.NTheme:
                Application.Current.Resources.MergedDictionaries.Add(this._nTheme);
                Application.Current.Resources.MergedDictionaries.Remove(this._bTheme);
                break;
        }
    }

    public void SetAppTheme(AppTheme appTheme)
    {
        if (Application.Current != null)
            Application.Current.UserAppTheme = appTheme;
    }

    #endregion
}