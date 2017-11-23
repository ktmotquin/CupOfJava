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
         string instructions, string ingredients, Image img)
      {
         InitializeComponent();
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
         //Form YesOrNoForm = new Form();
         //YesOrNoForm.ShowDialog();
         if (MessageBox.Show("Meal has been added to the cart.\n Do you want to view your cart" +
         "(yes) or return to the search page(no)?", "Meal Added to Cart", MessageBoxButtons.YesNo,
         MessageBoxIcon.Question) == DialogResult.Yes)
         {
            //Customer returnCust = new Customer();
            this.Close();
            // Cart cartForm = new Cart(returnCust);
            // cartForm.Show();  
         }
         else
         {
            this.Close();
         }
      }

      private void backToSearch_Click(object sender, EventArgs e)
      {
         string userName = "current User";
         this.Close();
         CustomerMenu backToSearch = new CustomerMenu(userName);
         backToSearch.Show();
      }
   }
}
