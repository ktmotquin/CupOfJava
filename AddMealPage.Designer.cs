namespace OOAD_Project
{
    partial class AddMealPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Instructions = new System.Windows.Forms.TextBox();
            this.imgfile = new System.Windows.Forms.TextBox();
            this.Calories = new System.Windows.Forms.TextBox();
            this.Keywords = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.MealName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Ingredients = new System.Windows.Forms.TextBox();
            this.AddMeal = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calories: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Keywords: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 792);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingredients: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 584);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Image File:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Type: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Instructions: ";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(194, 27);
            this.ID.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(228, 35);
            this.ID.TabIndex = 1;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Instructions
            // 
            this.Instructions.Location = new System.Drawing.Point(194, 375);
            this.Instructions.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Instructions.Multiline = true;
            this.Instructions.Name = "Instructions";
            this.Instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Instructions.Size = new System.Drawing.Size(620, 185);
            this.Instructions.TabIndex = 7;
            this.Instructions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // imgfile
            // 
            this.imgfile.Location = new System.Drawing.Point(194, 317);
            this.imgfile.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.imgfile.Name = "imgfile";
            this.imgfile.Size = new System.Drawing.Size(228, 35);
            this.imgfile.TabIndex = 6;
            this.imgfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Calories
            // 
            this.Calories.Location = new System.Drawing.Point(194, 259);
            this.Calories.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Calories.Name = "Calories";
            this.Calories.Size = new System.Drawing.Size(228, 35);
            this.Calories.TabIndex = 5;
            this.Calories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Keywords
            // 
            this.Keywords.Location = new System.Drawing.Point(194, 207);
            this.Keywords.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Keywords.Name = "Keywords";
            this.Keywords.Size = new System.Drawing.Size(228, 35);
            this.Keywords.TabIndex = 4;
            this.Keywords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(194, 143);
            this.Type.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(228, 35);
            this.Type.TabIndex = 3;
            this.Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // MealName
            // 
            this.MealName.Location = new System.Drawing.Point(194, 85);
            this.MealName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MealName.Name = "MealName";
            this.MealName.Size = new System.Drawing.Size(228, 35);
            this.MealName.TabIndex = 2;
            this.MealName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(194, 578);
            this.Description.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(620, 185);
            this.Description.TabIndex = 8;
            this.Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Ingredients
            // 
            this.Ingredients.Location = new System.Drawing.Point(194, 785);
            this.Ingredients.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Ingredients.Multiline = true;
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ingredients.Size = new System.Drawing.Size(620, 185);
            this.Ingredients.TabIndex = 9;
            this.Ingredients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // AddMeal
            // 
            this.AddMeal.Location = new System.Drawing.Point(301, 988);
            this.AddMeal.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AddMeal.Name = "AddMeal";
            this.AddMeal.Size = new System.Drawing.Size(175, 51);
            this.AddMeal.TabIndex = 21;
            this.AddMeal.Text = "Add Meal";
            this.AddMeal.UseVisualStyleBackColor = true;
            this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(490, 988);
            this.Cancel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(175, 51);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(441, 312);
            this.btnImage.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(175, 51);
            this.btnImage.TabIndex = 23;
            this.btnImage.Text = "Image Help";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboBox1.Location = new System.Drawing.Point(441, 141);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 37);
            this.comboBox1.TabIndex = 24;
            // 
            // AddMealPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 1051);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddMeal);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.MealName);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Keywords);
            this.Controls.Add(this.Calories);
            this.Controls.Add(this.imgfile);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AddMealPage";
            this.Text = "AddMealPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Instructions;
        private System.Windows.Forms.TextBox imgfile;
        private System.Windows.Forms.TextBox Calories;
        private System.Windows.Forms.TextBox Keywords;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox MealName;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Ingredients;
        private System.Windows.Forms.Button AddMeal;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}