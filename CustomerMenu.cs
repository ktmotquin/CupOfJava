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
   public partial class CustomerMenu : Form
   {
      private MealList m = new MealList();
      private CustomerList list = new CustomerList();
      public CustomerMenu(string username)
      {
         InitializeComponent();
         //lblname.Text = username;
         //Sam is testing something here - 11/25/17
         if (username == "admin" || username == "Admin" ||
         username == "Administrator" || username == "administrator")
         {
            lblname.Text = "Administrator";
            cartButton.Hide();
            button1.Hide();
         }
         else
         {
            lblname.Text = username;
         }
      }


      private void Logout_Click(object sender, EventArgs e)
      {
         this.Close();   // Close this window
      }

      private void listView1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }


      private void CustomerMenu_Load(object sender, EventArgs e)
      {
         if (lblname.Text != "administrator" || lblname.Text != "admin"
            || lblname.Text != "Admin" || lblname.Text != "Administrator")
            {
                Customer cust = list.returnCustomer(lblname.Text);
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
                if(lblname.Text != "administrator")
                {
                    Customer cust = list.returnCustomer(lblname.Text);
                }
            
            string meal = searchList.SelectedItem.ToString();
            int index = m.searchList(meal);
            Meal_Screen mealForm = new Meal_Screen(m.sendmeal(index).name(), 
                m.sendmeal(index).description(), m.sendmeal(index).instructions(),
                m.sendmeal(index).ingredients(), m.ScaleImage(m.getimg(index)));            
            mealForm.Show();
            }
            else
            {
                MessageBox.Show("Select Meal!");
            }

        }

        private void cartButton_Click(object sender, EventArgs e)
        {

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
           // RequestMealPage rmp = new RequestMealPage();
            //rmp.Show();
        }
    }
}
