using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace TableroComando
{
    public static class DataBindingConverter
    {
        static public Binding BuildBindingDecimalString<Type>(string propertyName, object dataSource, string dataMember)
        {
            Binding binding = new Binding(propertyName, (Type)dataSource, dataMember);
            binding.Format += new ConvertEventHandler(DecimalToString);
            binding.Parse += new ConvertEventHandler(StringToDecimal);
            return binding;
        }

        static private void DecimalToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType. 
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            cevent.Value = (cevent.Value != null) ? ((decimal)cevent.Value).ToString() : "";
        }

        static private void StringToDecimal(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only.
            if (cevent.DesiredType != typeof(decimal)) return;

            // Converts the string back to decimal using the static Parse method.
            cevent.Value = Decimal.Parse(cevent.Value.ToString(), NumberStyles.Currency, null);
        }
    }
}
