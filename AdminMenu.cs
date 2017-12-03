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

        private void button1_Click(object sender, EventArgs e)
        {
            string custIsAdmin = "administrator";
            CustomerMenu custMenuView = new CustomerMenu(custIsAdmin);
            this.Hide();
            custMenuView.Show();

        }

        private void btnAddAdminAcc_Click(object sender, EventArgs e)
        {
            CreateAcc acc = new CreateAcc('A', -1);
            this.Hide();
            acc.Show();
        }

        private void modifyStockBtn_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            this.Hide();
            addStock.Show();
        }

        private void ApproveMealRequests_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Remove_Meal remove = new Remove_Meal();
            remove.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Meals mealedit = new Edit_Meals();
            mealedit.Show();

        }
    }
}
