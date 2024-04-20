using FinancasdeBolso.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasdeBolso.Libraries.Converters
{
    public class TransationValueColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Transacao transacao = (Transacao)value;

            if (transacao == null)
            {
                return Colors.White;
            }

            if (transacao.Type == TransacaoType.Income)
            {
                return Colors.DarkGreen;
            }
            else
            {
                return Colors.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
