using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    public class Customer
    {
        string email, password, phoneNum, address, username, name;

        public Customer(string u, string pass, string n, string e, string p, string a)
        {
            name = n;
            password = pass;
            username = u;
            email = e;
            phoneNum = p;
            address = a;
        }

        public string getuser()
        {
            return username;
        }
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
        public string getemail()
        {
            return email;
        }
        public string getphone()
        {
            return phoneNum;
        }
        public string getaddress()
        {
            return address;
        }


    }
}
