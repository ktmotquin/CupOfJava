using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOAD_Project
{
    class Login
    {
        private string un, pw;  // Username, password
        private char access = 'n';

        public Login(string uname, string pass)
        {
            un = uname; // Username
            pw = pass;  // Password
        }

        private bool findUser()
        {
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
           // var fileStream = new FileStream(@"c:\users\restore\documents\visual studio 2015\Projects\OOAD Project\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!found && !done)
                {
                    text = streamReader.ReadLine();         // read next line
                    if (!text.Equals("-1"))                 // Check if end of file has been reached 
                    {
                        String[] parts = text.Split();      // Breaks the current line into parts
                        if (un.Equals(parts[0]) && pw.Equals(parts[1]))
                        {
                            access = Char.Parse(parts[2]);  // 
                            found = true;                   // Account info is correct
                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
                    }
                }
            }
            fileStream.Close();
            return found;
        }

        public bool isUser()
        {
            return findUser();
        }

        public char Access()
        {
            return UserAccess();
        }

        private char UserAccess()
        {
            return access;
        }
    }
}
