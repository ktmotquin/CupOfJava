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
   public partial class Cart : Form
   {
        Customer cust;
        CartManager order;
        //----------------------------------------------------------------
        // Constructor: Initializes components and assigns a temporary
        // customer object to the customer passed in to the form.
        //----------------------------------------------------------------
        public Cart(Customer inCust)
        {
            InitializeComponent();
            cust = inCust;
            countBox.Text = cust.getCart().Length.ToString();
            remainingMeals.Text = cust.getNumMeals().ToString();
        }

        //----------------------------------------------------------------
        // Removes all checked items from CartList, as well as from the
        // customer's cart. Also updates all numbers displayed on the
        // form.
        //----------------------------------------------------------------
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach(Meal m in CartList.CheckedItems)
                cust.removeItem(m);
            countBox.Text = cust.getCart().Length.ToString();
        }

        //----------------------------------------------------------------
        // Sends the meals in CartList to the CartManager,  processes the 
        // order, and resets the countBox and remainingMeals fields.
        //----------------------------------------------------------------
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            order = new CartManager(cust);
            foreach (Meal m in CartList.CheckedItems)
            {
                if (!order.add(m))
                {
                    MessageBox.Show("You've gone over your maximum meals!"
                        + "Please add some more meals to continue.");
                    this.Close();
                    break;
                }
            }
            order.processOrder();
            countBox.Text = cust.getCart().Length.ToString();
            remainingMeals.Text = cust.getNumMeals().ToString();
        }

        //----------------------------------------------------------------
        // Upon opening the form, the subtotal, tax, and total will be
        // calculated an displayed on the form. Also, the meals currently
        // in the user's cart array will be displayed in CartList.
        //----------------------------------------------------------------
        private void Cart_Activated(object sender, EventArgs e)
        {
            int itemCount = 0;
            foreach (Meal m in cust.getCart())
            {
                if (!CartList.Items.Contains(m.name()))
                {
                    CartList.Items.Add(m.name());
                    ++itemCount;
                }
            }
            countBox.Text = cust.getCartMeals().ToString();
        }
    }
}
