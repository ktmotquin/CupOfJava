﻿namespace OOAD_Project
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
         this.anytype = new System.Windows.Forms.RadioButton();
         this.lbluser = new System.Windows.Forms.Label();
         this.lblname = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // Logout
         // 
         this.Logout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Logout.Location = new System.Drawing.Point(767, 284);
         this.Logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Logout.Name = "Logout";
         this.Logout.Size = new System.Drawing.Size(256, 176);
         this.Logout.TabIndex = 0;
         this.Logout.Text = "Logout";
         this.Logout.UseVisualStyleBackColor = true;
         this.Logout.Click += new System.EventHandler(this.Logout_Click);
         // 
         // mealSearch
         // 
         this.mealSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mealSearch.Location = new System.Drawing.Point(464, 38);
         this.mealSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.mealSearch.Name = "mealSearch";
         this.mealSearch.Size = new System.Drawing.Size(115, 36);
         this.mealSearch.TabIndex = 1;
         this.mealSearch.Text = "Search Meals";
         this.mealSearch.UseVisualStyleBackColor = true;
         this.mealSearch.Click += new System.EventHandler(this.mealSearch_Click);
         // 
         // cartButton
         // 
         this.cartButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cartButton.Location = new System.Drawing.Point(767, 71);
         this.cartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.cartButton.Name = "cartButton";
         this.cartButton.Size = new System.Drawing.Size(256, 176);
         this.cartButton.TabIndex = 2;
         this.cartButton.Text = "View Cart";
         this.cartButton.UseVisualStyleBackColor = true;
         this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
         // 
         // searchBox
         // 
         this.searchBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.searchBox.Location = new System.Drawing.Point(154, 38);
         this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.searchBox.Name = "searchBox";
         this.searchBox.Size = new System.Drawing.Size(304, 36);
         this.searchBox.TabIndex = 3;
         this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
         // 
         // searchList
         // 
         this.searchList.FormattingEnabled = true;
         this.searchList.ItemHeight = 16;
         this.searchList.Location = new System.Drawing.Point(44, 108);
         this.searchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.searchList.Name = "searchList";
         this.searchList.Size = new System.Drawing.Size(396, 484);
         this.searchList.TabIndex = 4;
         this.searchList.DoubleClick += new System.EventHandler(this.mealView_Click);
         // 
         // mealView
         // 
         this.mealView.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mealView.Location = new System.Drawing.Point(767, 494);
         this.mealView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.mealView.Name = "mealView";
         this.mealView.Size = new System.Drawing.Size(244, 126);
         this.mealView.TabIndex = 5;
         this.mealView.Text = "View Meal";
         this.mealView.UseVisualStyleBackColor = true;
         this.mealView.Click += new System.EventHandler(this.mealView_Click);
         // 
         // btnSandwich
         // 
         this.btnSandwich.AutoSize = true;
         this.btnSandwich.Location = new System.Drawing.Point(25, 68);
         this.btnSandwich.Margin = new System.Windows.Forms.Padding(1);
         this.btnSandwich.Name = "btnSandwich";
         this.btnSandwich.Size = new System.Drawing.Size(89, 21);
         this.btnSandwich.TabIndex = 10;
         this.btnSandwich.Text = "Sandwich";
         this.btnSandwich.UseVisualStyleBackColor = true;
         // 
         // btnSoup
         // 
         this.btnSoup.AutoSize = true;
         this.btnSoup.Location = new System.Drawing.Point(25, 89);
         this.btnSoup.Margin = new System.Windows.Forms.Padding(1);
         this.btnSoup.Name = "btnSoup";
         this.btnSoup.Size = new System.Drawing.Size(62, 21);
         this.btnSoup.TabIndex = 9;
         this.btnSoup.Text = "Soup";
         this.btnSoup.UseVisualStyleBackColor = true;
         // 
         // btnBakes
         // 
         this.btnBakes.AutoSize = true;
         this.btnBakes.Location = new System.Drawing.Point(27, 108);
         this.btnBakes.Margin = new System.Windows.Forms.Padding(1);
         this.btnBakes.Name = "btnBakes";
         this.btnBakes.Size = new System.Drawing.Size(68, 21);
         this.btnBakes.TabIndex = 8;
         this.btnBakes.Text = "Bakes";
         this.btnBakes.UseVisualStyleBackColor = true;
         // 
         // btnAppetizers
         // 
         this.btnAppetizers.AutoSize = true;
         this.btnAppetizers.Location = new System.Drawing.Point(27, 129);
         this.btnAppetizers.Margin = new System.Windows.Forms.Padding(1);
         this.btnAppetizers.Name = "btnAppetizers";
         this.btnAppetizers.Size = new System.Drawing.Size(96, 21);
         this.btnAppetizers.TabIndex = 7;
         this.btnAppetizers.Text = "Appetizers";
         this.btnAppetizers.UseVisualStyleBackColor = true;
         // 
         // btnDessert
         // 
         this.btnDessert.AutoSize = true;
         this.btnDessert.Location = new System.Drawing.Point(25, 48);
         this.btnDessert.Margin = new System.Windows.Forms.Padding(1);
         this.btnDessert.Name = "btnDessert";
         this.btnDessert.Size = new System.Drawing.Size(78, 21);
         this.btnDessert.TabIndex = 11;
         this.btnDessert.Text = "Dessert";
         this.btnDessert.UseVisualStyleBackColor = true;
         // 
         // btnTortilla
         // 
         this.btnTortilla.AutoSize = true;
         this.btnTortilla.Location = new System.Drawing.Point(27, 149);
         this.btnTortilla.Margin = new System.Windows.Forms.Padding(1);
         this.btnTortilla.Name = "btnTortilla";
         this.btnTortilla.Size = new System.Drawing.Size(116, 21);
         this.btnTortilla.TabIndex = 13;
         this.btnTortilla.Text = "Tortilla Based";
         this.btnTortilla.UseVisualStyleBackColor = true;
         // 
         // btnSalad
         // 
         this.btnSalad.AutoSize = true;
         this.btnSalad.Location = new System.Drawing.Point(25, 27);
         this.btnSalad.Margin = new System.Windows.Forms.Padding(1);
         this.btnSalad.Name = "btnSalad";
         this.btnSalad.Size = new System.Drawing.Size(65, 21);
         this.btnSalad.TabIndex = 12;
         this.btnSalad.Text = "Salad";
         this.btnSalad.UseVisualStyleBackColor = true;
         // 
         // btnRice
         // 
         this.btnRice.AutoSize = true;
         this.btnRice.Location = new System.Drawing.Point(27, 170);
         this.btnRice.Margin = new System.Windows.Forms.Padding(1);
         this.btnRice.Name = "btnRice";
         this.btnRice.Size = new System.Drawing.Size(101, 21);
         this.btnRice.TabIndex = 14;
         this.btnRice.Text = "Rice Based";
         this.btnRice.UseVisualStyleBackColor = true;
         // 
         // btnPasta
         // 
         this.btnPasta.AutoSize = true;
         this.btnPasta.Location = new System.Drawing.Point(24, 6);
         this.btnPasta.Margin = new System.Windows.Forms.Padding(1);
         this.btnPasta.Name = "btnPasta";
         this.btnPasta.Size = new System.Drawing.Size(65, 21);
         this.btnPasta.TabIndex = 6;
         this.btnPasta.Text = "Pasta";
         this.btnPasta.UseVisualStyleBackColor = true;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.anytype);
         this.panel1.Controls.Add(this.btnPasta);
         this.panel1.Controls.Add(this.btnRice);
         this.panel1.Controls.Add(this.btnSalad);
         this.panel1.Controls.Add(this.btnTortilla);
         this.panel1.Controls.Add(this.btnDessert);
         this.panel1.Controls.Add(this.btnAppetizers);
         this.panel1.Controls.Add(this.btnBakes);
         this.panel1.Controls.Add(this.btnSoup);
         this.panel1.Controls.Add(this.btnSandwich);
         this.panel1.Location = new System.Drawing.Point(465, 156);
         this.panel1.Margin = new System.Windows.Forms.Padding(1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(148, 256);
         this.panel1.TabIndex = 15;
         // 
         // anytype
         // 
         this.anytype.AutoSize = true;
         this.anytype.Checked = true;
         this.anytype.Location = new System.Drawing.Point(27, 196);
         this.anytype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.anytype.Name = "anytype";
         this.anytype.Size = new System.Drawing.Size(84, 21);
         this.anytype.TabIndex = 15;
         this.anytype.TabStop = true;
         this.anytype.Text = "Anything";
         this.anytype.UseVisualStyleBackColor = true;
         // 
         // lbluser
         // 
         this.lbluser.AutoSize = true;
         this.lbluser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbluser.Location = new System.Drawing.Point(39, 9);
         this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lbluser.Name = "lbluser";
         this.lbluser.Size = new System.Drawing.Size(119, 29);
         this.lbluser.TabIndex = 16;
         this.lbluser.Text = "Username:";
         // 
         // lblname
         // 
         this.lblname.AutoSize = true;
         this.lblname.Location = new System.Drawing.Point(129, 16);
         this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblname.Name = "lblname";
         this.lblname.Size = new System.Drawing.Size(0, 17);
         this.lblname.TabIndex = 17;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(40, 82);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(647, 24);
         this.label1.TabIndex = 18;
         this.label1.Text = "Select Search Meals without anything entered into textbox to view all meals";
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(767, 16);
         this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(256, 49);
         this.button1.TabIndex = 19;
         this.button1.Text = "Request new meal";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // CustomerMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1051, 641);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lblname);
         this.Controls.Add(this.lbluser);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.mealView);
         this.Controls.Add(this.searchList);
         this.Controls.Add(this.searchBox);
         this.Controls.Add(this.cartButton);
         this.Controls.Add(this.mealSearch);
         this.Controls.Add(this.Logout);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "CustomerMenu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton anytype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}