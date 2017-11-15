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
            char delimiter = '~';
            string overallText = "1\n";
            string temp, enteredInfo;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            if (checkForEmpty())
            {
                enteredInfo = ID.Text + " " + MealName.Text + " " + Type.Text + " " + Keywords.Text.Replace(' ',delimiter)
                    + " " + Calories.Text + " " + Allergens.Text.Replace(' ', delimiter) + " " 
                    + Description.Text.Replace(' ', delimiter) + " " + Ingredients.Text.Replace(' ', delimiter);
                System.Console.WriteLine(enteredInfo);
               
                var fileStream = new FileStream(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\Meals.txt", FileMode.Open, FileAccess.Read); // Joe's link                                                                                                                        
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
                     
                        overallText += enteredInfo+ "\n-1";
                        System.IO.File.WriteAllText(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\Meals.txt", overallText);
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Error: meal info is not unique.");  // Display meal info already exists
                }
            }
        }
    }
}
