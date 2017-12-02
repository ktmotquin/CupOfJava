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

namespace OOAD_Project
{
    public partial class ApproveMealRequests : Form
    {
        Meal currentMeal;
        int index, numadd;
        RequestMealQueue rmq = new RequestMealQueue();

        public ApproveMealRequests()
        {
            InitializeComponent();
            index = 0;
        }

        private bool checkForEmpty()
        {
            bool validInfoEntered = true;
            foreach (Control child in this.Controls)
            {
                TextBox textbox = child as TextBox;
                if (textbox != null)
                {
                    if (string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        MessageBox.Show("All text boxes must be filled");
                        return false;
                    }
                }
            }
            return validInfoEntered;
        }

        private void AddMeal_Click(object sender, EventArgs e)
        {
            string overallText = "1\n";
            string temp;
            string mealInfo = rmq.listInfo(index);
            bool done = false;

            System.Console.WriteLine(mealInfo);
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link                                                                                                                        


            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    temp = streamReader.ReadLine();         // read next line
                    if (!temp.Equals("-1"))                 // Check if end of file has been reached 
                    {
                        //System.Console.WriteLine("Entered text " + temp);
                        if (!temp.Equals("1"))
                        {
                            overallText += temp + '\n';
                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
                    }
                }
            }
            fileStream.Close();
            overallText += mealInfo + "\n-1";
            System.IO.File.WriteAllText(fileName, overallText);

            rmq.removeMeal(index);
            if (rmq.getcount() > 0)
            {
                if (++index == rmq.getcount())
                    index = 0;
                pictureBox1.Image = rmq.getimg(index);
                currentMeal = rmq.sendmeal(index);
                MealName.Text = currentMeal.name();
                Type.Text = currentMeal.mealtype();
                Instructions.Text = currentMeal.instructions();
                Description.Text = currentMeal.description();
                Ingredients.Text = currentMeal.ingredients();
            }
            else
            {
                MessageBox.Show("No pending meal requests availible.");
                Close();
            }
        }

        private void DeleteRequest_Click(object sender, EventArgs e)
        {
            rmq.removeMeal(index);
        }


        private void PrevMeal_Click(object sender, EventArgs e)
        {
            if (--index == -1)
                index = rmq.getcount() - 1;
            pictureBox1.Image = rmq.getimg(index);
            currentMeal = rmq.sendmeal(index);
            MealName.Text = currentMeal.name();
            Type.Text = currentMeal.mealtype();
            Instructions.Text = currentMeal.instructions();
            Description.Text = currentMeal.description();
            Ingredients.Text = currentMeal.ingredients();
        }

        private void NextMeal_Click(object sender, EventArgs e)
        {
            if (++index == rmq.getcount())
                index = 0;
            pictureBox1.Image = rmq.getimg(index);
            currentMeal = rmq.sendmeal(index);
            MealName.Text = currentMeal.name();
            Type.Text = currentMeal.mealtype();
            Instructions.Text = currentMeal.instructions();
            Description.Text = currentMeal.description();
            Ingredients.Text = currentMeal.ingredients();
        }



        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
