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
        public OrderSummary()
        {
            InitializeComponent();
        }

        public void display(Meal[] m)
        {
          
        }

        public void displayCount(int num)
        {
            remainderBox.Text = num.ToString();
        }
    }
}
