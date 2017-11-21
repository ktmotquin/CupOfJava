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
         this.SuspendLayout();
         // 
         // logoutAdminButton
         // 
         this.logoutAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.logoutAdminButton.Location = new System.Drawing.Point(12, 153);
         this.logoutAdminButton.Margin = new System.Windows.Forms.Padding(4);
         this.logoutAdminButton.Name = "logoutAdminButton";
         this.logoutAdminButton.Size = new System.Drawing.Size(249, 39);
         this.logoutAdminButton.TabIndex = 0;
         this.logoutAdminButton.Text = "Logout";
         this.logoutAdminButton.UseVisualStyleBackColor = true;
         this.logoutAdminButton.Click += new System.EventHandler(this.Logout_Click);
         // 
         // addMealAdminButton
         // 
         this.addMealAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addMealAdminButton.Location = new System.Drawing.Point(13, 59);
         this.addMealAdminButton.Margin = new System.Windows.Forms.Padding(4);
         this.addMealAdminButton.Name = "addMealAdminButton";
         this.addMealAdminButton.Size = new System.Drawing.Size(249, 39);
         this.addMealAdminButton.TabIndex = 1;
         this.addMealAdminButton.Text = "Add Meal";
         this.addMealAdminButton.UseVisualStyleBackColor = true;
         this.addMealAdminButton.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // viewStatsAdminButton
         // 
         this.viewStatsAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewStatsAdminButton.Location = new System.Drawing.Point(13, 106);
         this.viewStatsAdminButton.Margin = new System.Windows.Forms.Padding(4);
         this.viewStatsAdminButton.Name = "viewStatsAdminButton";
         this.viewStatsAdminButton.Size = new System.Drawing.Size(249, 39);
         this.viewStatsAdminButton.TabIndex = 2;
         this.viewStatsAdminButton.Text = "View Statistics";
         this.viewStatsAdminButton.UseVisualStyleBackColor = true;
         this.viewStatsAdminButton.Click += new System.EventHandler(this.ViewStatsButton_Click);
         // 
         // goToCustViewAdminButton
         // 
         this.goToCustViewAdminButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.goToCustViewAdminButton.Location = new System.Drawing.Point(12, 12);
         this.goToCustViewAdminButton.Name = "goToCustViewAdminButton";
         this.goToCustViewAdminButton.Size = new System.Drawing.Size(250, 40);
         this.goToCustViewAdminButton.TabIndex = 3;
         this.goToCustViewAdminButton.Text = "Go to Customer view";
         this.goToCustViewAdminButton.UseVisualStyleBackColor = true;
         this.goToCustViewAdminButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // AdminMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(278, 206);
         this.Controls.Add(this.goToCustViewAdminButton);
         this.Controls.Add(this.viewStatsAdminButton);
         this.Controls.Add(this.addMealAdminButton);
         this.Controls.Add(this.logoutAdminButton);
         this.Margin = new System.Windows.Forms.Padding(4);
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
   }
}