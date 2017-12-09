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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
         this.CheckoutButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.CartList = new System.Windows.Forms.CheckedListBox();
         this.RemoveButton = new System.Windows.Forms.Button();
         this.countBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.remainingMeals = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // CheckoutButton
         // 
         this.CheckoutButton.Font = new System.Drawing.Font("Calibri", 13.8F);
         this.CheckoutButton.Location = new System.Drawing.Point(12, 288);
         this.CheckoutButton.Name = "CheckoutButton";
         this.CheckoutButton.Size = new System.Drawing.Size(92, 33);
         this.CheckoutButton.TabIndex = 6;
         this.CheckoutButton.Text = "Checkout";
         this.CheckoutButton.UseVisualStyleBackColor = true;
         this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(152, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(86, 23);
         this.label1.TabIndex = 8;
         this.label1.Text = "Your Cart:";
         // 
         // CartList
         // 
         this.CartList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.CartList.FormattingEnabled = true;
         this.CartList.Location = new System.Drawing.Point(12, 80);
         this.CartList.Name = "CartList";
         this.CartList.Size = new System.Drawing.Size(289, 202);
         this.CartList.TabIndex = 9;
         // 
         // RemoveButton
         // 
         this.RemoveButton.Font = new System.Drawing.Font("Calibri", 13.8F);
         this.RemoveButton.Location = new System.Drawing.Point(209, 288);
         this.RemoveButton.Name = "RemoveButton";
         this.RemoveButton.Size = new System.Drawing.Size(92, 33);
         this.RemoveButton.TabIndex = 10;
         this.RemoveButton.Text = "Remove Selected Items";
         this.RemoveButton.UseVisualStyleBackColor = true;
         this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
         // 
         // countBox
         // 
         this.countBox.Enabled = false;
         this.countBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.countBox.Location = new System.Drawing.Point(244, 12);
         this.countBox.Name = "countBox";
         this.countBox.Size = new System.Drawing.Size(57, 23);
         this.countBox.TabIndex = 11;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(93, 51);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(145, 23);
         this.label3.TabIndex = 13;
         this.label3.Text = "Meals Remaining:";
         // 
         // remainingMeals
         // 
         this.remainingMeals.Enabled = false;
         this.remainingMeals.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.remainingMeals.Location = new System.Drawing.Point(244, 51);
         this.remainingMeals.Name = "remainingMeals";
         this.remainingMeals.Size = new System.Drawing.Size(57, 23);
         this.remainingMeals.TabIndex = 14;
         // 
         // Cart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(318, 332);
         this.Controls.Add(this.remainingMeals);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.countBox);
         this.Controls.Add(this.RemoveButton);
         this.Controls.Add(this.CartList);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.CheckoutButton);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Cart";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Cart";
         this.Load += new System.EventHandler(this.Cart_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button CheckoutButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.CheckedListBox CartList;
      private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remainingMeals;
    }
}