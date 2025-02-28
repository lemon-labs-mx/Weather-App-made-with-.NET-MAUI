using System.Globalization;

namespace WeatherApp;

public class TitleCountryConverter : IMultiValueConverter
{
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is string title && values[1] is string country)
            {
                return $"{title}, {country}";
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
}