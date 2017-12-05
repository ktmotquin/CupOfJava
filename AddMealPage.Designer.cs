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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.TextBox();
            this.imgfile = new System.Windows.Forms.TextBox();
            this.MealName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Ingredients = new System.Windows.Forms.TextBox();
            this.AddMeal = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingredients: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Image File:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Type: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Instructions: ";
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(116, 118);
            this.Instructions.Multiline = true;
            this.Instructions.Name = "Instructions";
            this.Instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Instructions.Size = new System.Drawing.Size(588, 115);
            this.Instructions.TabIndex = 7;
            this.Instructions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // imgfile
            // 
            this.imgfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgfile.Location = new System.Drawing.Point(116, 82);
            this.imgfile.Name = "imgfile";
            this.imgfile.Size = new System.Drawing.Size(100, 30);
            this.imgfile.TabIndex = 6;
            this.imgfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // MealName
            // 
            this.MealName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealName.Location = new System.Drawing.Point(116, 11);
            this.MealName.Name = "MealName";
            this.MealName.Size = new System.Drawing.Size(588, 30);
            this.MealName.TabIndex = 2;
            this.MealName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(116, 239);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(588, 107);
            this.Description.TabIndex = 8;
            this.Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // Ingredients
            // 
            this.Ingredients.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredients.Location = new System.Drawing.Point(116, 352);
            this.Ingredients.Multiline = true;
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ingredients.Size = new System.Drawing.Size(588, 139);
            this.Ingredients.TabIndex = 9;
            this.Ingredients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // AddMeal
            // 
            this.AddMeal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMeal.Location = new System.Drawing.Point(116, 496);
            this.AddMeal.Name = "AddMeal";
            this.AddMeal.Size = new System.Drawing.Size(75, 31);
            this.AddMeal.TabIndex = 21;
            this.AddMeal.Text = "Add Meal";
            this.AddMeal.UseVisualStyleBackColor = true;
            this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(197, 496);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(222, 82);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(161, 29);
            this.btnImage.TabIndex = 23;
            this.btnImage.Text = "Image Help";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(116, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 30);
            this.comboBox1.TabIndex = 24;
            // 
            // AddMealPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 538);
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
            this.Name = "AddMealPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMealPage";
            this.Load += new System.EventHandler(this.AddMealPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Instructions;
        private System.Windows.Forms.TextBox imgfile;
        private System.Windows.Forms.TextBox MealName;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Ingredients;
        private System.Windows.Forms.Button AddMeal;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}