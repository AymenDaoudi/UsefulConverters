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
    /// <summary>
    /// This is used to Pass the Sender object of a Command (event) through a command parameter all along with the EventArgs by putting them together into a Tuple. 
    /// </summary>
    /// <returns>
    ///     Tuple<Object, EventArgs> : where <b>Object</b> is the Sender, <b>EventArgs</b> are the arguments of the Event represented by the corresponding Command
    /// </returns>
    /// <example>
    /// <DataGrid ItemsSource="{Binding Reportslists, Mode=TwoWay, NotifyOnSourceUpdated=True, UpdateSourceTrigger=Explicit}">   
    ///     <i:Interaction.Triggers>
    ///         <i:EventTrigger EventName="RowEditEnding">
    ///             <command:EventToCommand Command="{Binding DataGridRowEditEnding}" 
    ///                                     PassEventArgsToCommand="True" 
    ///                                     EventArgsConverter="{StaticResource PassSenderWithEventArgsToCommandConverter}" 
    ///                                     EventArgsConverterParameter="{Binding ElementName=DG_Reports}"/>
    ///         </i:EventTrigger>
    ///     </i:Interaction.Triggers>
    ///     <DataGrid.Columns>
    ///         <DataGridTextColumn Header="Lien Serveur" Binding="{Binding SERVERPATH}"/>
    ///         <DataGridTextColumn Header="Lien Rapport" Binding="{Binding REPORTPATH}"/>
    ///         <DataGridTextColumn Header="Durée d'affichage" Binding="{Binding REPORTDURATION}"/>
    ///         <DataGridTextColumn Header="Zoom par default"  Binding="{Binding DEFAULTZOOM}"/>
    ///     </DataGrid.Columns>
    /// </DataGrid>
    /// </example>
    public class PassSenderWithEventArgsToCommandConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            return new Tuple<Object, EventArgs>(parameter, (EventArgs)value);
        }
    }
}
