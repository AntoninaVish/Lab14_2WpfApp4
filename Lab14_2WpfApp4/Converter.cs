using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Lab14_2WpfApp4
{
    class Converter : IValueConverter// класс, который преобразует значение перечислений в русское название
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ProductCategorys)value == ProductCategorys.Food)// Food превращается в ЕДА
            {
                return "Еда";
            }
            return "Бытовая техника";// а все остальное в бытовую технику
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }// чтобы вывод был не по английски а на русском языке
}
