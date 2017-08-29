using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bus
{
    static internal class InternalBus
    {
        static internal bool PhoneValid(string phone)
        {
            //Regex reg = new Regex(@"^(?:[\+]?[\(]?([\d]{1,3})[\s\-\.\)]+)?(?:[\(]?([\d]{1,3})[\s\-\/\)]+)([2-9][0-9\s\-\.]{6,}[0-9])(?:[\s\D]+([\d]{1,5}))?$");
            Regex reg = new Regex(@"^(\+1|1)?[ \-\.]?\(?(?<areacode>[0-9]{3})\)?[ \-\.]?(?<prefix>[0-9]{3})[ \-\.]?(?<number>[0-9]{4})[ \.]*(ext|x)?[ \.]*(?<extension>[0-9]{0,5})$");
            if (reg.IsMatch(phone))
                return true;
            return false;
        }
    }
}
