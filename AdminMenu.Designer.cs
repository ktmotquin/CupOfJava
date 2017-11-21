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
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Logout
         // 
         this.Logout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Logout.Location = new System.Drawing.Point(12, 153);
         this.Logout.Margin = new System.Windows.Forms.Padding(4);
         this.Logout.Name = "Logout";
         this.Logout.Size = new System.Drawing.Size(249, 39);
         this.Logout.TabIndex = 0;
         this.Logout.Text = "Logout";
         this.Logout.UseVisualStyleBackColor = true;
         this.Logout.Click += new System.EventHandler(this.Logout_Click);
         // 
         // AddMeal
         // 
         this.AddMeal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.AddMeal.Location = new System.Drawing.Point(13, 59);
         this.AddMeal.Margin = new System.Windows.Forms.Padding(4);
         this.AddMeal.Name = "AddMeal";
         this.AddMeal.Size = new System.Drawing.Size(249, 39);
         this.AddMeal.TabIndex = 1;
         this.AddMeal.Text = "Add Meal";
         this.AddMeal.UseVisualStyleBackColor = true;
         this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // ViewStatsButton
         // 
         this.ViewStatsButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ViewStatsButton.Location = new System.Drawing.Point(13, 106);
         this.ViewStatsButton.Margin = new System.Windows.Forms.Padding(4);
         this.ViewStatsButton.Name = "ViewStatsButton";
         this.ViewStatsButton.Size = new System.Drawing.Size(249, 39);
         this.ViewStatsButton.TabIndex = 2;
         this.ViewStatsButton.Text = "View Statistics";
         this.ViewStatsButton.UseVisualStyleBackColor = true;
         this.ViewStatsButton.Click += new System.EventHandler(this.ViewStatsButton_Click);
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(12, 12);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(250, 40);
         this.button1.TabIndex = 3;
         this.button1.Text = "Go to Customer view";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // AdminMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(278, 206);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.ViewStatsButton);
         this.Controls.Add(this.AddMeal);
         this.Controls.Add(this.Logout);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "AdminMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminMenu";
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AddMeal;
        private System.Windows.Forms.Button ViewStatsButton;
      private System.Windows.Forms.Button button1;
   }
}