namespace OOAD_Project
{
    partial class CustomerMenu
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
            this.Logout = new System.Windows.Forms.Button();
            this.mealSearch = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchList = new System.Windows.Forms.ListBox();
            this.mealView = new System.Windows.Forms.Button();
            this.fruitButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1342, 515);
            this.Logout.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(448, 319);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // mealSearch
            // 
            this.mealSearch.Location = new System.Drawing.Point(889, 58);
            this.mealSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mealSearch.Name = "mealSearch";
            this.mealSearch.Size = new System.Drawing.Size(217, 78);
            this.mealSearch.TabIndex = 1;
            this.mealSearch.Text = "Search Meals";
            this.mealSearch.UseVisualStyleBackColor = true;
            this.mealSearch.Click += new System.EventHandler(this.mealSearch_Click);
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(1342, 129);
            this.cartButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(448, 319);
            this.cartButton.TabIndex = 2;
            this.cartButton.Text = "View Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(201, 80);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(529, 35);
            this.searchBox.TabIndex = 3;
            // 
            // searchList
            // 
            this.searchList.FormattingEnabled = true;
            this.searchList.ItemHeight = 29;
            this.searchList.Location = new System.Drawing.Point(77, 196);
            this.searchList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(690, 874);
            this.searchList.TabIndex = 4;
            // 
            // mealView
            // 
            this.mealView.Location = new System.Drawing.Point(959, 986);
            this.mealView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mealView.Name = "mealView";
            this.mealView.Size = new System.Drawing.Size(217, 154);
            this.mealView.TabIndex = 5;
            this.mealView.Text = "View Meal";
            this.mealView.UseVisualStyleBackColor = true;
            this.mealView.Click += new System.EventHandler(this.mealView_Click);
            // 
            // fruitButton
            // 
            this.fruitButton.AutoSize = true;
            this.fruitButton.Location = new System.Drawing.Point(898, 223);
            this.fruitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fruitButton.Name = "fruitButton";
            this.fruitButton.Size = new System.Drawing.Size(92, 33);
            this.fruitButton.TabIndex = 6;
            this.fruitButton.Text = "Fruit";
            this.fruitButton.UseVisualStyleBackColor = true;
            this.fruitButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1352);
            this.Controls.Add(this.fruitButton);
            this.Controls.Add(this.mealView);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.mealSearch);
            this.Controls.Add(this.Logout);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button mealSearch;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox searchList;
        private System.Windows.Forms.Button mealView;
        private System.Windows.Forms.RadioButton fruitButton;
    }
}