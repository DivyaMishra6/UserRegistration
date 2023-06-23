using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Registration
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, FirstName);
        }
    }
}
