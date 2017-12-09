using System;
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
        //----------------------------------------------------------------
        // Constructor: Initializes the table for Item Stock and the values 
        //              in the pie chart. 
        //----------------------------------------------------------------
        public StatsPage()
        {
            InitializeComponent();
            //everytime a meal is sold, put into a new text file if it hasn't been purchased before or update existing text file
            //make quantity (AddY(22)) a variable
            //add top 5 meals to pieGraph, with correspoding number of orders

            createpiechart();
            string text;
            bool done = false;
            String[] foodItems = new String[200];
            String[] numItems = new String[200];
            int counter = 0;
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\FoodItems.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                while (!done)
                {
                    text = streamReader.ReadLine();
                    if (!text.Equals("-$"))                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("$"))
                        {
                            String[] parts = text.Split('~');      // Breaks the current line into parts
                            foodItems[counter] = parts[0];
                            numItems[counter] = parts[1];
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
            rows.Add(foodItems);

            // Another example column.
            columns.Add("Quantity");
            rows.Add(numItems);
            // Render the DataGridView.
            dataGridView1.DataSource = GetResultsTable();
        }


        List<string> columns = new List<string>();
        List<string[]> rows = new List<string[]>();

        //----------------------------------------------------------------
        // Puts all the stock values into a table.
        //----------------------------------------------------------------
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

        private void toAdminMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void createpiechart()
        {
            string text;
            bool done = false;
            String[] meal = new String[200];
            String[] numOrder = new String[200];
            int counter = 0;
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\OrderStats.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                while (!done)
                {
                    text = streamReader.ReadLine();
                    if (!text.Equals("-$"))                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("$"))
                        {
                            String[] parts = text.Split('~');      // Breaks the current line into parts
                            meal[counter] = parts[0];
                            numOrder[counter] = parts[1];
                            counter++;
                        }

                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            for (int i = 0; i < counter; i++)
            {
                pieGraph.Series["Meals"].Points.AddY(numOrder[i]);
                pieGraph.Series["Meals"].Points[i].Label = meal[i];
                pieGraph.Series[0]["PieLabelStyle"] = "Disabled";
            }

        }
    }
}
