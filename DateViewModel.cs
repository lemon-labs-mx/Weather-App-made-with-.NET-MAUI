using CommunityToolkit.Mvvm.ComponentModel;

namespace WeatherApp;

public partial class DateViewModel :ObservableObject
{
    [ObservableProperty] private string _CurrentDate;
    
    public DateViewModel()
    {
        CurrentDate = DateTime.Now.ToString("dddd, MMMM d, yyyy");
    }

}