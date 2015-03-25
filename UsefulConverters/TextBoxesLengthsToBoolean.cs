using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UsefulConverters
{
    /// <summary>
    /// This is used to set the IsEnabled property of a Button to true if the TextBoxes contain value, false otherwise.
    /// </summary>
    /// <example>
    /// <Button Content="Ajouter Client">
    ///    <Button.IsEnabled>
    ///        <MultiBinding Converter="{StaticResource TextBoxesLengthsToBoolean}">
    ///            <Binding ElementName="tb_FirstName" Path="Text"/>
    ///            <Binding ElementName="tb_LastName" Path="Text"/>
    ///            <Binding ElementName="tb_PhoneNumber" Path="Text"/>
    ///            <Binding ElementName="tb_Address"  Path="Text"/>
    ///        </MultiBinding>
    ///    </Button.IsEnabled>
    /// </Button>
    /// </example>
   public class TextBoxesLengthsToBoolean : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Cast<String>().ToList().TrueForAll((text) => text.Length != 0);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
