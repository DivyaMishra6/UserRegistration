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
        public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";

        //CHECK FIRST NAME
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, FirstName);
        }

        //CHECK LAST NAME
        public bool ValidateLName(string LName)
        {
            return Regex.IsMatch(LName, FirstName);
        }
    }
}
