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
        private int index;          //
        private Meal currentMeal;   // Current meal being displayed
        private RequestMealQueue rmq = new RequestMealQueue();
        private bool start;
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ApproveMealRequests()
        {
            if(rmq.getcount() > 0)
            {
                InitializeComponent();
                index = 0;
                start = true;
            }
            else
            {
                start = false;
                this.Close();
                MessageBox.Show("No new meal requests availible");
            }
        }

        /// <summary>
        /// Adds the meal currently displayed on the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMeal_Click(object sender, EventArgs e)
        {
            bool done = false;
            string mealInfo = rmq.listInfo(index);
            string overallText = "1\n";     // Initialize overall text with starting character
            string temp;                    // Used to store temporary info

            System.Console.WriteLine(mealInfo);
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link


            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    temp = streamReader.ReadLine(); // read next line
                    if (!temp.Equals("-1"))         // Check if end of file has been reached
                    {
                        if (!temp.Equals("1"))
                        {
                            overallText += temp + '\n'; // Add text to overall text
                        }
                    }
                    else
                    {
                        done = true;            // Info not found
                    }
                }
            }
            fileStream.Close();                 // Close file stream
            overallText += mealInfo + "\n-1";   // End of file character
            System.IO.File.WriteAllText(fileName, overallText);

            rmq.removeMeal(index);              // Remove requested meal
            if (rmq.getcount() > 0)
            {
                if (++index == rmq.getcount())
                    index = 0;                                  // Return to the front of the list
                pictureBox1.Image = rmq.getimg(index);          // Display Image
                currentMeal = rmq.sendmeal(index);              // Set current meal to next meal
                MealName.Text = currentMeal.name();             // Display name
                Type.Text = currentMeal.mealtype();             // Display type
                Instructions.Text = currentMeal.instructions(); // Display instructions
                Description.Text = currentMeal.description();   // Display description
                Ingredients.Text = currentMeal.ingredients();   // Display ingredients
            }
            else
            {
                MessageBox.Show("No pending meal requests availible.");
                Close();
            }
        }


        /// <summary>
        /// Deletes the currently displayed meal request.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRequest_Click(object sender, EventArgs e)
        {
            rmq.removeMeal(index);
        }

        /// <summary>
        /// Displays the previously requested meal in the list. If pressed when at the 
        /// beginning of the list, the last meal requested in the list will be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevMeal_Click(object sender, EventArgs e)
        {
            if (--index == -1)
                index = rmq.getcount() - 1;
            pictureBox1.Image = rmq.getimg(index);          // Display Image
            currentMeal = rmq.sendmeal(index);              // Set current meal to prev meal
            MealName.Text = currentMeal.name();             // Display name
            Type.Text = currentMeal.mealtype();             // Display type
            Instructions.Text = currentMeal.instructions(); // Display instructions
            Description.Text = currentMeal.description();   // Display description
            Ingredients.Text = currentMeal.ingredients();   // Display ingredients
        }

        /// <summary>
        /// Displays the next requested meal in the list. If pressed when at the 
        /// end of the list, the first meal requested in the list will be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextMeal_Click(object sender, EventArgs e)
        {
            if (++index == rmq.getcount())
                index = 0;
            pictureBox1.Image = rmq.getimg(index);          // Display Image
            currentMeal = rmq.sendmeal(index);              // Set current meal to next meal
            MealName.Text = currentMeal.name();             // Display name
            Type.Text = currentMeal.mealtype();             // Display type
            Instructions.Text = currentMeal.instructions(); // Display instructions
            Description.Text = currentMeal.description();   // Display description
            Ingredients.Text = currentMeal.ingredients();   // Display ingredients
        }
        /// <summary>
        /// Displays the next requested meal in the list. If pressed when at the 
        /// end of the list, the first meal requested in the list will be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool needwindow()
        {
            return start;
        }

        /// <summary>
        /// Closes the current window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();    // Close the current window
        }
    }
}
