using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOAD_Project
{
    class CustomerList
    {
        int count = 0;
        Customer[] customers = new Customer[100];

        /// <summary>
        /// 
        /// </summary>
        public CustomerList()
        {
            string text;
         
            bool done = false;  // True when end of user list has been reached
                        
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\UserList.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    if (!text.Equals("-1") )                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("1") )
                        {
                        String[] parts = text.Split('$');      // Breaks the current line into parts
                           if (parts[2] != "A")
                           {
                              customers[count] = new Customer(parts[0], parts[1], parts[3], parts[4], parts[5], parts[6],
                                  parts[7], parts[8], parts[9], Int32.Parse(parts[10]));
                              count++;
                           }
                        }
                    }
                    else
                    {
                        done = true;                        
                    }
                }
            }
            fileStream.Close();

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phonenumber"></param>
        /// <param name="address"></param>
        /// <param name="creditcard"></param>
        /// <param name="security"></param>
        /// <param name="expire"></param>
        /// <param name="meals"></param>
        public void editInfo(string username, string password, string name,
            string email, string phonenumber, string address, string creditcard,
            string security, string expire, int meals)
        {
            string toBeWrit = "";
            string text;
            bool found = false;
            bool done = false;
            
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\UserList.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); 
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    string[] stuff = text.Split('$');
                    if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (stuff[0].ToLower() != username.ToLower())
                        {
                            toBeWrit += text + '\n';
                        }

                        String[] parts = text.Split('$');      // Breaks the current line into parts
                        if (stuff[0].ToLower() == username.ToLower())
                        {
                            int oldmeals;
                            oldmeals = Int32.Parse(stuff[10]);
                            meals += oldmeals;
                            found = true;
                            toBeWrit = toBeWrit + username + "$" + password + "$" + stuff[2] + "$" +
                                name + "$" + email + "$" + phonenumber + "$" + address + "$" + 
                                creditcard + "$" + security + "$" + expire + "$" + meals + '\n';
                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
                    }
                }
            }
            fileStream.Close();
            if (found)
            {
                toBeWrit += "-1\n";
                System.IO.File.WriteAllText(fileName, toBeWrit);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        internal Customer returnCustomer(string username)
        {
            int tempindex = -1;
            for (int i = 0; i < count; i++)
            {
                if (customers[i].getuser() == username)
                    tempindex = i;
            }
            return customers[tempindex];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal Customer getCustomer(int index)
        {
            return customers[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int getCustIndex (string username)
        {
            int tempindex = -1;
            for (int i = 0; i < count; i++)
            {
                if (customers[i].getuser() == username)
                    tempindex = i;
            }
            return tempindex;
        }
    }
}