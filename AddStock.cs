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
    public partial class AddStock : Form
    {
        //----------------------------------------------------------------
        // Constructor: Initializes all the text boxes and buttons on the 
        //              screen. 
        //----------------------------------------------------------------
        public AddStock()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------
        // Adds a new ingredient to the text file along with the initial amount.
        //----------------------------------------------------------------
        private void addBtn_Click(object sender, EventArgs e)
        {
            string toBeWrit = "$\n";
            string text;
            bool found = false; 
            bool done = false;  
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\FoodItems.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link

            if (String.IsNullOrEmpty(addTextBox.Text) || String.IsNullOrEmpty(quantityTxtBox.Text))
            {
                MessageBox.Show("Please enter an item and a quantity.");
            }
            else
            {
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

                        }
                        else
                        {
                            done = true;                        // Item not found
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
        }

        //----------------------------------------------------------------
        // This updates the quantity of an item.
        //----------------------------------------------------------------
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string toBeWrit = "";
            string text;
            bool found = false;
            bool done = false;
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\FoodItems.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            if (String.IsNullOrEmpty(modifyTxtBox.Text) || String.IsNullOrEmpty(quantityTxtBox2.Text))
            {
                MessageBox.Show("Please enter an item and a quantity.");
            }
            else
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    while (!done)
                    {
                        text = streamReader.ReadLine();
                        string[] stuff = text.Split('~');
                        if (!stuff[0].Equals("-$"))
                        {
                            String[] parts = text.Split('~');      // Breaks the current line into parts
                            if (modifyTxtBox.Text.Equals(stuff[0]))
                            {
                                found = true;
                                int item1, item2;
                                Int32.TryParse(quantityTxtBox2.Text, out item1);
                                Int32.TryParse(stuff[1], out item2);
                                int numitems = item1 + item2;
                                text = stuff[0] + "~" + numitems;
                            }
                            toBeWrit += text + '\n';
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
                    toBeWrit += "-$\n";
                    System.IO.File.WriteAllText(fileName, toBeWrit);

                    MessageBox.Show("Added " + quantityTxtBox2.Text + " items of " + modifyTxtBox.Text + " to database");
                }
                else
                {
                    MessageBox.Show("Error: Item not found");  // Display passwords do not match
                }
            }
        }

      private void backToAdminMenu_Click(object sender, EventArgs e)
      {
         this.Hide();
      }
   }
    }


           
  

    


