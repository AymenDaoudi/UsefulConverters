using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace UsefulConverters.MutipleToOneDictionaryParameterConverter
{
    /// <summary>
    /// This is used to Convert a group of objects/parameters into one parameter in a Dictionary. Uses converter AddTagToBidingConverter
    /// </summary>
    /// <example>
    ///  <Button Content="Add Client">
    ///      <i:Interaction.Triggers>
    ///          <i:EventTrigger EventName="Click">
    ///              <command:EventToCommand Command="{Binding AddClient}" PassEventArgsToCommand="True">
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
    public class MultipleToOneParameterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = new Dictionary<string, string>();
            var val = values.Cast<Tuple<string, string>>().ToList<Tuple<string, string>>();
            for (var i = 0; i < val.Count(); i++)
            {
                returnValue.Add(val[i].Item1, val[i].Item2);
            }
            return returnValue;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
