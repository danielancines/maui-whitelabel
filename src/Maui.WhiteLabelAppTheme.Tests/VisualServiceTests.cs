using System.Runtime.CompilerServices;
using Maui.WhiteLabelAppTheme.Resources.Themes;
using Maui.WhiteLabelAppTheme.Services;

namespace Maui.WhiteLabelAppTheme.Tests;

public class VisualServiceTests
{
    private readonly ServiceProvider _serviceProvider;

    public VisualServiceTests()
    {
        ServiceCollection serviceCollection = new();
        serviceCollection.AddScoped<IVisualService, VisualService>();
        
        this._serviceProvider = serviceCollection.BuildServiceProvider();
        Application.Current = new Application();
    }
    
    [Fact]
    public void Set_Dark_Theme_Should_Be_Dark()
    {
        var visualService = this._serviceProvider.GetService<IVisualService>();
        
        if (visualService == null)
            Assert.Throws<ArgumentNullException>("VisualService", () => { });
        
        visualService.SetAppTheme(AppTheme.Dark);
        
        if (Application.Current == null)
            Assert.Throws<ArgumentNullException>("Application.Current", () => { });
        
        Assert.Equal(AppTheme.Dark, Application.Current.UserAppTheme);
    }

    [Fact]
    public void Set_Light_Theme_Should_Be_Light()
    {
        var visualService = this._serviceProvider.GetService<IVisualService>();
        
        if (visualService == null)
            Assert.Throws<ArgumentNullException>("VisualService", () => { });
        
        visualService.SetAppTheme(AppTheme.Light);
        
        if (Application.Current == null)
            Assert.Throws<ArgumentNullException>("Application.Current", () => { });
        
        Assert.Equal(AppTheme.Light, Application.Current.UserAppTheme);
    }

    [Fact]
    public void Set_NTheme_Must_Have_Only_Styles_And_NTheme()
    {
        var visualService = this._serviceProvider.GetService<IVisualService>();
        
        if (visualService == null)
            Assert.Throws<ArgumentNullException>("VisualService", () => { });
        
        visualService.SetTheme(Theme.NTheme);
        
        if (Application.Current == null)
            Assert.Throws<ArgumentNullException>("Application.Current", () => { });

        var resources = Application.Current.Resources.MergedDictionaries;
        
        Assert.Null(resources.FirstOrDefault(r => r.GetType().IsAssignableTo(typeof(BTheme))));
        Assert.NotNull(resources.FirstOrDefault(r => r.GetType().IsAssignableTo(typeof(NTheme))));
        Assert.True(resources.Count == 1);
    }
    
    [Fact]
    public void Set_BTheme_Must_Have_Only_Styles_And_BTheme()
    {
        var visualService = this._serviceProvider.GetService<IVisualService>();
        
        if (visualService == null)
            Assert.Throws<ArgumentNullException>("VisualService", () => { });
        
        visualService.SetTheme(Theme.BTheme);
        
        if (Application.Current == null)
            Assert.Throws<ArgumentNullException>("Application.Current", () => { });

        var resources = Application.Current.Resources.MergedDictionaries;
        
        Assert.Null(resources.FirstOrDefault(r => r.GetType().IsAssignableTo(typeof(NTheme))));
        Assert.NotNull(resources.FirstOrDefault(r => r.GetType().IsAssignableTo(typeof(BTheme))));
        Assert.True(resources.Count == 1);
    }
}