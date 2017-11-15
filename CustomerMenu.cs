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
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();   // Close this window
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void mealSearch_Click(object sender, EventArgs e)
        {
            searchList.Items.Clear();
            string meal = searchBox.Text;
            int search = m.searchList(meal);
            if (search == -1)
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
                else if (btnSalad.Checked == true)
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
                    type = "bake";
                }
                else if (btnAppetizers.Checked == true)
                {
                    type = "appetizer";
                }
                else if (btnTortilla.Checked == true)
                {
                    type = "tortilla";
                }
                else if (btnRice.Checked == true)
                {
                    type = "rice";
                }
                if (m.checktype(search, type))
                {
                    searchList.Items.Add(m.sendmeal(search).name());
                    int index = 0;
                    while (index < m.getcount())
                    {
                        if (m.searchtype(type, index))
                        {
                            if (m.sendmeal(index).name() != m.sendmeal(search).name())
                            {
                                searchList.Items.Add(m.sendmeal(index).name());
                            }

                        }
                        index++;
                    }
                }
                else if(type == "")
                {
                    searchList.Items.Add(m.sendmeal(search).name());
                    int index = 0;
                    while (index < m.getcount())
                    {
                            if (m.sendmeal(index).name() != m.sendmeal(search).name())
                            {
                                searchList.Items.Add(m.sendmeal(index).name());
                            }

                        index++;
                    }
                }
            }

        }

        private void mealView_Click(object sender, EventArgs e)
        {
            string meal = searchList.SelectedItem.ToString();

            int index = m.searchList(meal);
            Meal_Screen mealForm = new Meal_Screen();
            mealForm.Show();
            //mealForm.
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Meal pasta = new Meal("pasta", "pasta", "PASTA", 1234);
            Meal apple = new Meal("Apple", "Red", "soup", 5678);
            Meal pasta2 = new Meal("pasta2", "pasta", "pasta", 5432);
            m.addMeal(pasta);
            m.addMeal(apple);
            m.addMeal(pasta2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
