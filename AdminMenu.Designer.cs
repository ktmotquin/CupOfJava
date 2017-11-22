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
         this.logoutAdminButton = new System.Windows.Forms.Button();
         this.addMealAdminButton = new System.Windows.Forms.Button();
         this.viewStatsAdminButton = new System.Windows.Forms.Button();
         this.goToCustViewAdminButton = new System.Windows.Forms.Button();
         this.btnAddAdminAcc = new System.Windows.Forms.Button();
         this.modifyStockBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // logoutAdminButton
         // 
         this.logoutAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.logoutAdminButton.Location = new System.Drawing.Point(13, 242);
         this.logoutAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.logoutAdminButton.Name = "logoutAdminButton";
         this.logoutAdminButton.Size = new System.Drawing.Size(249, 38);
         this.logoutAdminButton.TabIndex = 0;
         this.logoutAdminButton.Text = "Logout";
         this.logoutAdminButton.UseVisualStyleBackColor = true;
         this.logoutAdminButton.Click += new System.EventHandler(this.Logout_Click);
         // 
         // addMealAdminButton
         // 
         this.addMealAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addMealAdminButton.Location = new System.Drawing.Point(13, 58);
         this.addMealAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.addMealAdminButton.Name = "addMealAdminButton";
         this.addMealAdminButton.Size = new System.Drawing.Size(249, 38);
         this.addMealAdminButton.TabIndex = 1;
         this.addMealAdminButton.Text = "Add Meal";
         this.addMealAdminButton.UseVisualStyleBackColor = true;
         this.addMealAdminButton.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // viewStatsAdminButton
         // 
         this.viewStatsAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewStatsAdminButton.Location = new System.Drawing.Point(13, 104);
         this.viewStatsAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.viewStatsAdminButton.Name = "viewStatsAdminButton";
         this.viewStatsAdminButton.Size = new System.Drawing.Size(249, 38);
         this.viewStatsAdminButton.TabIndex = 2;
         this.viewStatsAdminButton.Text = "View Statistics";
         this.viewStatsAdminButton.UseVisualStyleBackColor = true;
         this.viewStatsAdminButton.Click += new System.EventHandler(this.ViewStatsButton_Click);
         // 
         // goToCustViewAdminButton
         // 
         this.goToCustViewAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.goToCustViewAdminButton.Location = new System.Drawing.Point(12, 11);
         this.goToCustViewAdminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.goToCustViewAdminButton.Name = "goToCustViewAdminButton";
         this.goToCustViewAdminButton.Size = new System.Drawing.Size(251, 41);
         this.goToCustViewAdminButton.TabIndex = 3;
         this.goToCustViewAdminButton.Text = "Go to Customer view";
         this.goToCustViewAdminButton.UseVisualStyleBackColor = true;
         this.goToCustViewAdminButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnAddAdminAcc
         // 
         this.btnAddAdminAcc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddAdminAcc.Location = new System.Drawing.Point(13, 196);
         this.btnAddAdminAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnAddAdminAcc.Name = "btnAddAdminAcc";
         this.btnAddAdminAcc.Size = new System.Drawing.Size(249, 38);
         this.btnAddAdminAcc.TabIndex = 4;
         this.btnAddAdminAcc.Text = "Add Admin Account";
         this.btnAddAdminAcc.UseVisualStyleBackColor = true;
         this.btnAddAdminAcc.Click += new System.EventHandler(this.btnAddAdminAcc_Click);
         // 
         // modifyStockBtn
         // 
         this.modifyStockBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.modifyStockBtn.Location = new System.Drawing.Point(13, 150);
         this.modifyStockBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.modifyStockBtn.Name = "modifyStockBtn";
         this.modifyStockBtn.Size = new System.Drawing.Size(249, 38);
         this.modifyStockBtn.TabIndex = 5;
         this.modifyStockBtn.Text = "Modify Stock";
         this.modifyStockBtn.UseVisualStyleBackColor = true;
         this.modifyStockBtn.Click += new System.EventHandler(this.modifyStockBtn_Click);
         // 
         // AdminMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(279, 298);
         this.Controls.Add(this.modifyStockBtn);
         this.Controls.Add(this.btnAddAdminAcc);
         this.Controls.Add(this.goToCustViewAdminButton);
         this.Controls.Add(this.viewStatsAdminButton);
         this.Controls.Add(this.addMealAdminButton);
         this.Controls.Add(this.logoutAdminButton);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "AdminMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminMenu";
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutAdminButton;
        private System.Windows.Forms.Button addMealAdminButton;
        private System.Windows.Forms.Button viewStatsAdminButton;
        private System.Windows.Forms.Button goToCustViewAdminButton;
        private System.Windows.Forms.Button btnAddAdminAcc;
        private System.Windows.Forms.Button modifyStockBtn;
    }
}