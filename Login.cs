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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        public Login(string uname, string pass)
        {
            un = uname; // Username
            pw = pass;  // Password
        }

        /// <summary>
        /// Finds a users information if they exist, and if they do, returns true.
        /// </summary>
        /// <returns>True if user info found and valid, false if not.</returns>
        private bool findUser()
        {
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\UserList.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!found && !done)
                {
                    text = streamReader.ReadLine();                         // read next line
                    if (!text.Equals("-1"))                                 // Check if end of file has been reached 
                    {
                        String[] parts = text.Split('$');                   // Breaks the current line into parts
                        if (un.Equals(parts[0]) && pw.Equals(parts[1]))
                        {
                            access = Char.Parse(parts[2]);                  // 
                            found = true;                                   // Account info is correct
                        }
                    }
                    else
                    {
                        done = true;                                        // Info not found
                    }
                }
            }
            fileStream.Close();
            return found;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isUser()
        {
            return findUser();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public char Access()
        {
            return UserAccess();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private char UserAccess()
        {
            return access;
        }
    }
}
