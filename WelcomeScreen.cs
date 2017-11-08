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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Screen loginForm = new Login_Screen();
            loginForm.Show();
            //new Login_Screen();
            //Application.Run(new Login_Screen());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();        // Hide this window
            MessageBox.Show("Thank you for using our system.\n" +
                "We hope you found everything you were looking for!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAcc accountForm = new CreateAcc();
            accountForm.Show();
        }
    }
}
