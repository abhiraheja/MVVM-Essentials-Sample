using System;
using Windows.UI.Xaml.Data;

namespace MVVM_Essentials_Lib.Converts
{
    public class IntegerConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            Int32.TryParse((string)value, out int result);
            return result;
        }
    }
}