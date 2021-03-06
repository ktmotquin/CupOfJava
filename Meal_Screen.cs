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
   public partial class Meal_Screen : Form
   {
        /* This constructor allows Meal_Screen to run.  If the currently logged in user is
         * an administrator, certain buttons will be hidden from their view.  If the
         * currently logged in user is a customer, all buttons will be visible. 
         */
        private Customer cust;
        private Meal meal;
      public Meal_Screen(Meal m, Image mealImage, Customer c)
      {
         InitializeComponent();
            meal = m;
            cust = c;
         if (cust.getuser() == "admin")
         {
            addToCartButton.Hide();
            orderQuantityLabel.Hide();
            mealQtyUpDown.Hide();
            btnEdit.Enabled= true;
            btnEdit.Visible = true;
            descriptionDisplayBox.ReadOnly = false;
            ingredientsDisplayBox.ReadOnly = false;
            instructionsDisplayBox.ReadOnly = false;    
         }
         
         descriptionDisplayBox.Text = meal.description().Replace("~", "\n"); ;
         mealNameText.Text = meal.name();
         ingredientsDisplayBox.Text = meal.ingredients().Replace("~", "\n"); ;
         instructionsDisplayBox.Text = meal.instructions().Replace("~", "\n");
         pictureBox1.Image = mealImage;
      }

      /** Clicking the "Add to Cart" button brings up a pop-up asking
       * the user if they want to "Return to Search" or "View Cart". 
       * */
      private void addToCartButton_Click(object sender, EventArgs e)
      {
         int numMeals = (int)mealQtyUpDown.Value;
         if (numMeals == 0)
         {
            MessageBox.Show("Please enter the quantity of meals you would like to order.");
         }
         else if(numMeals + cust.getCartMeals() > cust.getNumMeals())
         {
            MessageBox.Show("You don't have enough meals!");
            mealQtyUpDown.Value = 0;
         }
         else
         {
            cust.addToCart(meal, numMeals);
            MessageBox.Show("Meal has been added to cart.", "Meal has been added to your cart.", MessageBoxButtons.OK);
            this.Close();
         }
      }

      /* Clicking "Back to Search" button allows user to cancel
       * looking at the item, and to return to the Customer Menu.
       * */
      private void backToSearch_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
         MealList meal = new MealList();
         meal.editmeal(mealNameText.Text, descriptionDisplayBox.Text, ingredientsDisplayBox.Text, instructionsDisplayBox.Text);
            MessageBox.Show("Changes saved.", "Edit Meal", MessageBoxButtons.OK);
            Edit_Meals edit = new Edit_Meals();
            this.Close();
            edit.Show();
        }
   }
}
