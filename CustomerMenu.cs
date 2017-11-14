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
                searchList.Items.Add(m.sendmeal(search).name());

            if(fruitButton.Enabled == true)
            {
                bool valid = true;
                string type = "fruit";
                if(m.checktype(search, type))
                {
                    int index = 0;
                    while (valid)
                    {
                        if(m.searchtype(type, index, valid))
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
            string meal = searchList.GetItemText(searchList.SelectedIndex);            
            int index = m.searchList(meal);
            Meal_Screen mealForm = new Meal_Screen();
            mealForm.Show();
            //mealForm.
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Meal banana = new Meal("Banana", "Yellow", "Fruit", 1234);
            Meal apple = new Meal("Apple", "Red", "Fruit", 5678);
            m.addMeal(banana);
            m.addMeal(apple);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
