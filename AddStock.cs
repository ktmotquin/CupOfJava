﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string toBeWrit = "$\n";
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\FoodItems.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
                                                                                       //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    string[] stuff = text.Split('~');
                    if (!stuff[0].Equals("-$"))                 // Check if end of file has been reached 
                    {
                        if (!stuff[0].Equals("$"))
                        {
                            toBeWrit += text + '\n';
                        }

                        //String[] parts = text.Split('~');      // Breaks the current line into parts
                        //if (addBtn.Text.Equals(stuff[0]))
                        //{
                        //    found = true;
                        //    done = true;                    // Account info is correct
                        //}
                    }
                    else
                    {
                        done = true;                        // Info not found
                    }
                }
            }
            fileStream.Close();
            if (!found)
            {

                string text1;

                text1 = addTextBox.Text + "~" + quantityTxtBox.Text + "\n-$";



                toBeWrit += text1;
                System.IO.File.WriteAllText(fileName, toBeWrit);
                this.Close();
            }
            else
            {
                MessageBox.Show("Item is already in database");
            }

        }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string toBeWrit = "1\n";
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\UserList.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
                                                                                       //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    string[] stuff = text.Split('$');
                    if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (!stuff[0].Equals("1"))
                        {
                            toBeWrit += text + '\n';
                        }

                        String[] parts = text.Split('$');      // Breaks the current line into parts
                        if (modifyTxtBox.Text.Equals(stuff[0]))
                        {
                            found = true;
                            done = true;                    // Account info is correct
                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
                    }
                }
            }
            fileStream.Close();
            if (!found)
            {
                 string text1;

          
               
                    MessageBox.Show("In Database");  // Display passwords do not match
            }
            else
            {
                MessageBox.Show("Error: Username already taken.");  // Display passwords do not match
            }
        }
    }
    }


           
  

    


