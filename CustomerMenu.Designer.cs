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
            this.btnSandwich = new System.Windows.Forms.RadioButton();
            this.btnSoup = new System.Windows.Forms.RadioButton();
            this.btnBakes = new System.Windows.Forms.RadioButton();
            this.btnAppetizers = new System.Windows.Forms.RadioButton();
            this.btnDessert = new System.Windows.Forms.RadioButton();
            this.btnTortilla = new System.Windows.Forms.RadioButton();
            this.btnSalad = new System.Windows.Forms.RadioButton();
            this.btnRice = new System.Windows.Forms.RadioButton();
            this.btnPasta = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1342, 515);
            this.Logout.Margin = new System.Windows.Forms.Padding(7);
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
            // btnSandwich
            // 
            this.btnSandwich.AutoSize = true;
            this.btnSandwich.Location = new System.Drawing.Point(44, 123);
            this.btnSandwich.Margin = new System.Windows.Forms.Padding(2);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(149, 33);
            this.btnSandwich.TabIndex = 10;
            this.btnSandwich.Text = "Sandwich";
            this.btnSandwich.UseVisualStyleBackColor = true;
            // 
            // btnSoup
            // 
            this.btnSoup.AutoSize = true;
            this.btnSoup.Location = new System.Drawing.Point(44, 160);
            this.btnSoup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(101, 33);
            this.btnSoup.TabIndex = 9;
            this.btnSoup.Text = "Soup";
            this.btnSoup.UseVisualStyleBackColor = true;
            // 
            // btnBakes
            // 
            this.btnBakes.AutoSize = true;
            this.btnBakes.Location = new System.Drawing.Point(46, 197);
            this.btnBakes.Margin = new System.Windows.Forms.Padding(2);
            this.btnBakes.Name = "btnBakes";
            this.btnBakes.Size = new System.Drawing.Size(111, 33);
            this.btnBakes.TabIndex = 8;
            this.btnBakes.Text = "Bakes";
            this.btnBakes.UseVisualStyleBackColor = true;
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.AutoSize = true;
            this.btnAppetizers.Location = new System.Drawing.Point(46, 234);
            this.btnAppetizers.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(158, 33);
            this.btnAppetizers.TabIndex = 7;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = true;
            // 
            // btnDessert
            // 
            this.btnDessert.AutoSize = true;
            this.btnDessert.Location = new System.Drawing.Point(44, 86);
            this.btnDessert.Margin = new System.Windows.Forms.Padding(2);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(127, 33);
            this.btnDessert.TabIndex = 11;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            // 
            // btnTortilla
            // 
            this.btnTortilla.AutoSize = true;
            this.btnTortilla.Location = new System.Drawing.Point(46, 271);
            this.btnTortilla.Margin = new System.Windows.Forms.Padding(2);
            this.btnTortilla.Name = "btnTortilla";
            this.btnTortilla.Size = new System.Drawing.Size(194, 33);
            this.btnTortilla.TabIndex = 13;
            this.btnTortilla.Text = "Tortilla Based";
            this.btnTortilla.UseVisualStyleBackColor = true;
            // 
            // btnSalad
            // 
            this.btnSalad.AutoSize = true;
            this.btnSalad.Location = new System.Drawing.Point(44, 49);
            this.btnSalad.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(106, 33);
            this.btnSalad.TabIndex = 12;
            this.btnSalad.Text = "Salad";
            this.btnSalad.UseVisualStyleBackColor = true;
            // 
            // btnRice
            // 
            this.btnRice.AutoSize = true;
            this.btnRice.Location = new System.Drawing.Point(46, 308);
            this.btnRice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(168, 33);
            this.btnRice.TabIndex = 14;
            this.btnRice.Text = "Rice Based";
            this.btnRice.UseVisualStyleBackColor = true;
            // 
            // btnPasta
            // 
            this.btnPasta.AutoSize = true;
            this.btnPasta.Location = new System.Drawing.Point(41, 12);
            this.btnPasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(104, 33);
            this.btnPasta.TabIndex = 6;
            this.btnPasta.Text = "Pasta";
            this.btnPasta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPasta);
            this.panel1.Controls.Add(this.btnRice);
            this.panel1.Controls.Add(this.btnSalad);
            this.panel1.Controls.Add(this.btnTortilla);
            this.panel1.Controls.Add(this.btnDessert);
            this.panel1.Controls.Add(this.btnAppetizers);
            this.panel1.Controls.Add(this.btnBakes);
            this.panel1.Controls.Add(this.btnSoup);
            this.panel1.Controls.Add(this.btnSandwich);
            this.panel1.Location = new System.Drawing.Point(815, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 379);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mealView);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.mealSearch);
            this.Controls.Add(this.Logout);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton btnSandwich;
        private System.Windows.Forms.RadioButton btnSoup;
        private System.Windows.Forms.RadioButton btnBakes;
        private System.Windows.Forms.RadioButton btnAppetizers;
        private System.Windows.Forms.RadioButton btnDessert;
        private System.Windows.Forms.RadioButton btnTortilla;
        private System.Windows.Forms.RadioButton btnSalad;
        private System.Windows.Forms.RadioButton btnRice;
        private System.Windows.Forms.RadioButton btnPasta;
        private System.Windows.Forms.Panel panel1;
    }
}