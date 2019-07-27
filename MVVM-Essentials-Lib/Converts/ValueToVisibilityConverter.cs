using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MVVM_Essentials_Lib.Converts
{
    public class ValueToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter != null && parameter.ToString() == "Reverse")
            {
                if (value != null)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
            else
            {
                if (value != null)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

    }
}
