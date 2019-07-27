using System;
using Windows.UI.Xaml.Data;

namespace MVVM_Essentials_Lib.Converts
{
    public class BoolToReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Boolean && (bool)value)
            {
                return false;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return false;
        }
    }
}
