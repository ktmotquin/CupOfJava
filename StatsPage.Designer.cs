﻿namespace OOAD_Project
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 40D);
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // toAdminMenuBtn
            // 
            this.toAdminMenuBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAdminMenuBtn.Location = new System.Drawing.Point(500, 10);
            this.toAdminMenuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toAdminMenuBtn.Name = "toAdminMenuBtn";
            this.toAdminMenuBtn.Size = new System.Drawing.Size(128, 46);
            this.toAdminMenuBtn.TabIndex = 1;
            this.toAdminMenuBtn.Text = "Admin Menu";
            this.toAdminMenuBtn.UseVisualStyleBackColor = true;
            this.toAdminMenuBtn.Click += new System.EventHandler(this.toAdminMenuBtn_Click);
            // 
            // pieGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.pieGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieGraph.Legends.Add(legend2);
            this.pieGraph.Location = new System.Drawing.Point(288, 80);
            this.pieGraph.Name = "pieGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Meals";
            dataPoint4.Label = "Meal 1";
            dataPoint5.Label = "Meal 2";
            dataPoint6.Label = "Meal 3";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            this.pieGraph.Series.Add(series2);
            this.pieGraph.Size = new System.Drawing.Size(322, 343);
            this.pieGraph.TabIndex = 2;
            this.pieGraph.Text = "chart1";
            // 
            // StatsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 435);
            this.Controls.Add(this.pieGraph);
            this.Controls.Add(this.toAdminMenuBtn);
            this.Controls.Add(this.dataGridView1);
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