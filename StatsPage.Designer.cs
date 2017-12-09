namespace OOAD_Project
{
    partial class StatsPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toAdminMenuBtn = new System.Windows.Forms.Button();
            this.pieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 1239);
            this.dataGridView1.TabIndex = 0;
            // 
            // toAdminMenuBtn
            // 
            this.toAdminMenuBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAdminMenuBtn.Location = new System.Drawing.Point(1521, 29);
            this.toAdminMenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toAdminMenuBtn.Name = "toAdminMenuBtn";
            this.toAdminMenuBtn.Size = new System.Drawing.Size(256, 88);
            this.toAdminMenuBtn.TabIndex = 1;
            this.toAdminMenuBtn.Text = "Admin Menu";
            this.toAdminMenuBtn.UseVisualStyleBackColor = true;
            this.toAdminMenuBtn.Click += new System.EventHandler(this.toAdminMenuBtn_Click);
            // 
            // pieGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.pieGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieGraph.Legends.Add(legend1);
            this.pieGraph.Location = new System.Drawing.Point(576, 154);
            this.pieGraph.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pieGraph.Name = "pieGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Meals";
            this.pieGraph.Series.Add(series1);
            this.pieGraph.Size = new System.Drawing.Size(1217, 1091);
            this.pieGraph.TabIndex = 2;
            this.pieGraph.Text = "chart1";
            // 
            // StatsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 1275);
            this.Controls.Add(this.pieGraph);
            this.Controls.Add(this.toAdminMenuBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StatsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatsPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button toAdminMenuBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieGraph;
    }
}