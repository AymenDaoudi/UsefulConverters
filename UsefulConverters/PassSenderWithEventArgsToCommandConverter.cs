using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using GalaSoft.MvvmLight.Command;

namespace UsefulConverters
{
    public class PassSenderWithEventArgsToCommandConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            return new Tuple<Object, EventArgs>(parameter, (EventArgs)value);
        }
    }
}
