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
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.itemTxtBox = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(65, 56);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(149, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(227, 50);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(25, 9);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(129, 23);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "Add a new item";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Location = new System.Drawing.Point(65, 88);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(149, 20);
            this.quantityTxtBox.TabIndex = 3;
            // 
            // itemTxtBox
            // 
            this.itemTxtBox.AutoSize = true;
            this.itemTxtBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTxtBox.Location = new System.Drawing.Point(7, 59);
            this.itemTxtBox.Name = "itemTxtBox";
            this.itemTxtBox.Size = new System.Drawing.Size(35, 14);
            this.itemTxtBox.TabIndex = 4;
            this.itemTxtBox.Text = "Item ";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(4, 94);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(55, 14);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Quantity ";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 139);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.itemTxtBox);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addTextBox);
            this.Name = "AddStock";
            this.Text = "AddItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label itemTxtBox;
        private System.Windows.Forms.Label numberLabel;
    }
}