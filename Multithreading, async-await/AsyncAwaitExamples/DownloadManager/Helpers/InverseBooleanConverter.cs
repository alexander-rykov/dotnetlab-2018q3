using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace DownloadManager.Helpers
{
  public class InverseBooleanConverter : MarkupExtension, IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
    {
      if (targetType != typeof(bool))
        throw new InvalidOperationException("The target must be a boolean");

      return !(bool)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
    {
      throw new NotSupportedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      return this;
    }
  }
}