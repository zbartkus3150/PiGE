using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace Polska_infa
{
    public class EmailRule : ValidationRule
    {
      

        public EmailRule()
        {
        }


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string email;
            email = ((String)value);
            //try
            //{
            //    if (((string)value).Length > 0)
            //        email = ((String)value);
            //}
            //catch (Exception e)
            //{
            //    return new ValidationResult(false, "Illegal characters or " + e.Message);
            //}

            var regex = new Regex("[A-Za-z0-9]+@[A-Za-z0-9]+.[A-Za-z0-9]");
            if (!regex.IsMatch(email))
            {
                return new ValidationResult(false,
                  "Please enter a valid email");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
