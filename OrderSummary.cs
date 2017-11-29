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
    public partial class OrderSummary : Form
    {
        public OrderSummary() { InitializeComponent(); }

        public void display(Meal[] m)
        {
            foreach (Meal meal in m)
                OrderList.Items.Add(meal.name());
        }

        public void displayCount(int num)
        { remainderBox.Text = num.ToString(); }
    }
}
