namespace OOAD_Project
{
    partial class AdminMenu
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
            this.logoutAdminBtn = new System.Windows.Forms.Button();
            this.addMealAdminBtn = new System.Windows.Forms.Button();
            this.viewStatsAdminBtn = new System.Windows.Forms.Button();
            this.custViewAdminBtn = new System.Windows.Forms.Button();
            this.addAdminAccBtn = new System.Windows.Forms.Button();
            this.modifyStockBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutAdminBtn
            // 
            this.logoutAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutAdminBtn.Location = new System.Drawing.Point(19, 501);
            this.logoutAdminBtn.Margin = new System.Windows.Forms.Padding(6);
            this.logoutAdminBtn.Name = "logoutAdminBtn";
            this.logoutAdminBtn.Size = new System.Drawing.Size(342, 57);
            this.logoutAdminBtn.TabIndex = 0;
            this.logoutAdminBtn.Text = "Logout";
            this.logoutAdminBtn.UseVisualStyleBackColor = true;
            this.logoutAdminBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addMealAdminBtn
            // 
            this.addMealAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealAdminBtn.Location = new System.Drawing.Point(18, 87);
            this.addMealAdminBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addMealAdminBtn.Name = "addMealAdminBtn";
            this.addMealAdminBtn.Size = new System.Drawing.Size(342, 57);
            this.addMealAdminBtn.TabIndex = 1;
            this.addMealAdminBtn.Text = "Add Meal";
            this.addMealAdminBtn.UseVisualStyleBackColor = true;
            this.addMealAdminBtn.Click += new System.EventHandler(this.AddMeal_Click);
            // 
            // viewStatsAdminBtn
            // 
            this.viewStatsAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatsAdminBtn.Location = new System.Drawing.Point(19, 294);
            this.viewStatsAdminBtn.Margin = new System.Windows.Forms.Padding(6);
            this.viewStatsAdminBtn.Name = "viewStatsAdminBtn";
            this.viewStatsAdminBtn.Size = new System.Drawing.Size(342, 57);
            this.viewStatsAdminBtn.TabIndex = 2;
            this.viewStatsAdminBtn.Text = "View Statistics";
            this.viewStatsAdminBtn.UseVisualStyleBackColor = true;
            this.viewStatsAdminBtn.Click += new System.EventHandler(this.ViewStatsButton_Click);
            // 
            // custViewAdminBtn
            // 
            this.custViewAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custViewAdminBtn.Location = new System.Drawing.Point(16, 16);
            this.custViewAdminBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.custViewAdminBtn.Name = "custViewAdminBtn";
            this.custViewAdminBtn.Size = new System.Drawing.Size(345, 62);
            this.custViewAdminBtn.TabIndex = 3;
            this.custViewAdminBtn.Text = "Go to Customer view";
            this.custViewAdminBtn.UseVisualStyleBackColor = true;
            this.custViewAdminBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAdminAccBtn
            // 
            this.addAdminAccBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminAccBtn.Location = new System.Drawing.Point(19, 432);
            this.addAdminAccBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addAdminAccBtn.Name = "addAdminAccBtn";
            this.addAdminAccBtn.Size = new System.Drawing.Size(342, 57);
            this.addAdminAccBtn.TabIndex = 4;
            this.addAdminAccBtn.Text = "Add Admin Account";
            this.addAdminAccBtn.UseVisualStyleBackColor = true;
            this.addAdminAccBtn.Click += new System.EventHandler(this.btnAddAdminAcc_Click);
            // 
            // modifyStockBtn
            // 
            this.modifyStockBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyStockBtn.Location = new System.Drawing.Point(19, 363);
            this.modifyStockBtn.Margin = new System.Windows.Forms.Padding(6);
            this.modifyStockBtn.Name = "modifyStockBtn";
            this.modifyStockBtn.Size = new System.Drawing.Size(342, 57);
            this.modifyStockBtn.TabIndex = 5;
            this.modifyStockBtn.Text = "Modify Stock";
            this.modifyStockBtn.UseVisualStyleBackColor = true;
            this.modifyStockBtn.Click += new System.EventHandler(this.modifyStockBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove Meals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Meals";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifyStockBtn);
            this.Controls.Add(this.addAdminAccBtn);
            this.Controls.Add(this.custViewAdminBtn);
            this.Controls.Add(this.viewStatsAdminBtn);
            this.Controls.Add(this.addMealAdminBtn);
            this.Controls.Add(this.logoutAdminBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutAdminBtn;
        private System.Windows.Forms.Button addMealAdminBtn;
        private System.Windows.Forms.Button viewStatsAdminBtn;
        private System.Windows.Forms.Button custViewAdminBtn;
        private System.Windows.Forms.Button addAdminAccBtn;
        private System.Windows.Forms.Button modifyStockBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}