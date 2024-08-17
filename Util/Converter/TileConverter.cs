using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp4.Util.Converter
{
  [ValueConversion(typeof(int), typeof(string))]
  class TileConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      int val = (int)value;
      switch (val)
      {
        case 0: return "";
        case 1: return "";
        case 2: return "";
        default: return null;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
