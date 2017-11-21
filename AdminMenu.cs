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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();       // Close this window
        }

        private void AddMeal_Click(object sender, EventArgs e)
        {
            AddMealPage adm = new AddMealPage();
            this.Hide();
            adm.Show();
        }

        private void ViewStatsButton_Click(object sender, EventArgs e)
        {
            StatsPage sts = new StatsPage();
            this.Hide();
            sts.Show();
        }
    }
}
