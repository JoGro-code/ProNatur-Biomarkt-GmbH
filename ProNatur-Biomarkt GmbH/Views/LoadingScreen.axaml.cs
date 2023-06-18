using System;
using System.Threading.Channels;
using System.Timers;
using Avalonia.Controls;
using System.Threading;
using System.Threading.Tasks;

namespace ProNatur_Biomarkt_GmbH.Views;

public partial class LoadingScreen : Window
{
    public LoadingScreen()
    {
        InitializeComponent();
    }

    private async void TopLevel_OnOpened(object? sender, EventArgs e)
    {
        for (int i = 1; i <= ProgressBar.Maximum; i++)
        {
            ProgressBar.Value = i;
            LoadProc.Content = i + " %";
            //Console.WriteLine("Timer Tick - " + i);
            await Task.Delay(TimeSpan.FromSeconds(0.01));
        }
        // finish Loading Screen show main menu screen
        MainMenuScreen mainMenuScreen = new MainMenuScreen();
        mainMenuScreen.Show();
        this.Hide();
    }
}