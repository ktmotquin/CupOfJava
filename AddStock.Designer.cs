namespace OOAD_Project
{
    partial class AddStock
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
         this.addTextBox = new System.Windows.Forms.TextBox();
         this.addBtn = new System.Windows.Forms.Button();
         this.addLabel = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.UpdateLabel = new System.Windows.Forms.Label();
         this.adminMenuBtn = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // addTextBox
         // 
         this.addTextBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addTextBox.Location = new System.Drawing.Point(18, 42);
         this.addTextBox.Margin = new System.Windows.Forms.Padding(4);
         this.addTextBox.Name = "addTextBox";
         this.addTextBox.Size = new System.Drawing.Size(247, 36);
         this.addTextBox.TabIndex = 0;
         // 
         // addBtn
         // 
         this.addBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addBtn.Location = new System.Drawing.Point(273, 42);
         this.addBtn.Margin = new System.Windows.Forms.Padding(4);
         this.addBtn.Name = "addBtn";
         this.addBtn.Size = new System.Drawing.Size(116, 36);
         this.addBtn.TabIndex = 1;
         this.addBtn.Text = "Add";
         this.addBtn.UseVisualStyleBackColor = true;
         // 
         // addLabel
         // 
         this.addLabel.AutoSize = true;
         this.addLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addLabel.Location = new System.Drawing.Point(13, 9);
         this.addLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.addLabel.Name = "addLabel";
         this.addLabel.Size = new System.Drawing.Size(167, 29);
         this.addLabel.TabIndex = 2;
         this.addLabel.Text = "Add a new item";
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(18, 115);
         this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(371, 220);
         this.dataGridView1.TabIndex = 3;
         // 
         // UpdateLabel
         // 
         this.UpdateLabel.AutoSize = true;
         this.UpdateLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.UpdateLabel.Location = new System.Drawing.Point(13, 82);
         this.UpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.UpdateLabel.Name = "UpdateLabel";
         this.UpdateLabel.Size = new System.Drawing.Size(221, 29);
         this.UpdateLabel.TabIndex = 4;
         this.UpdateLabel.Text = "Update existing stock";
         // 
         // adminMenuBtn
         // 
         this.adminMenuBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.adminMenuBtn.Location = new System.Drawing.Point(18, 342);
         this.adminMenuBtn.Name = "adminMenuBtn";
         this.adminMenuBtn.Size = new System.Drawing.Size(175, 52);
         this.adminMenuBtn.TabIndex = 5;
         this.adminMenuBtn.Text = "Admin Menu";
         this.adminMenuBtn.UseVisualStyleBackColor = true;
         this.adminMenuBtn.Click += new System.EventHandler(this.button1_Click);
         // 
         // AddStock
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(403, 406);
         this.Controls.Add(this.adminMenuBtn);
         this.Controls.Add(this.UpdateLabel);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.addLabel);
         this.Controls.Add(this.addBtn);
         this.Controls.Add(this.addTextBox);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "AddStock";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AddItems";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UpdateLabel;
      private System.Windows.Forms.Button adminMenuBtn;
   }
}