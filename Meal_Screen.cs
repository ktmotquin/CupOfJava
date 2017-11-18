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
        public Meal_Screen()
        {
            InitializeComponent();
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
         if (MessageBox.Show("Meal has been added to the cart.\n " +
            "Do you want to view your cart(yes) or return to the search page(no)?"
            , "Meal Added to Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            CustomerMenu returnCust = new CustomerMenu();
            this.Close();
            Cart cartForm = new Cart(returnCust);
            cartForm.Show();
            
         }
         else
         {
            this.Close();
            CustomerMenu menuForm = new CustomerMenu();
            menuForm.Show();
         }
      }
   }
}
