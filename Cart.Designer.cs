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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // Subtotal
         // 
         this.Subtotal.AutoSize = true;
         this.Subtotal.Location = new System.Drawing.Point(299, 297);
         this.Subtotal.Name = "Subtotal";
         this.Subtotal.Size = new System.Drawing.Size(49, 13);
         this.Subtotal.TabIndex = 0;
         this.Subtotal.Text = "Subtotal:";
         // 
         // taxlabel
         // 
         this.taxlabel.AutoSize = true;
         this.taxlabel.Location = new System.Drawing.Point(320, 318);
         this.taxlabel.Name = "taxlabel";
         this.taxlabel.Size = new System.Drawing.Size(28, 13);
         this.taxlabel.TabIndex = 1;
         this.taxlabel.Text = "Tax:";
         // 
         // totalLabel
         // 
         this.totalLabel.AutoSize = true;
         this.totalLabel.Location = new System.Drawing.Point(314, 338);
         this.totalLabel.Name = "totalLabel";
         this.totalLabel.Size = new System.Drawing.Size(34, 13);
         this.totalLabel.TabIndex = 2;
         this.totalLabel.Text = "Total:";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(387, 297);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 3;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(387, 318);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(100, 20);
         this.textBox2.TabIndex = 4;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(387, 338);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(100, 20);
         this.textBox3.TabIndex = 5;
         // 
         // Cart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(461, 381);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.totalLabel);
         this.Controls.Add(this.taxlabel);
         this.Controls.Add(this.Subtotal);
         this.Name = "Cart";
         this.Text = "Cart";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Subtotal;
      private System.Windows.Forms.Label taxlabel;
      private System.Windows.Forms.Label totalLabel;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox3;
   }
}