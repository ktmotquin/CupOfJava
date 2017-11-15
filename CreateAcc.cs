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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passText.SelectedText.Equals(confirmPassText.SelectedText))
            {
                string toBeWrit = "1\n";
                string text;
                bool found = false; // True if an account is associated with the login info
                bool done = false;  // True when end of user list has been reached
                var fileStream = new FileStream(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read); // Joe's link
                                                                                                                                                                             //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    while (!done)
                    {
                        text = streamReader.ReadLine();         // read next line
                        
                        string[] stuff = text.Split();
                        if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                        {
                            if(!stuff[0].Equals("1"))
                            {
                                toBeWrit += text + '\n';
                            }
                            
                            String[] parts = text.Split();      // Breaks the current line into parts
                            if (unameText.Text.Equals(stuff[0]))
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
                    if(passText.Text.Equals(confirmPassText.Text))
                    {
                        string text1 = unameText.Text + " " + passText.Text + " C\n-1";
                        toBeWrit += text1;
                        System.IO.File.WriteAllText(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", toBeWrit);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Passwords do not match.");  // Display passwords do not match

                    }
                }
                else
                {
                    MessageBox.Show("Error: Username already taken.");  // Display passwords do not match
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (passText.SelectedText.Equals(confirmPassText.SelectedText))
            {
                string toBeWrit = "1\n";
                string text;
                bool found = false; // True if an account is associated with the login info
                bool done = false;  // True when end of user list has been reached
                var fileStream = new FileStream(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read); // Joe's link
                                                                                                                                                                             //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    while (!done)
                    {
                        text = streamReader.ReadLine();         // read next line

                        string[] stuff = text.Split();
                        if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                        {
                            if (!stuff[0].Equals("1"))
                            {
                                toBeWrit += text + '\n';
                            }

                            String[] parts = text.Split();      // Breaks the current line into parts
                            if (unameText.Text.Equals(stuff[0]))
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
                    if (passText.Text.Equals(confirmPassText.Text))
                    {
                        string text1 = unameText.Text + " " + passText.Text + " C\n-1";
                        toBeWrit += text1;
                        System.IO.File.WriteAllText(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", toBeWrit);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Passwords do not match.");  // Display passwords do not match

                    }
                }
                else
                {
                    MessageBox.Show("Error: Username already taken.");  // Display passwords do not match
                }
            }
        }
    }
}