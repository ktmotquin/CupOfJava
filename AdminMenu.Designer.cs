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
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(445, 350);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(70, 26);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AddMeal
            // 
            this.AddMeal.Location = new System.Drawing.Point(12, 12);
            this.AddMeal.Name = "AddMeal";
            this.AddMeal.Size = new System.Drawing.Size(75, 23);
            this.AddMeal.TabIndex = 1;
            this.AddMeal.Text = "Add Meal";
            this.AddMeal.UseVisualStyleBackColor = true;
            this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 388);
            this.Controls.Add(this.AddMeal);
            this.Controls.Add(this.Logout);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AddMeal;
    }
}