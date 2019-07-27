using System;
using Windows.UI.Xaml.Data;

namespace MVVM_Essentials_Lib.Converts
{
    public class DateTimeToDateTimeOffsetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                value = DateTime.Now;
                DateTime date = System.Convert.ToDateTime(string.IsNullOrEmpty(System.Convert.ToString(value)) ? DateTime.MinValue.ToString() : value);
                return new DateTimeOffset(date);
            }
            catch (Exception ex)
            {
                return DateTimeOffset.MinValue;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            try
            {
                DateTimeOffset dto = (DateTimeOffset)value;
                return dto.DateTime.Date.Date;
            }
            catch (Exception ex)
            {
                return DateTime.MinValue;
            }
        }

    }
}
