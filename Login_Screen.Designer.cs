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
         this.loginButton = new System.Windows.Forms.Button();
         this.cancelButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(102, 2);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(159, 29);
         this.label1.TabIndex = 0;
         this.label1.Text = "Food 2 U login ";
         // 
         // Username
         // 
         this.Username.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Username.Location = new System.Drawing.Point(140, 35);
         this.Username.Margin = new System.Windows.Forms.Padding(4);
         this.Username.Name = "Username";
         this.Username.Size = new System.Drawing.Size(226, 36);
         this.Username.TabIndex = 1;
         this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(13, 38);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(119, 29);
         this.label2.TabIndex = 2;
         this.label2.Text = "Username:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(21, 82);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(116, 29);
         this.label3.TabIndex = 3;
         this.label3.Text = "Password: ";
         // 
         // Password
         // 
         this.Password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Password.Location = new System.Drawing.Point(140, 79);
         this.Password.Margin = new System.Windows.Forms.Padding(4);
         this.Password.Name = "Password";
         this.Password.Size = new System.Drawing.Size(226, 36);
         this.Password.TabIndex = 4;
         this.Password.UseSystemPasswordChar = true;
         // 
         // loginButton
         // 
         this.loginButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.loginButton.Location = new System.Drawing.Point(13, 136);
         this.loginButton.Margin = new System.Windows.Forms.Padding(4);
         this.loginButton.Name = "loginButton";
         this.loginButton.Size = new System.Drawing.Size(108, 46);
         this.loginButton.TabIndex = 5;
         this.loginButton.Text = "Login";
         this.loginButton.UseVisualStyleBackColor = true;
         this.loginButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // cancelButton
         // 
         this.cancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cancelButton.Location = new System.Drawing.Point(140, 136);
         this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(112, 46);
         this.cancelButton.TabIndex = 6;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
         // 
         // Login_Screen
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(379, 195);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.loginButton);
         this.Controls.Add(this.Password);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Username);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

