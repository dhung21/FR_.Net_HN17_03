using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gui
{
    static internal class InternalGui
    {
        static internal string NoiChuoi(string firstString, string secondString)
        {
            string fullString = firstString +" "+ secondString;
            return fullString;
        }

        static internal string[] TachChuoi(string inputString)
        {
            string[] rs = inputString.Split(' ');
            
            return rs;
        }

        static internal bool PhoneValid(string phone)
        {
            Regex reg = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (reg.IsMatch(phone))
                return true;
            return false;
        }
    }
}
