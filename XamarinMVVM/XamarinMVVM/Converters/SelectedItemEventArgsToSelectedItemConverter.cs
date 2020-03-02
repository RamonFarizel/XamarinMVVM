using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinMVVM.Converters
{
    public class SelectedItemEventArgsToSelectedItemConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var eventArgs = value as SelectedItemChangedEventArgs;

			if (value is null || eventArgs is null)
				return null;

			return eventArgs.SelectedItem;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
		
	}
}
