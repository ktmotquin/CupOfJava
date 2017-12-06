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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal_Screen));
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.mealNameText = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionDisplayBox = new System.Windows.Forms.RichTextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsDisplayBox = new System.Windows.Forms.RichTextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsDisplayBox = new System.Windows.Forms.RichTextBox();
            this.mealPhotoPlaceholder = new System.Windows.Forms.Label();
            this.orderQuantityLabel = new System.Windows.Forms.Label();
            this.mealQtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backToSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mealQtyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameLabel.Location = new System.Drawing.Point(9, 15);
            this.mealNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(102, 23);
            this.mealNameLabel.TabIndex = 0;
            this.mealNameLabel.Text = "Meal Name:";
            // 
            // mealNameText
            // 
            this.mealNameText.AutoSize = true;
            this.mealNameText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameText.Location = new System.Drawing.Point(114, 15);
            this.mealNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealNameText.Name = "mealNameText";
            this.mealNameText.Size = new System.Drawing.Size(181, 23);
            this.mealNameText.TabIndex = 1;
            this.mealNameText.Text = "Meal Name Goes Here";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(9, 38);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(104, 23);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionDisplayBox
            // 
            this.descriptionDisplayBox.BackColor = System.Drawing.SystemColors.Menu;
            this.descriptionDisplayBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionDisplayBox.Location = new System.Drawing.Point(118, 40);
            this.descriptionDisplayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionDisplayBox.Name = "descriptionDisplayBox";
            this.descriptionDisplayBox.ReadOnly = true;
            this.descriptionDisplayBox.Size = new System.Drawing.Size(348, 140);
            this.descriptionDisplayBox.TabIndex = 3;
            this.descriptionDisplayBox.Text = "";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(9, 187);
            this.ingredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(107, 23);
            this.ingredientsLabel.TabIndex = 4;
            this.ingredientsLabel.Text = "Ingredients: ";
            // 
            // ingredientsDisplayBox
            // 
            this.ingredientsDisplayBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ingredientsDisplayBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsDisplayBox.Location = new System.Drawing.Point(118, 184);
            this.ingredientsDisplayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingredientsDisplayBox.Name = "ingredientsDisplayBox";
            this.ingredientsDisplayBox.ReadOnly = true;
            this.ingredientsDisplayBox.Size = new System.Drawing.Size(348, 102);
            this.ingredientsDisplayBox.TabIndex = 5;
            this.ingredientsDisplayBox.Text = "";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(9, 291);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(109, 23);
            this.instructionsLabel.TabIndex = 6;
            this.instructionsLabel.Text = "Instructions:";
            // 
            // instructionsDisplayBox
            // 
            this.instructionsDisplayBox.BackColor = System.Drawing.SystemColors.Menu;
            this.instructionsDisplayBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsDisplayBox.Location = new System.Drawing.Point(118, 291);
            this.instructionsDisplayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instructionsDisplayBox.Name = "instructionsDisplayBox";
            this.instructionsDisplayBox.ReadOnly = true;
            this.instructionsDisplayBox.Size = new System.Drawing.Size(696, 202);
            this.instructionsDisplayBox.TabIndex = 7;
            this.instructionsDisplayBox.Text = "";
            // 
            // mealPhotoPlaceholder
            // 
            this.mealPhotoPlaceholder.AutoSize = true;
            this.mealPhotoPlaceholder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPhotoPlaceholder.Location = new System.Drawing.Point(484, 155);
            this.mealPhotoPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealPhotoPlaceholder.Name = "mealPhotoPlaceholder";
            this.mealPhotoPlaceholder.Size = new System.Drawing.Size(170, 23);
            this.mealPhotoPlaceholder.TabIndex = 8;
            this.mealPhotoPlaceholder.Text = "MealPhotoGoesHere";
            // 
            // orderQuantityLabel
            // 
            this.orderQuantityLabel.AutoSize = true;
            this.orderQuantityLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQuantityLabel.Location = new System.Drawing.Point(114, 499);
            this.orderQuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderQuantityLabel.Name = "orderQuantityLabel";
            this.orderQuantityLabel.Size = new System.Drawing.Size(133, 23);
            this.orderQuantityLabel.TabIndex = 9;
            this.orderQuantityLabel.Text = "Order Quantity:";
            // 
            // mealQtyUpDown
            // 
            this.mealQtyUpDown.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealQtyUpDown.Location = new System.Drawing.Point(244, 497);
            this.mealQtyUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mealQtyUpDown.Name = "mealQtyUpDown";
            this.mealQtyUpDown.Size = new System.Drawing.Size(38, 30);
            this.mealQtyUpDown.TabIndex = 10;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.SystemColors.Control;
            this.addToCartButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(118, 531);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(164, 30);
            this.addToCartButton.TabIndex = 11;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(471, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 248);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // backToSearch
            // 
            this.backToSearch.BackColor = System.Drawing.SystemColors.Control;
            this.backToSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToSearch.Location = new System.Drawing.Point(286, 531);
            this.backToSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToSearch.Name = "backToSearch";
            this.backToSearch.Size = new System.Drawing.Size(130, 30);
            this.backToSearch.TabIndex = 13;
            this.backToSearch.Text = "Back to Search";
            this.backToSearch.UseVisualStyleBackColor = false;
            this.backToSearch.Click += new System.EventHandler(this.backToSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(658, 531);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 30);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Save Changes";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Meal_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 575);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.backToSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.mealQtyUpDown);
            this.Controls.Add(this.orderQuantityLabel);
            this.Controls.Add(this.mealPhotoPlaceholder);
            this.Controls.Add(this.instructionsDisplayBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.ingredientsDisplayBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.descriptionDisplayBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.mealNameText);
            this.Controls.Add(this.mealNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(870, 613);
            this.Name = "Meal_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Meal";
            ((System.ComponentModel.ISupportInitialize)(this.mealQtyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Label mealNameLabel;
      private System.Windows.Forms.Label mealNameText;
      private System.Windows.Forms.Label descriptionLabel;
      private System.Windows.Forms.RichTextBox descriptionDisplayBox;
      private System.Windows.Forms.Label ingredientsLabel;
      private System.Windows.Forms.RichTextBox ingredientsDisplayBox;
      private System.Windows.Forms.Label instructionsLabel;
      private System.Windows.Forms.RichTextBox instructionsDisplayBox;
      private System.Windows.Forms.Label mealPhotoPlaceholder;
      private System.Windows.Forms.Label orderQuantityLabel;
      private System.Windows.Forms.NumericUpDown mealQtyUpDown;
      private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button backToSearch;
        private System.Windows.Forms.Button btnEdit;
    }
}