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
    public partial class Remove_Meal : Form
    {
        private MealList meal = new MealList();
        public Remove_Meal()
        {
            InitializeComponent();
        }

        private void Remove_Meal_Load(object sender, EventArgs e)
        {
            int count;
            count = meal.getcount();

            for(int i = 0; i < count; i++ )
            {
            listBox1.Items.Add(meal.sendmeal(i).name());

             
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(meal.removemeal(listBox1.SelectedIndex))
            {
                MessageBox.Show("Meal has been deleted.", "Meal has been deleted.", MessageBoxButtons.OK);
            }
        }

      private void backToAdminMenu_Click(object sender, EventArgs e)
      {
         this.Hide();
      }

      private void backToAdminMenu_Click_1(object sender, EventArgs e)
      {
         this.Hide();
      }
   }
}
