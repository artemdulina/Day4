using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAreaForTaskTwo
{
    public class CustomersFormatter : ICustomFormatter, IFormatProvider
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";

            switch (format.ToUpperInvariant())
            {
                case "OTHERREPRESENTATIONS":
                    return "OtherRepresentationOfThisObject";
                default:
                    try
                    {
                        return HandleOtherFormats(format, arg);
                    }
                    catch (FormatException e)
                    {
                        throw new FormatException(String.Format("The format of '{0}' is not supported.", format), e);
                    }
            }
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }

        private string HandleOtherFormats(string format, object arg)
        {
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, CultureInfo.CurrentCulture);
            if (arg != null)
                return arg.ToString();
            return string.Empty;
        }
    }
}
