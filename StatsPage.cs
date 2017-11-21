﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://www.dotnetperls.com/datatable
namespace OOAD_Project
{
    public partial class StatsPage : Form
    {
        public StatsPage()
        {
            InitializeComponent();

            string text;
            bool done = false;
            String[] foodItems = new String[200];
            int counter = 0; 
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\FoodItems.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
              
                while (!done)
                {
                    text = streamReader.ReadLine();
                    if (!text.Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("1"))
                        {
                            String[] parts = text.Split('\n');      // Breaks the current line into parts
                            foodItems[counter] = parts[0];
                            counter++; 
                        }

                    }
                    else
                    {
                        done = true;
                    }
                }
            }
                columns.Add("Name");
            rows.Add(new String[]
            {
                "beans",
                "corn",
                "cookie"
            });

            // Another example column.
            columns.Add("Quantity");
            rows.Add(new String[]
            {
                "3",
                "2",
                "8"
            });
            // Render the DataGridView.
            dataGridView1.DataSource = GetResultsTable();
        }


        List<string>columns = new List<string>();
        List<string[]> rows = new List<string[]>();


        public DataTable GetResultsTable()
        {
            DataTable datatable = new DataTable();

            for (int i = 0; i < this.rows.Count; i++)
            {
                string whichColumn = this.columns[i];
                datatable.Columns.Add(whichColumn);
                List<object> stock = new List<object>();
                foreach (string food in this.rows[i])
                {
                    stock.Add((object)food);
                }

                while (datatable.Rows.Count < stock.Count)
                {
                    datatable.Rows.Add();
                }

                for (int j = 0; j < stock.Count; j++)
                {
                    datatable.Rows[j][i] = stock[j];
                }
            }
            return datatable;
        }
        }
}
