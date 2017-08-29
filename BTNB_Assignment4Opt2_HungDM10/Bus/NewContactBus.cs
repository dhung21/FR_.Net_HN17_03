using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dao;

namespace Bus
{
    public static class NewContactBus
    {
        static ContactDao objCD = new ContactDao();
        public static bool Insert(string name, string group, string address, string phone)
        {
            Contact objCont = new Contact()
            {
                FullName = name,
                Group = group,
                Address = address,
                Phone = phone
            };
            bool checkPhone = InternalBus.PhoneValid(phone);

            if (checkPhone)
            {
                if (objCD.Insert(objCont) == 1)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
