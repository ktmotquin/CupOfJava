namespace OOAD_Project
{
    partial class StatsPage
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.toAdminMenuBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(1, 4);
         this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(337, 517);
         this.dataGridView1.TabIndex = 0;
         // 
         // toAdminMenuBtn
         // 
         this.toAdminMenuBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.toAdminMenuBtn.Location = new System.Drawing.Point(666, 12);
         this.toAdminMenuBtn.Name = "toAdminMenuBtn";
         this.toAdminMenuBtn.Size = new System.Drawing.Size(170, 57);
         this.toAdminMenuBtn.TabIndex = 1;
         this.toAdminMenuBtn.Text = "Admin Menu";
         this.toAdminMenuBtn.UseVisualStyleBackColor = true;
         this.toAdminMenuBtn.Click += new System.EventHandler(this.toAdminMenuBtn_Click);
         // 
         // StatsPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(848, 535);
         this.Controls.Add(this.toAdminMenuBtn);
         this.Controls.Add(this.dataGridView1);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "StatsPage";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "StatsPage";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button toAdminMenuBtn;
   }
}