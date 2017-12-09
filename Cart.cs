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
        CustomerMenu parent;
        CartManager order;
        //----------------------------------------------------------------
        // Constructor: Initializes components and assigns a temporary
        // customer object to the customer passed in to the form.
        //----------------------------------------------------------------
        public Cart(Customer inCust, CustomerMenu p)
        {
            InitializeComponent();
            cust = inCust;
            parent = p;
            order = new CartManager(cust);
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
            foreach(String mealName in CartList.CheckedItems)
            {
                for (int i = 0; i < cust.getCartMeals(); i++)
                    if (cust.getCart()[i].name() == mealName)
                    {
                        cust.removeItem(cust.getCart()[i]);
                        break;
                    }
            }
            CartList.Items.Clear();
            Cart_Load(sender, e);
        }

        //----------------------------------------------------------------
        // Sends the meals in CartList to the CartManager,  processes the 
        // order, and resets the countBox and remainingMeals fields.
        //----------------------------------------------------------------
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (CartList.CheckedItems != null)
            {
                order = new CartManager(cust);
                foreach (string mealName in CartList.CheckedItems)
                {
                    for (int i = 0; i < cust.getCartMeals(); i++)
                    {
                        if (cust.getCart()[i].name() == mealName)
                            if (!order.addToOrder(cust.getCart()[i]))
                            {
                                MessageBox.Show("You've gone over your maximum meals!"
                                    + " Please add some more meals to continue.");
                                Close();
                                break;
                            }
                    }
                }
                order.processOrder();
                parent.CustomerMenu_Load(sender, e);
                Close();
            }
        }

        //----------------------------------------------------------------
        // Upon opening the form, the subtotal, tax, and total will be
        // calculated an displayed on the form. Also, the meals currently
        // in the user's cart array will be displayed in CartList.
        //----------------------------------------------------------------
        private void Cart_Load(object sender, EventArgs e)
        {
            int itemCount = 0;
            if (cust.getCartMeals() != 0)
            {
                foreach (Meal m in cust.getCart())
                {
                    if (m != null)
                    {
                        if (CartList.Items != null &&
                            !CartList.Items.Contains(m.name()))
                        {
                            CartList.Items.Add(m.name());
                            ++itemCount;
                        }
                    }
                }
                countBox.Text = cust.getCartMeals().ToString();
            }
            else
            {
                MessageBox.Show("Your Cart is Now Empty.");
                Close();
            }
        }
    }
}
