using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
