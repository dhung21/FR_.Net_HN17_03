using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class Contact
    {
        int id;
        string fullName;
        string group;
        string address;
        string phone;

        public string FullName { get => fullName; set => fullName = value; }
        public string Group { get => group; set => group = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }
    }
}
