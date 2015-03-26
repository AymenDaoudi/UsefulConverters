using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UsefulConverters.MutipleToOneDictionaryParameterConverter
{
    /// <summary>
    /// This is used to pass a Tag (generally the name of the element) as a parameter with the bound value, in the form of a tuple object that contains both the value and the tag.
    /// </summary>
    /// <example>
    ///  <Button Content="Add Client">
    ///      <i:Interaction.Triggers>
    ///          <i:EventTrigger EventName="Click">
    ///              <command:EventToCommand Command="{Binding AddClient}">
    ///                  <command:EventToCommand.CommandParameter>
    ///                      <MultiBinding Converter="{StaticResource MultipleToOneParameterConverter}">
    ///                          <Binding ElementName="tb_FirstName" Path="Text" Converter="{StaticResource AddTagToBidingConverter}" ConverterParameter="FirstName" />
    ///                          <Binding ElementName="tb_LastName" Path="Text" Converter="{StaticResource AddTagToBidingConverter}" ConverterParameter="LastName"/>
    ///                          <Binding ElementName="tb_PhoneNumber" Path="Text" Converter="{StaticResource AddTagToBidingConverter}" ConverterParameter="PhoneNumber"/>
    ///                          <Binding ElementName="tb_Address" Path="Text" Converter="{StaticResource AddTagToBidingConverter}" ConverterParameter="Address"/>
    ///                      </MultiBinding>
    ///                  </command:EventToCommand.CommandParameter>
    ///              </command:EventToCommand>
    ///          </i:EventTrigger>
    ///      </i:Interaction.Triggers>
    ///  </Button
    /// </example>
    public class AddTagToBidingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Tuple<string, string>((string)parameter, (string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
