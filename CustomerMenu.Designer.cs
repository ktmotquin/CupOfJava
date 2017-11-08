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
            this.Logout.Location = new System.Drawing.Point(1533, 552);
            this.Logout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(512, 342);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // mealSearch
            // 
            this.mealSearch.Location = new System.Drawing.Point(1017, 61);
            this.mealSearch.Margin = new System.Windows.Forms.Padding(4);
            this.mealSearch.Name = "mealSearch";
            this.mealSearch.Size = new System.Drawing.Size(247, 84);
            this.mealSearch.TabIndex = 1;
            this.mealSearch.Text = "Search Meals";
            this.mealSearch.UseVisualStyleBackColor = true;
            this.mealSearch.Click += new System.EventHandler(this.mealSearch_Click);
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(1533, 139);
            this.cartButton.Margin = new System.Windows.Forms.Padding(4);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(512, 340);
            this.cartButton.TabIndex = 2;
            this.cartButton.Text = "View Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(229, 85);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(604, 38);
            this.searchBox.TabIndex = 3;
            // 
            // searchList
            // 
            this.searchList.FormattingEnabled = true;
            this.searchList.ItemHeight = 31;
            this.searchList.Location = new System.Drawing.Point(89, 209);
            this.searchList.Margin = new System.Windows.Forms.Padding(4);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(787, 934);
            this.searchList.TabIndex = 4;
            // 
            // mealView
            // 
            this.mealView.Location = new System.Drawing.Point(1097, 1054);
            this.mealView.Margin = new System.Windows.Forms.Padding(4);
            this.mealView.Name = "mealView";
            this.mealView.Size = new System.Drawing.Size(247, 165);
            this.mealView.TabIndex = 5;
            this.mealView.Text = "View Meal";
            this.mealView.UseVisualStyleBackColor = true;
            this.mealView.Click += new System.EventHandler(this.mealView_Click);
            // 
            // fruitButton
            // 
            this.fruitButton.AutoSize = true;
            this.fruitButton.Location = new System.Drawing.Point(1027, 239);
            this.fruitButton.Name = "fruitButton";
            this.fruitButton.Size = new System.Drawing.Size(109, 36);
            this.fruitButton.TabIndex = 6;
            this.fruitButton.TabStop = true;
            this.fruitButton.Text = "Fruit";
            this.fruitButton.UseVisualStyleBackColor = true;
            this.fruitButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2301, 1590);
            this.Controls.Add(this.fruitButton);
            this.Controls.Add(this.mealView);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.mealSearch);
            this.Controls.Add(this.Logout);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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