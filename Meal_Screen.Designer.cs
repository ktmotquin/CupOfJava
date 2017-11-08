namespace OOAD_Project
{
    partial class Meal_Screen
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
            this.itemIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemIndex
            // 
            this.itemIndex.Location = new System.Drawing.Point(87, 53);
            this.itemIndex.Name = "itemIndex";
            this.itemIndex.Size = new System.Drawing.Size(100, 31);
            this.itemIndex.TabIndex = 0;
            // 
            // Meal_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 733);
            this.Controls.Add(this.itemIndex);
            this.Name = "Meal_Screen";
            this.Text = "Meal_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIndex;
    }
}