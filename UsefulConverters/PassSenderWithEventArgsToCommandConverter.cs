using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UsefulConverters
{
    public class PassSenderWithEventArgsToCommandConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Tuple<Object, EventArgs>(parameter, (EventArgs)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (EventArgs)((Tuple<Object, EventArgs>)value).Item2;
        }
    }
}
