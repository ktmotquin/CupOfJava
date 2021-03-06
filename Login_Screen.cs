﻿using System;
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
    public partial class Login_Screen : Form
    {
        
        /// <summary>
        /// 
        /// </summary>
        public Login_Screen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login(Username.Text, Password.Text);
            if(log.isUser())
            {
                if(log.Access() == 'C')
                {
                    CustomerMenu Customer = new CustomerMenu(Username.Text);                    
                    Customer.Show();
                    this.Close();
                }
                else if(log.Access() == 'A')
                {
                    AdminMenu Admin = new AdminMenu();
                    Admin.Show();
                    this.Close();
                }
                MessageBox.Show("Disclaimer: All photos, descriptions, ingredients, and instructions" +
            " for recipes are from www.bettycrocker.com.");
            }
            else
            {
                MessageBox.Show("Incorrect username or password entered.\nPlease try again.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
