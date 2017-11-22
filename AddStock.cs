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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
         AdminMenu adm = new AdminMenu();
         adm.Show();
      }
   }
}
