namespace OOAD_Project
{
   partial class Cart
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
         this.Subtotal = new System.Windows.Forms.Label();
         this.taxlabel = new System.Windows.Forms.Label();
         this.totalLabel = new System.Windows.Forms.Label();
         this.SubtotalBox = new System.Windows.Forms.TextBox();
         this.TaxBox = new System.Windows.Forms.TextBox();
         this.TotalBox = new System.Windows.Forms.TextBox();
         this.CheckoutButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.CartList = new System.Windows.Forms.CheckedListBox();
         this.RemoveButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Subtotal
         // 
         this.Subtotal.AutoSize = true;
         this.Subtotal.Location = new System.Drawing.Point(392, 310);
         this.Subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.Subtotal.Name = "Subtotal";
         this.Subtotal.Size = new System.Drawing.Size(64, 17);
         this.Subtotal.TabIndex = 0;
         this.Subtotal.Text = "Subtotal:";
         // 
         // taxlabel
         // 
         this.taxlabel.AutoSize = true;
         this.taxlabel.Location = new System.Drawing.Point(412, 342);
         this.taxlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.taxlabel.Name = "taxlabel";
         this.taxlabel.Size = new System.Drawing.Size(35, 17);
         this.taxlabel.TabIndex = 1;
         this.taxlabel.Text = "Tax:";
         // 
         // totalLabel
         // 
         this.totalLabel.AutoSize = true;
         this.totalLabel.Location = new System.Drawing.Point(412, 374);
         this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.totalLabel.Name = "totalLabel";
         this.totalLabel.Size = new System.Drawing.Size(44, 17);
         this.totalLabel.TabIndex = 2;
         this.totalLabel.Text = "Total:";
         // 
         // SubtotalBox
         // 
         this.SubtotalBox.Location = new System.Drawing.Point(465, 306);
         this.SubtotalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.SubtotalBox.Name = "SubtotalBox";
         this.SubtotalBox.Size = new System.Drawing.Size(132, 22);
         this.SubtotalBox.TabIndex = 3;
         // 
         // TaxBox
         // 
         this.TaxBox.Location = new System.Drawing.Point(465, 338);
         this.TaxBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.TaxBox.Name = "TaxBox";
         this.TaxBox.Size = new System.Drawing.Size(132, 22);
         this.TaxBox.TabIndex = 4;
         // 
         // TotalBox
         // 
         this.TotalBox.Location = new System.Drawing.Point(465, 370);
         this.TotalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.TotalBox.Name = "TotalBox";
         this.TotalBox.Size = new System.Drawing.Size(132, 22);
         this.TotalBox.TabIndex = 5;
         // 
         // CheckoutButton
         // 
         this.CheckoutButton.Location = new System.Drawing.Point(499, 426);
         this.CheckoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.CheckoutButton.Name = "CheckoutButton";
         this.CheckoutButton.Size = new System.Drawing.Size(100, 28);
         this.CheckoutButton.TabIndex = 6;
         this.CheckoutButton.Text = "Checkout";
         this.CheckoutButton.UseVisualStyleBackColor = true;
         this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(16, 48);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(130, 17);
         this.label1.TabIndex = 8;
         this.label1.Text = "Your Current Items:";
         // 
         // CartList
         // 
         this.CartList.FormattingEnabled = true;
         this.CartList.Location = new System.Drawing.Point(20, 76);
         this.CartList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.CartList.Name = "CartList";
         this.CartList.Size = new System.Drawing.Size(347, 310);
         this.CartList.TabIndex = 9;
         // 
         // RemoveButton
         // 
         this.RemoveButton.Location = new System.Drawing.Point(20, 426);
         this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.RemoveButton.Name = "RemoveButton";
         this.RemoveButton.Size = new System.Drawing.Size(180, 28);
         this.RemoveButton.TabIndex = 10;
         this.RemoveButton.Text = "Remove Selected Items";
         this.RemoveButton.UseVisualStyleBackColor = true;
         this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
         // 
         // Cart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(615, 469);
         this.Controls.Add(this.RemoveButton);
         this.Controls.Add(this.CartList);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.CheckoutButton);
         this.Controls.Add(this.TotalBox);
         this.Controls.Add(this.TaxBox);
         this.Controls.Add(this.SubtotalBox);
         this.Controls.Add(this.totalLabel);
         this.Controls.Add(this.taxlabel);
         this.Controls.Add(this.Subtotal);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Cart";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cart";
         this.Activated += new System.EventHandler(this.Cart_Activated);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Subtotal;
      private System.Windows.Forms.Label taxlabel;
      private System.Windows.Forms.Label totalLabel;
      private System.Windows.Forms.TextBox SubtotalBox;
      private System.Windows.Forms.TextBox TaxBox;
      private System.Windows.Forms.TextBox TotalBox;
      private System.Windows.Forms.Button CheckoutButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.CheckedListBox CartList;
      private System.Windows.Forms.Button RemoveButton;
   }
}