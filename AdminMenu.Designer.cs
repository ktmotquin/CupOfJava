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
         this.Logout = new System.Windows.Forms.Button();
         this.AddMeal = new System.Windows.Forms.Button();
         this.ViewStatsButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Logout
         // 
         this.Logout.Location = new System.Drawing.Point(593, 431);
         this.Logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Logout.Name = "Logout";
         this.Logout.Size = new System.Drawing.Size(93, 32);
         this.Logout.TabIndex = 0;
         this.Logout.Text = "Logout";
         this.Logout.UseVisualStyleBackColor = true;
         this.Logout.Click += new System.EventHandler(this.Logout_Click);
         // 
         // AddMeal
         // 
         this.AddMeal.Location = new System.Drawing.Point(16, 15);
         this.AddMeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.AddMeal.Name = "AddMeal";
         this.AddMeal.Size = new System.Drawing.Size(100, 28);
         this.AddMeal.TabIndex = 1;
         this.AddMeal.Text = "Add Meal";
         this.AddMeal.UseVisualStyleBackColor = true;
         this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // ViewStatsButton
         // 
         this.ViewStatsButton.Location = new System.Drawing.Point(560, 15);
         this.ViewStatsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.ViewStatsButton.Name = "ViewStatsButton";
         this.ViewStatsButton.Size = new System.Drawing.Size(100, 28);
         this.ViewStatsButton.TabIndex = 2;
         this.ViewStatsButton.Text = "View Stats";
         this.ViewStatsButton.UseVisualStyleBackColor = true;
         this.ViewStatsButton.Click += new System.EventHandler(this.ViewStatsButton_Click);
         // 
         // AdminMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(703, 478);
         this.Controls.Add(this.ViewStatsButton);
         this.Controls.Add(this.AddMeal);
         this.Controls.Add(this.Logout);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "AdminMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminMenu";
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AddMeal;
        private System.Windows.Forms.Button ViewStatsButton;
    }
}