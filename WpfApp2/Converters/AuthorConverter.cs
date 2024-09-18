using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfApp2.ConsoleApp20_08_2024.Enities;

namespace WpfApp2.Converters
{
    public class AuthorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var author = value as Author;
            if (author is null)
            {
                return "Нет автора";
            }
            return $"{author.LastName} {author.FirstName} {author.Patronymic}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
