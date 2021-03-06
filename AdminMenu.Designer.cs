﻿namespace OOAD_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.logoutAdminBtn = new System.Windows.Forms.Button();
            this.addMealAdminBtn = new System.Windows.Forms.Button();
            this.viewStatsAdminBtn = new System.Windows.Forms.Button();
            this.custViewAdminBtn = new System.Windows.Forms.Button();
            this.addAdminAccBtn = new System.Windows.Forms.Button();
            this.modifyStockBtn = new System.Windows.Forms.Button();
            this.ApproveMealRequests = new System.Windows.Forms.Button();
            this.btnEditMeal = new System.Windows.Forms.Button();
            this.btnRemoveMeals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutAdminBtn
            // 
            this.logoutAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutAdminBtn.Location = new System.Drawing.Point(12, 311);
            this.logoutAdminBtn.Name = "logoutAdminBtn";
            this.logoutAdminBtn.Size = new System.Drawing.Size(188, 31);
            this.logoutAdminBtn.TabIndex = 0;
            this.logoutAdminBtn.Text = "Logout";
            this.logoutAdminBtn.UseVisualStyleBackColor = true;
            this.logoutAdminBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addMealAdminBtn
            // 
            this.addMealAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealAdminBtn.Location = new System.Drawing.Point(12, 49);
            this.addMealAdminBtn.Name = "addMealAdminBtn";
            this.addMealAdminBtn.Size = new System.Drawing.Size(188, 31);
            this.addMealAdminBtn.TabIndex = 1;
            this.addMealAdminBtn.Text = "Add Meal";
            this.addMealAdminBtn.UseVisualStyleBackColor = true;
            this.addMealAdminBtn.Click += new System.EventHandler(this.AddMeal_Click);
            // 
            // viewStatsAdminBtn
            // 
            this.viewStatsAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatsAdminBtn.Location = new System.Drawing.Point(12, 198);
            this.viewStatsAdminBtn.Name = "viewStatsAdminBtn";
            this.viewStatsAdminBtn.Size = new System.Drawing.Size(188, 31);
            this.viewStatsAdminBtn.TabIndex = 2;
            this.viewStatsAdminBtn.Text = "View Statistics";
            this.viewStatsAdminBtn.UseVisualStyleBackColor = true;
            this.viewStatsAdminBtn.Click += new System.EventHandler(this.ViewStatsButton_Click);
            // 
            // custViewAdminBtn
            // 
            this.custViewAdminBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custViewAdminBtn.Location = new System.Drawing.Point(12, 11);
            this.custViewAdminBtn.Margin = new System.Windows.Forms.Padding(2);
            this.custViewAdminBtn.Name = "custViewAdminBtn";
            this.custViewAdminBtn.Size = new System.Drawing.Size(188, 33);
            this.custViewAdminBtn.TabIndex = 3;
            this.custViewAdminBtn.Text = "Go to Customer view";
            this.custViewAdminBtn.UseVisualStyleBackColor = true;
            this.custViewAdminBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAdminAccBtn
            // 
            this.addAdminAccBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminAccBtn.Location = new System.Drawing.Point(12, 273);
            this.addAdminAccBtn.Name = "addAdminAccBtn";
            this.addAdminAccBtn.Size = new System.Drawing.Size(188, 31);
            this.addAdminAccBtn.TabIndex = 4;
            this.addAdminAccBtn.Text = "Add Admin Account";
            this.addAdminAccBtn.UseVisualStyleBackColor = true;
            this.addAdminAccBtn.Click += new System.EventHandler(this.btnAddAdminAcc_Click);
            // 
            // modifyStockBtn
            // 
            this.modifyStockBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyStockBtn.Location = new System.Drawing.Point(12, 235);
            this.modifyStockBtn.Name = "modifyStockBtn";
            this.modifyStockBtn.Size = new System.Drawing.Size(188, 31);
            this.modifyStockBtn.TabIndex = 5;
            this.modifyStockBtn.Text = "Modify Stock";
            this.modifyStockBtn.UseVisualStyleBackColor = true;
            this.modifyStockBtn.Click += new System.EventHandler(this.modifyStockBtn_Click);
            // 
            // ApproveMealRequests
            // 
            this.ApproveMealRequests.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.ApproveMealRequests.Location = new System.Drawing.Point(12, 86);
            this.ApproveMealRequests.Name = "ApproveMealRequests";
            this.ApproveMealRequests.Size = new System.Drawing.Size(188, 31);
            this.ApproveMealRequests.TabIndex = 6;
            this.ApproveMealRequests.Text = "Approve Meal Requests";
            this.ApproveMealRequests.UseVisualStyleBackColor = true;
            this.ApproveMealRequests.Click += new System.EventHandler(this.ApproveMealRequests_Click);
            // 
            // btnEditMeal
            // 
            this.btnEditMeal.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btnEditMeal.Location = new System.Drawing.Point(14, 161);
            this.btnEditMeal.Name = "btnEditMeal";
            this.btnEditMeal.Size = new System.Drawing.Size(188, 31);
            this.btnEditMeal.TabIndex = 7;
            this.btnEditMeal.Text = "Edit Meals";
            this.btnEditMeal.UseVisualStyleBackColor = true;
            this.btnEditMeal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveMeals
            // 
            this.btnRemoveMeals.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btnRemoveMeals.Location = new System.Drawing.Point(14, 123);
            this.btnRemoveMeals.Name = "btnRemoveMeals";
            this.btnRemoveMeals.Size = new System.Drawing.Size(188, 31);
            this.btnRemoveMeals.TabIndex = 8;
            this.btnRemoveMeals.Text = "Remove Meals";
            this.btnRemoveMeals.UseVisualStyleBackColor = true;
            this.btnRemoveMeals.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 357);
            this.Controls.Add(this.btnRemoveMeals);
            this.Controls.Add(this.btnEditMeal);
            this.Controls.Add(this.ApproveMealRequests);
            this.Controls.Add(this.modifyStockBtn);
            this.Controls.Add(this.addAdminAccBtn);
            this.Controls.Add(this.custViewAdminBtn);
            this.Controls.Add(this.viewStatsAdminBtn);
            this.Controls.Add(this.addMealAdminBtn);
            this.Controls.Add(this.logoutAdminBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(231, 396);
            this.MinimumSize = new System.Drawing.Size(231, 396);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutAdminBtn;
        private System.Windows.Forms.Button addMealAdminBtn;
        private System.Windows.Forms.Button viewStatsAdminBtn;
        private System.Windows.Forms.Button custViewAdminBtn;
        private System.Windows.Forms.Button addAdminAccBtn;
        private System.Windows.Forms.Button modifyStockBtn;
        private System.Windows.Forms.Button ApproveMealRequests;
        private System.Windows.Forms.Button btnEditMeal;
        private System.Windows.Forms.Button btnRemoveMeals;
    }
}