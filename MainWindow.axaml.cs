using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Data;

namespace CalculatorApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        var button = sender as Button;

        if (button != null)
        {
            DisplayBox.Text += button.Content?.ToString();
        }
    }

    private void Clear_Click(object? sender, RoutedEventArgs e)
    {
        DisplayBox.Text = "";
    }

    private void Equals_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            var result = new DataTable().Compute(DisplayBox.Text, null);
            DisplayBox.Text = result.ToString();
        }
        catch
        {
            DisplayBox.Text = "Error";
        }
    }
}
