using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class CreateAcc : Form
    {
        public char acconttype;
        CustomerList list = new CustomerList();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="index"></param>
        public CreateAcc(char account, int index)
        {
            InitializeComponent();
            acconttype = account;
            btnEdit.Enabled = false;
            btnEdit.Hide();
            if (account == 'A')
            {
                txtbxAddress.Hide();
                txtbxAddress.Enabled = false;
                txtbxCreditNum.Hide();
                txtbxCreditNum.Enabled = false;
                txtbxSecurity.Hide();
                txtbxSecurity.Enabled = false;
                txtbxExpire.Hide();
                txtbxExpire.Enabled = false;
                label2.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                comboBoxNumMeals.Hide();
                nummeals.Hide();
                lblcost.Hide();
                lblcostchange.Hide();
                button1.Text = "Create Administrator Account";
                label3.Hide();
                button1.Location = new Point(button1.Location.X, txtbxPhone.Location.Y + 30);
            }
            else if (account == 'E' && index != -1)
            {
                label3.Hide();
                btnEdit.Show();
                btnEdit.Enabled = true;
                Customer temp = list.getCustomer(index);
                unameText.Text = temp.getuser();
                unameText.Enabled = false;
                passText.Text = temp.getpassword();
                txtbxName.Text = temp.getname();
                txtbxEmail.Text = temp.getemail();
                txtbxPhone.Text = temp.getphone();
                txtbxAddress.Text = temp.getaddress();
                txtbxCreditNum.Text = temp.getcreditcard();
                txtbxSecurity.Text = temp.getsecuritynum();
                txtbxExpire.Text = temp.getexpdate();
                button1.Enabled = false;
                button1.Hide();
            }
        }

        ///
        private void button1_Click(object sender, EventArgs e)
        {
            if (passText.SelectedText.Equals(confirmPassText.SelectedText) && checkforblanks())
            {
                string toBeWrit = "1\n";
                string text;
                bool found = false; // True if an account is associated with the login info
                bool done = false;  // True when end of user list has been reached
                string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\UserList.txt");
                var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
                                                                                           //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    while (!done)
                    {
                        text = streamReader.ReadLine();         // read next line

                        string[] stuff = text.Split('$');
                        if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                        {
                            if (!stuff[0].Equals("1"))
                            {
                                toBeWrit += text + '\n';
                            }

                            String[] parts = text.Split('$');      // Breaks the current line into parts
                            if (unameText.Text.Equals(stuff[0]))
                            {
                                found = true;
                                done = true;                    // Account info is correct
                            }
                        }
                        else
                        {
                            done = true;                        // Info not found
                        }
                    }
                }
                fileStream.Close();
                if (!found)
                {
                    if (passText.Text.Equals(confirmPassText.Text))
                    {
                        int index = comboBoxNumMeals.SelectedIndex;
                        int nummeals = (index + 1) * 5;
                        string text1;
                        if (txtbxAddress.Enabled == true)
                        {
                            text1 = unameText.Text + "$" + passText.Text + "$C$" +
                            txtbxName.Text + "$" + txtbxEmail.Text + "$" + txtbxPhone.Text + "$"
                            + txtbxAddress.Text + "$" + txtbxCreditNum.Text + "$" + txtbxSecurity.Text
                            + "$" + txtbxExpire.Text + "$" + nummeals + "\n-1";
                        }
                        else
                        {
                            text1 = unameText.Text + "$" + passText.Text + "$A$" +
                             txtbxName.Text + "$" + txtbxEmail.Text + "$" + txtbxPhone.Text + "\n-1";
                        }
                        toBeWrit += text1;
                        System.IO.File.WriteAllText(fileName, toBeWrit);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Passwords do not match.");  // Display passwords do not match
                    }
                }
                else
                {
                    MessageBox.Show("Error: Username already taken.");  // Display passwords do not match
                }
            }
            else
            {
                MessageBox.Show("Error: Missing Information.");
            }
        }

        private bool checkforblanks()
        {
            if (acconttype == 'C')
            {
                if (passText.Text == "" || unameText.Text == "" || txtbxName.Text == "" ||
                 txtbxEmail.Text == "" || txtbxPhone.Text == "" || txtbxAddress.Text == "" ||
                 txtbxCreditNum.Text == "" || txtbxSecurity.Text == "" || txtbxExpire.Text == "")
                    return false;
            }
            else if (acconttype == 'A')
            {
                if (passText.Text == "" || unameText.Text == "" || txtbxName.Text == "" ||
                 txtbxEmail.Text == "" || txtbxPhone.Text == "")
                    return false;
            }
            else if (acconttype == 'E')
            {
                if (passText.Text == "" || unameText.Text == "" || txtbxName.Text == "" ||
                 txtbxEmail.Text == "" || txtbxPhone.Text == "" || txtbxAddress.Text == "" ||
                 txtbxCreditNum.Text == "" || txtbxSecurity.Text == "" || txtbxExpire.Text == "")
                    return false;
            }
            else
            {
                return true;
            }
            return true;
        }
        private void unameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '$')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = comboBoxNumMeals.SelectedIndex;
            int nummeals = (index + 1) * 5;
            list.editInfo(unameText.Text, passText.Text, txtbxName.Text, txtbxEmail.Text, txtbxPhone.Text,
                txtbxAddress.Text, txtbxCreditNum.Text, txtbxSecurity.Text, txtbxExpire.Text, nummeals);
            CustomerMenu Customer = new CustomerMenu(unameText.Text);
            Customer.Show();
            this.Close();
        }

        private void comboBoxNumMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxNumMeals.SelectedIndex;
            int mealcost = (index + 1) * 5;
            double mealprice = 8.50;
            double totalcost = mealcost * mealprice;

            lblcostchange.Text = "$ " + totalcost.ToString("0.00"); ;
        }


    }
}
