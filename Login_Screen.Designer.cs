namespace OOAD_Project
{
    partial class Login_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.label1 = new System.Windows.Forms.Label();
         this.Username = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.Password = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.cancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(132, 29);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(104, 17);
         this.label1.TabIndex = 0;
         this.label1.Text = "Food 2 U login ";
         // 
         // Username
         // 
         this.Username.Location = new System.Drawing.Point(136, 83);
         this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Username.Name = "Username";
         this.Username.Size = new System.Drawing.Size(185, 22);
         this.Username.TabIndex = 1;
         this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(51, 86);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(77, 17);
         this.label2.TabIndex = 2;
         this.label2.Text = "Username:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(49, 118);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(77, 17);
         this.label3.TabIndex = 3;
         this.label3.Text = "Password: ";
         // 
         // Password
         // 
         this.Password.Location = new System.Drawing.Point(136, 118);
         this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Password.Name = "Password";
         this.Password.Size = new System.Drawing.Size(185, 22);
         this.Password.TabIndex = 4;
         this.Password.UseSystemPasswordChar = true;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(107, 150);
         this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(108, 29);
         this.button1.TabIndex = 5;
         this.button1.Text = "Login";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // cancel
         // 
         this.cancel.Location = new System.Drawing.Point(223, 151);
         this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.cancel.Name = "cancel";
         this.cancel.Size = new System.Drawing.Size(100, 28);
         this.cancel.TabIndex = 6;
         this.cancel.Text = "Cancel";
         this.cancel.UseVisualStyleBackColor = true;
         this.cancel.Click += new System.EventHandler(this.cancel_Click);
         // 
         // Login_Screen
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(379, 225);
         this.Controls.Add(this.cancel);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.Password);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Username);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Login_Screen";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login_Screen";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
    }
}

