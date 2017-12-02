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
         this.anytype = new System.Windows.Forms.RadioButton();
         this.lbluser = new System.Windows.Forms.Label();
         this.lblname = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.numMealLbl = new System.Windows.Forms.Label();
         this.back2Main = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // Logout
         // 
         this.Logout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Logout.Location = new System.Drawing.Point(672, 332);
         this.Logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Logout.Name = "Logout";
         this.Logout.Size = new System.Drawing.Size(221, 49);
         this.Logout.TabIndex = 0;
         this.Logout.Text = "Logout";
         this.Logout.UseVisualStyleBackColor = true;
         this.Logout.Click += new System.EventHandler(this.Logout_Click);
         // 
         // mealSearch
         // 
         this.mealSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mealSearch.Location = new System.Drawing.Point(445, 38);
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
         this.cartButton.Location = new System.Drawing.Point(672, 164);
         this.cartButton.Name = "cartButton";
         this.cartButton.Size = new System.Drawing.Size(221, 49);
         this.cartButton.TabIndex = 2;
         this.cartButton.Text = "View Cart";
         this.cartButton.UseVisualStyleBackColor = true;
         this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
         // 
         // searchBox
         // 
         this.searchBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.searchBox.Location = new System.Drawing.Point(44, 38);
         this.searchBox.Name = "searchBox";
         this.searchBox.Size = new System.Drawing.Size(396, 36);
         this.searchBox.TabIndex = 3;
         this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
         // 
         // searchList
         // 
         this.searchList.FormattingEnabled = true;
         this.searchList.ItemHeight = 16;
         this.searchList.Location = new System.Drawing.Point(44, 108);
         this.searchList.Name = "searchList";
         this.searchList.Size = new System.Drawing.Size(396, 484);
         this.searchList.TabIndex = 4;
         this.searchList.DoubleClick += new System.EventHandler(this.mealView_Click);
         // 
         // mealView
         // 
         this.mealView.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mealView.Location = new System.Drawing.Point(672, 219);
         this.mealView.Name = "mealView";
         this.mealView.Size = new System.Drawing.Size(221, 49);
         this.mealView.TabIndex = 5;
         this.mealView.Text = "View Meal";
         this.mealView.UseVisualStyleBackColor = true;
         this.mealView.Click += new System.EventHandler(this.mealView_Click);
         // 
         // btnSandwich
         // 
         this.btnSandwich.AutoSize = true;
         this.btnSandwich.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSandwich.Location = new System.Drawing.Point(24, 111);
         this.btnSandwich.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnSandwich.Name = "btnSandwich";
         this.btnSandwich.Size = new System.Drawing.Size(129, 33);
         this.btnSandwich.TabIndex = 10;
         this.btnSandwich.Text = "Sandwich";
         this.btnSandwich.UseVisualStyleBackColor = true;
         // 
         // btnSoup
         // 
         this.btnSoup.AutoSize = true;
         this.btnSoup.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSoup.Location = new System.Drawing.Point(24, 146);
         this.btnSoup.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnSoup.Name = "btnSoup";
         this.btnSoup.Size = new System.Drawing.Size(84, 33);
         this.btnSoup.TabIndex = 9;
         this.btnSoup.Text = "Soup";
         this.btnSoup.UseVisualStyleBackColor = true;
         // 
         // btnBakes
         // 
         this.btnBakes.AutoSize = true;
         this.btnBakes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBakes.Location = new System.Drawing.Point(24, 181);
         this.btnBakes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnBakes.Name = "btnBakes";
         this.btnBakes.Size = new System.Drawing.Size(90, 33);
         this.btnBakes.TabIndex = 8;
         this.btnBakes.Text = "Bakes";
         this.btnBakes.UseVisualStyleBackColor = true;
         // 
         // btnAppetizers
         // 
         this.btnAppetizers.AutoSize = true;
         this.btnAppetizers.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAppetizers.Location = new System.Drawing.Point(24, 216);
         this.btnAppetizers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnAppetizers.Name = "btnAppetizers";
         this.btnAppetizers.Size = new System.Drawing.Size(136, 33);
         this.btnAppetizers.TabIndex = 7;
         this.btnAppetizers.Text = "Appetizers";
         this.btnAppetizers.UseVisualStyleBackColor = true;
         // 
         // btnDessert
         // 
         this.btnDessert.AutoSize = true;
         this.btnDessert.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDessert.Location = new System.Drawing.Point(24, 76);
         this.btnDessert.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnDessert.Name = "btnDessert";
         this.btnDessert.Size = new System.Drawing.Size(107, 33);
         this.btnDessert.TabIndex = 11;
         this.btnDessert.Text = "Dessert";
         this.btnDessert.UseVisualStyleBackColor = true;
         // 
         // btnTortilla
         // 
         this.btnTortilla.AutoSize = true;
         this.btnTortilla.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnTortilla.Location = new System.Drawing.Point(24, 251);
         this.btnTortilla.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnTortilla.Name = "btnTortilla";
         this.btnTortilla.Size = new System.Drawing.Size(166, 33);
         this.btnTortilla.TabIndex = 13;
         this.btnTortilla.Text = "Tortilla Based";
         this.btnTortilla.UseVisualStyleBackColor = true;
         // 
         // btnSalad
         // 
         this.btnSalad.AutoSize = true;
         this.btnSalad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSalad.Location = new System.Drawing.Point(24, 41);
         this.btnSalad.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnSalad.Name = "btnSalad";
         this.btnSalad.Size = new System.Drawing.Size(88, 33);
         this.btnSalad.TabIndex = 12;
         this.btnSalad.Text = "Salad";
         this.btnSalad.UseVisualStyleBackColor = true;
         // 
         // btnRice
         // 
         this.btnRice.AutoSize = true;
         this.btnRice.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRice.Location = new System.Drawing.Point(24, 286);
         this.btnRice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnRice.Name = "btnRice";
         this.btnRice.Size = new System.Drawing.Size(139, 33);
         this.btnRice.TabIndex = 14;
         this.btnRice.Text = "Rice Based";
         this.btnRice.UseVisualStyleBackColor = true;
         // 
         // btnPasta
         // 
         this.btnPasta.AutoSize = true;
         this.btnPasta.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPasta.Location = new System.Drawing.Point(24, 6);
         this.btnPasta.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.btnPasta.Name = "btnPasta";
         this.btnPasta.Size = new System.Drawing.Size(86, 33);
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
         this.panel1.Location = new System.Drawing.Point(465, 108);
         this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(202, 369);
         this.panel1.TabIndex = 15;
         // 
         // anytype
         // 
         this.anytype.AutoSize = true;
         this.anytype.Checked = true;
         this.anytype.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.anytype.Location = new System.Drawing.Point(24, 324);
         this.anytype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.anytype.Name = "anytype";
         this.anytype.Size = new System.Drawing.Size(123, 33);
         this.anytype.TabIndex = 15;
         this.anytype.TabStop = true;
         this.anytype.Text = "Anything";
         this.anytype.UseVisualStyleBackColor = true;
         // 
         // lbluser
         // 
         this.lbluser.AutoSize = true;
         this.lbluser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbluser.Location = new System.Drawing.Point(3, 8);
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
         this.label1.Location = new System.Drawing.Point(40, 83);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(592, 24);
         this.label1.TabIndex = 18;
         this.label1.Text = "Select Search without anything entered into textbox to view all meals";
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(672, 108);
         this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(221, 49);
         this.button1.TabIndex = 19;
         this.button1.Text = "Request new Meal";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(332, 6);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(228, 29);
         this.label2.TabIndex = 20;
         this.label2.Text = "Number of Meals left:";
         // 
         // numMealLbl
         // 
         this.numMealLbl.AutoSize = true;
         this.numMealLbl.Location = new System.Drawing.Point(456, 15);
         this.numMealLbl.Name = "numMealLbl";
         this.numMealLbl.Size = new System.Drawing.Size(0, 17);
         this.numMealLbl.TabIndex = 21;
         // 
         // back2Main
         // 
         this.back2Main.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.back2Main.Location = new System.Drawing.Point(672, 275);
         this.back2Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.back2Main.Name = "back2Main";
         this.back2Main.Size = new System.Drawing.Size(221, 49);
         this.back2Main.TabIndex = 22;
         this.back2Main.Text = "Main Menu";
         this.back2Main.UseVisualStyleBackColor = true;
         this.back2Main.Click += new System.EventHandler(this.back2Main_Click);
         // 
         // CustomerMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(912, 601);
         this.Controls.Add(this.back2Main);
         this.Controls.Add(this.numMealLbl);
         this.Controls.Add(this.label2);
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
         this.Text = "Customer Home";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numMealLbl;
        private System.Windows.Forms.Button back2Main;
    }
}