﻿using System;
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
        const float STANDARD_PRICE = 7.50f;
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
            countBox.Text = "0";
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
        }

        //----------------------------------------------------------------
        // Sends the meals in CartList to the CartManager for the
        // order to be processed.
        //----------------------------------------------------------------
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            order = new CartManager(cust, cust.getPayPlan());
            foreach (Meal m in CartList.CheckedItems)
            {
                if (!order.add(m))
                    MessageBox.Show("You've gone over your maximum meals!"
                        + "Please add some more meals to continue.");
                    break;
            }
        }

        //----------------------------------------------------------------
        // Upon opening the form, the subtotal, tax, and total will be
        // calculated an displayed on the form. Also, the meals currently
        // in the user's cart array will be displayed in CartList.
        //----------------------------------------------------------------
        private void Cart_Activated(object sender, EventArgs e)
        {
            int i = 0, itemCount = 0;
            foreach(Meal m in cust.getCart())
            {
                CartList.Items.Insert(i, m.name());
                ++itemCount;
            }
            countBox.Text = itemCount.ToString();
        }
    }
}
