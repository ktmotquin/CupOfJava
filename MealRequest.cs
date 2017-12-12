using System;
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
    public partial class MealRequest : Form
    {
        public MealRequest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if any of the input fields are null or empty. If at least one of the fields is
        /// null or empty, then false is returned. Otherwise, returns true.
        /// </summary>
        /// <returns>True if all fields are completed, otherwise null.</returns>
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

        /// <summary>
        /// Sends meal information to be approved by an administrator after checking
        /// to determine if the entered meal information is unique and all fields have
        /// been filled out. If the entered meal information is not unique or a at 
        /// least one field is empty or null, a message saying so will be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMeal_Click(object sender, EventArgs e)
        {
            string replaceWith = "~";
            string overallText = "1\n";
            string temp, enteredInfo;
            bool found = false;             // True if an account is associated with the login info
            bool done = false;              // True when end of user list has been reached
            if (checkForEmpty())
            {
                enteredInfo = MealName.Text + "$" + Description.Text.Replace("\r\n", replaceWith) + "$" + comboBox1.Text + "$"
                                + Instructions.Text.Replace("\r\n", replaceWith) + "$" +
                                Ingredients.Text.Replace("\r\n", replaceWith) + "$" + imgfile.Text + ".bmp";
                System.Console.WriteLine(enteredInfo);
                string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
                var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link                                                                                                                        

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
                                overallText += temp + '\n';     // Add line to overall text
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
                fileStream.Close();         // Close the file stream

                string fileName2 = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\MealRequests.txt");
                if (!found)
                { 
                    enteredInfo = "1\n" + enteredInfo + "\n-1";
                    System.IO.File.WriteAllText(fileName2, enteredInfo);
                    /*
                    //ID.Clear();
                    MealName.Clear();
                    //Type.Clear();
                    // Keywords.Clear();
                    imgfile.Clear();
                    Instructions.Clear();
                    Description.Clear();
                    Ingredients.Clear();
                    */
                    MessageBox.Show("Thank you for submitting your meal request!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error: meal info is not unique.");  // Display meal info already exists
                }
            }
        }


        /// <summary>
        /// Display a helpful message for users who do not understand what kind of image to add.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please add BMP file to the folder where the .exe file exists\n" +
                "Add name of BMP file to text box\n" + "Careful, do not add .bmp to filename");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
        }

      private void Cancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
