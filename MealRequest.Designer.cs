namespace OOAD_Project
{
    partial class MealRequest
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealRequest));
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.btnImage = new System.Windows.Forms.Button();
         this.Cancel = new System.Windows.Forms.Button();
         this.AddMeal = new System.Windows.Forms.Button();
         this.Ingredients = new System.Windows.Forms.TextBox();
         this.Description = new System.Windows.Forms.TextBox();
         this.MealName = new System.Windows.Forms.TextBox();
         this.imgfile = new System.Windows.Forms.TextBox();
         this.Instructions = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // comboBox1
         // 
         this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.comboBox1.Items.AddRange(new object[] {
            "Pasta",
            "Salad",
            "Dessert",
            "Sandwich",
            "Soup",
            "Bakes",
            "Appetizers",
            "Tortilla Based",
            "Rice Based"});
         this.comboBox1.Location = new System.Drawing.Point(152, 55);
         this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(355, 36);
         this.comboBox1.TabIndex = 39;
         // 
         // btnImage
         // 
         this.btnImage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnImage.Location = new System.Drawing.Point(293, 100);
         this.btnImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnImage.Name = "btnImage";
         this.btnImage.Size = new System.Drawing.Size(215, 36);
         this.btnImage.TabIndex = 38;
         this.btnImage.Text = "Image Help";
         this.btnImage.UseVisualStyleBackColor = true;
         this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
         // 
         // Cancel
         // 
         this.Cancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Cancel.Location = new System.Drawing.Point(260, 609);
         this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Cancel.Name = "Cancel";
         this.Cancel.Size = new System.Drawing.Size(100, 38);
         this.Cancel.TabIndex = 37;
         this.Cancel.Text = "Cancel";
         this.Cancel.UseVisualStyleBackColor = true;
         this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
         // 
         // AddMeal
         // 
         this.AddMeal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.AddMeal.Location = new System.Drawing.Point(152, 609);
         this.AddMeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.AddMeal.Name = "AddMeal";
         this.AddMeal.Size = new System.Drawing.Size(100, 38);
         this.AddMeal.TabIndex = 36;
         this.AddMeal.Text = "Add Meal";
         this.AddMeal.UseVisualStyleBackColor = true;
         this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // Ingredients
         // 
         this.Ingredients.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Ingredients.Location = new System.Drawing.Point(152, 432);
         this.Ingredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Ingredients.Multiline = true;
         this.Ingredients.Name = "Ingredients";
         this.Ingredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Ingredients.Size = new System.Drawing.Size(783, 170);
         this.Ingredients.TabIndex = 34;
         // 
         // Description
         // 
         this.Description.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Description.Location = new System.Drawing.Point(152, 293);
         this.Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Description.Multiline = true;
         this.Description.Name = "Description";
         this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Description.Size = new System.Drawing.Size(783, 131);
         this.Description.TabIndex = 32;
         // 
         // MealName
         // 
         this.MealName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MealName.Location = new System.Drawing.Point(152, 12);
         this.MealName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.MealName.Name = "MealName";
         this.MealName.Size = new System.Drawing.Size(783, 36);
         this.MealName.TabIndex = 25;
         // 
         // imgfile
         // 
         this.imgfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.imgfile.Location = new System.Drawing.Point(152, 100);
         this.imgfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.imgfile.Name = "imgfile";
         this.imgfile.Size = new System.Drawing.Size(132, 36);
         this.imgfile.TabIndex = 28;
         // 
         // Instructions
         // 
         this.Instructions.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Instructions.Location = new System.Drawing.Point(152, 144);
         this.Instructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Instructions.Multiline = true;
         this.Instructions.Name = "Instructions";
         this.Instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Instructions.Size = new System.Drawing.Size(783, 141);
         this.Instructions.TabIndex = 30;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(5, 144);
         this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(139, 29);
         this.label9.TabIndex = 35;
         this.label9.Text = "Instructions: ";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(72, 55);
         this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(71, 29);
         this.label8.TabIndex = 33;
         this.label8.Text = "Type: ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(20, 100);
         this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(119, 29);
         this.label7.TabIndex = 31;
         this.label7.Text = "Image File:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(8, 293);
         this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(136, 29);
         this.label6.TabIndex = 29;
         this.label6.Text = "Description: ";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(8, 432);
         this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(135, 29);
         this.label5.TabIndex = 27;
         this.label5.Text = "Ingredients: ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(60, 12);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 29);
         this.label2.TabIndex = 26;
         this.label2.Text = "Name: ";
         // 
         // MealRequest
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(961, 661);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.btnImage);
         this.Controls.Add(this.Cancel);
         this.Controls.Add(this.AddMeal);
         this.Controls.Add(this.Ingredients);
         this.Controls.Add(this.Description);
         this.Controls.Add(this.MealName);
         this.Controls.Add(this.imgfile);
         this.Controls.Add(this.Instructions);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label2);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "MealRequest";
         this.Text = "MealRequest";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddMeal;
        private System.Windows.Forms.TextBox Ingredients;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox MealName;
        private System.Windows.Forms.TextBox imgfile;
        private System.Windows.Forms.TextBox Instructions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}