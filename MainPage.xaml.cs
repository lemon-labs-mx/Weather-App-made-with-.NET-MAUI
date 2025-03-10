﻿namespace WeatherApp;

public partial class MainPage : ContentPage
{
    private RestService _restService;
    public MainPage()
    {
        InitializeComponent();
        _restService = new RestService();
    }

    async void onGetWeatherButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
        {
            WeatherData? weatherData = await _restService.GetWeatherData(GenerateRequestURL(Constants.OpenWeatherMapEndpoint));
            
            BindingContext = weatherData; 
        }
    }

    string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?q={_cityEntry.Text}";
        requestUri += "&units=imperial";
        requestUri += $"&APPID={Constants.OpenWeatherMapApikey}";
        return requestUri;
    }
}