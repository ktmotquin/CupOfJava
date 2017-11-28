using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project
{
   public partial class Meal_Screen : Form
   {
      public Meal_Screen(string name, string description,
         string instructions, string ingredients, Image img, string username)
      {
         //Edited by Sam 11/27 8:13PM
         InitializeComponent();
         if (username == "Administrator")
         {
            addToCartButton.Hide();
            orderQuantityLabel.Hide();
            mealQtyUpDown.Hide();
         }
         
         descriptionDisplayBox.Text = description.Replace("~", "\n"); ;
         mealNameText.Text = name;
         ingredientsDisplayBox.Text = ingredients.Replace("~", "\n"); ;
         instructionsDisplayBox.Text = instructions.Replace("~", "\n");
         pictureBox1.Image = img;
         //usernameLabel.Text = username;   
      }
      private void Meal_Screen_Load(object sender, EventArgs e)
      {

      }

      /** Clicking the "Add to Cart" button brings up a pop-up asking
       * the user if they want to "Return to Search" or "View Cart". 
       * */
      private void addToCartButton_Click(object sender, EventArgs e)
      { 
         MessageBox.Show("Meal has been added to cart.", "Meal has been added to your cart.", MessageBoxButtons.OK);
         this.Close();
      }

      /** Clicking "Back to Search" button allows user to essentially
       * cancel looking at the item, and to return to the CustomerMenu.
       * */
      private void backToSearch_Click(object sender, EventArgs e)
      {
         this.Close();
         //CustomerMenu backToSearch = new CustomerMenu(name);
         //backToSearch.Show();
      }
   }
}
