using System.Globalization;

namespace WeatherApp;

public class FahrenheitToCelciusConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        double farenheit = (double)value;
        double celcius = farenheit * 9 / 5 + 32;
        if (!ReferenceEquals(farenheit, null))
        {
            celcius = (farenheit - 32) * 5 / 9;
        }
        return Math.Round(celcius).ToString();
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}