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
    public partial class Edit_Meals : Form
    {
        private MealList meals = new MealList();
        public Edit_Meals()
        {
            InitializeComponent();
        }

        private void Edit_Meals_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < meals.getcount(); i++)
            {
                    listBox1.Items.Add(meals.sendmeal(i).name());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Customer admin = new Customer("admin", "xxxx", "xxxx",
            "xxxx", "xxxx", "xxxx", "xxxx",
            "xxxx", "xxxx", 0);
            Meal_Screen adminedit = new Meal_Screen(meals.sendmeal(index), 
                meals.ScaleImage(meals.getimg(index)), admin);
            this.Hide();
            adminedit.Show();
        }
    }
}
