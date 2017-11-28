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
 //                             customers[count] = new Customer(parts[0], parts[1], parts[3], parts[4], parts[5], parts[6],
  //                                parts[7], parts[8], parts[9]);
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

    }
}