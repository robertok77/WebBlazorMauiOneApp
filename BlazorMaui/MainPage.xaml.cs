namespace BlazorMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        //DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
        //DeviceDisplay.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
    }

    //private async void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
    //{
    //    await DisplayAlert("Orientation", $"Current Orientation: {e?.DisplayInfo.Orientation}", "Ok");
        
    //}
    
}