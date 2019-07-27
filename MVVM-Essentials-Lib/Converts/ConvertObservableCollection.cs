using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MVVM_Essentials_Lib.Converts
{
    public static class ConvertObservableCollection
    {
        public static ObservableCollection<TSource> ToObservableCollection<TSource>(this IEnumerable<TSource> val)
        {
            if (val != null)
            {
                var data = new ObservableCollection<TSource>(val);
                return data;
            }
            return new ObservableCollection<TSource>();
        }


        public static ObservableCollection<TSource> ToObservableCollection<TSource>(this List<TSource> val)
        {
            if (val != null)
            {
                var data = new ObservableCollection<TSource>(val);
                return data;
            }
            return new ObservableCollection<TSource>();
        }

    }
}
