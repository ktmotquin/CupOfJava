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
    public partial class AddMealPage : Form
    {
        public AddMealPage()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkForEmpty()
        {
            bool validInfoEntered = true;
            foreach (Control child in this.Controls)
            {
                TextBox textbox = child as TextBox;
                if (textbox != null)
                {
                    if (string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        MessageBox.Show("All text boxes must be filled");
                        return false;
                    }
                }
            }
            return validInfoEntered;
        }

        private void AddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string filestring = imgfile.Text + ".bmp";
                string test = Directory.GetCurrentDirectory() + @"\" + filestring;
                Image img = Image.FromFile(test);


                string replaceWith = "~";
                string overallText = "1\n";
                string temp, enteredInfo;
                bool found = false; // True if an account is associated with the login info
                bool done = false;  // True when end of user list has been reached
                if (checkForEmpty())
                {
                    enteredInfo = MealName.Text + "$" + Description.Text.Replace("\r\n", replaceWith) + "$" + comboBox1.Text + "$"
                                    + Instructions.Text.Replace("\r\n", replaceWith) + "$" +
                                    Ingredients.Text.Replace("\r\n", replaceWith) + "$" + imgfile.Text + ".bmp";
                    System.Console.WriteLine(enteredInfo);
                    string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
                    var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link                                                                                                                        
                                                                                               //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);

                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        while (!done)
                        {
                            temp = streamReader.ReadLine();         // read next line
                            if (!temp.Equals("-1"))                 // Check if end of file has been reached 
                            {
                                System.Console.WriteLine("Entered text " + temp);
                                if (!temp.Equals("1"))
                                {
                                    overallText += temp + '\n';
                                }
                                if (temp.Equals(enteredInfo))
                                {
                                    found = true;
                                    done = true;                    // Meal Info is unique
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
                        overallText += enteredInfo + "\n-1";
                        System.IO.File.WriteAllText(fileName, overallText);
                        //ID.Clear();
                        MealName.Clear();
                        //Type.Clear();
                        // Keywords.Clear();
                        imgfile.Clear();
                        Instructions.Clear();
                        Description.Clear();
                        Ingredients.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error: meal info is not unique.");  // Display meal info already exists
                    }
                }
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show("Image not found!" + error.FileName);

            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please add BMP file to the folder where the .exe file exists\n" +
    "Add name of BMP file to text box\n" + "Careful, do not add .bmp to filename");
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
        }

        private void AddMealPage_Load(object sender, EventArgs e)
        {

        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

