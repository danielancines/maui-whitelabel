using System.Runtime.CompilerServices;
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
        
        visualService.SetAppTheme(AppTheme.Dark);

        Assert.Equal(AppTheme.Dark, Application.Current.UserAppTheme);
    }
}