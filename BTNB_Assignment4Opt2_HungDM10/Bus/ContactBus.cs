using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dao;
using System.Windows.Forms;

namespace Bus
{
    public class ContactBus
    {
        ContactDao objCD = new ContactDao();

        public bool Update(int id, string name, string group, string address, string phone)
        {
            Contact objCont = new Contact()
            {
                Id = id,
                FullName = name,
                Group = group,
                Address = address,
                Phone = phone
            };
            bool checkPhone = InternalBus.PhoneValid(phone);

            if (checkPhone)
            {
                if (objCD.Update(objCont) == 1)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }


        public bool Delete(int id)
        {
            if (objCD.Delete(id) == 1)
                return true;
            return false;
        }

        public DataTable GetAllContact()
        {
           return objCD.GetAllTable();
        }

        public void SearchContact(int id, DataGridView dgv)
        {
            dgv.DataSource = objCD.GetTable(id);
        }
    }
}
