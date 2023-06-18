using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ProNatur_Biomarkt_GmbH.Views;

public partial class MainMenuScreen : Window
{
    public MainMenuScreen()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick_Product(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Button_OnClick_Bill(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}