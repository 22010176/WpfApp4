using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp4.Util.Converter
{
  [ValueConversion(typeof(bool), typeof(SolidColorBrush))]
  class TurnConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      bool val = (bool)value;
      return val ? new SolidColorBrush(Color.FromRgb(0,255,0)) : new SolidColorBrush(Color.FromRgb(255, 0, 0));
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
