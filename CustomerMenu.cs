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
   public partial class CustomerMenu : Form
   {
      private MealList m = new MealList();
      private CustomerList list = new CustomerList();
      private Customer cust;
      public CustomerMenu(string username)
      {
         InitializeComponent();
         if (username == "administrator")
         {
            lblname.Text = "Administrator";
            lblname.Font = new Font("Cailibri", 12, FontStyle.Regular);
            lblname.Location = new Point(100, 10);
                btnEditInfo.Hide();
                Logout.Hide();
            cartButton.Hide();
            button1.Hide();
         }
         else
         {
            lblname.Text = username;
            lblname.Font = new Font("Cailibri", 12, FontStyle.Regular);
            lblname.Location = new Point(100, 10);
            numMealLbl.Text = Convert.ToString(list.returnCustomer(username).getNumMeals());
            numMealLbl.Location = new Point(420, 10);
            numMealLbl.Font = new Font("Cailibri", 12, FontStyle.Regular);
         }
      }


      private void Logout_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public void CustomerMenu_Load(object sender, EventArgs e)
      {
            if (lblname.Text != "Administrator")
            {
                cust = list.returnCustomer(lblname.Text);
                numMealLbl.Text = Convert.ToString(cust.getNumMeals());
            }
            else
            {
                cust = new Customer("admin", "xxxx", "xxxx",
            "xxxx", "xxxx", "xxxx", "xxxx",
            "xxxx", "xxxx", 0);
            }   
        }

        private void mealSearch_Click(object sender, EventArgs e)
        {
            searchList.Items.Clear();
            string meal = searchBox.Text.ToUpper();
            int search = m.searchList(meal);
            if (search == -1 && meal != "")
            {
                MessageBox.Show("No Results Found!");

            }
            else
            {
                string type = "";
                if (btnPasta.Checked == true)
                {
                    type = "pasta";
                }
                else if (btnSalad.Checked == true)
                {
                    type = "salad";
                }
                else if (btnDessert.Checked == true)
                {
                    type = "dessert";
                }
                else if (btnSandwich.Checked == true)
                {
                    type = "sandwich";
                }
                else if (btnSoup.Checked == true)
                {
                    type = "soup";
                }
                else if (btnBakes.Checked == true)
                {
                    type = "bakes";
                }
                else if (btnAppetizers.Checked == true)
                {
                    type = "appetizer";
                }
                else if (btnTortilla.Checked == true)
                {
                    type = "tortilla based";
                }
                else if (btnRice.Checked == true)
                {
                    type = "rice based";
                }
                else if (anytype.Checked == true)
                {
                    type = "";
                }

                if (m.checktype(search, type) || type == "")
                {
                    if (search == -1)
                        search = 0;
                    searchList.Items.Add(m.sendmeal(search).name());
                    int index = 0;
                    while (index < m.getcount())
                    {
                        if (m.searchtype(type, index) || type == "")
                        {
                            if (m.sendmeal(index).name() != m.sendmeal(search).name())
                            {
                                searchList.Items.Add(m.sendmeal(index).name());
                            }
                        }
                        index++;
                    }
                }
                else if(search == -1)
                {
                    for(int i = 0; i < m.getcount(); i++)
                    {
                        if(m.checktype(i, type))
                            searchList.Items.Add(m.sendmeal(i).name());
                    }
                }
            }
        }

        private void mealView_Click(object sender, EventArgs e)
        {
           if(searchList.SelectedIndex > -1)
            {
                if(lblname.Text != "Administrator")
                {
                    cust = list.returnCustomer(lblname.Text);
                }
                string meal = searchList.SelectedItem.ToString();
                int index = m.searchList(meal);
                Meal_Screen mealForm = new Meal_Screen(m.sendmeal(index), m.ScaleImage(m.getimg(index)), cust);            
                mealForm.Show();
            }
            else
            {
                MessageBox.Show("Select Meal!");
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            if (cust.getCartMeals() == 0)
                MessageBox.Show("Your Cart is Empty! " +
                    "Please Add Items Before Checking Out!");
            else
            {
                Cart cart = new OOAD_Project.Cart(cust, this);
                cart.Show();
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MealRequest mr = new MealRequest();
             mr.Show();
        }

        private void back2Main_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            int index = list.getCustIndex(lblname.Text);
            CreateAcc accountedit = new CreateAcc('E',index );
            accountedit.Show();
            this.Close();
        }

        private void CustomerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(lblname.Text != "Administrator")
            {
               list.updateMeals(lblname.Text, Int32.Parse(numMealLbl.Text));
            }               
        }
    }
}