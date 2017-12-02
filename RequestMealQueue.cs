using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace OOAD_Project
{
    /// <summary>
    /// Class which loads and manipulates data of the current requested meal queue.
    /// </summary>
    class RequestMealQueue
    {
        private Image[] images = new Image[100];
        private int count = 0;
        private Meal[] meals = new Meal[100];
        private string[] mealData = new string[100];


        /// <summary>
        /// Default constructor. Loads all meal info into a list.
        /// </summary>
        public RequestMealQueue()
        {
            bool done = false; // True when end of user list has been reached
            string text;

            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\MealRequests.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine(); // read next line
                    if (!text.Equals("-1")) // Check if end of file has been reached
                    {
                        if (!text.Equals("1"))
                        {
                            mealData[count] = text;     // Add base meal string
                            String[] parts = text.Split('$'); // Breaks the current line into parts
                            meals[count] = new Meal(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                            count++;
                        }
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            fileStream.Close();     // Close the filestream

            for (int i = 0; i < count; i++)
            {
                string filestring = meals[i].getimg();  // Get all the images
                string test = Directory.GetCurrentDirectory() + @"\" + filestring;
                images[i] = Image.FromFile(test);
            }
        }

        /// <summary>
        /// Returns specific meal information.
        /// </summary>
        /// <param name="index">Current index number of the request meals list.</param>
        /// <returns>Meal Information in an organized string.</returns>
        public string listInfo(int index)
        {
            return mealData[index];
        }


        /// <summary>
        /// Removes meal from the queue.
        /// </summary>
        /// <param name="index">Current index number of the request meals list.</param>
        public void removeMeal(int index)
        {
            meals[index] = meals[--count];          // Decrement count and assign last meal
            images[index] = images[count];          // Assign last image
            mealData[index] = mealData[count];      // Assign last meal data
            string overallText = "1\n";
            for (int i = 0; i < count; i++)
            {
                overallText += mealData[i] + "\n";  // Add next meal to list 
            }
            overallText += "-1\n";                  // End of list character
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\MealRequests.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            System.IO.File.WriteAllText(fileName, overallText);
        }

        /// <summary>
        /// Gets a meal object of the specified meal.
        /// </summary>
        /// <param name="index">Current index number of the request meals list.</param>
        /// <returns>Returns a specified meal.</returns>
        public Meal sendmeal(int index)
        {
            return meals[index];
        }


        /// <summary>
        /// Gets the current requested meal count.
        /// </summary>
        /// <returns>Returns the current number of requested meals.</returns>
        public int getcount()
        {
            return count;
        }

        /// <summary>
        /// Returns the image of the specified meal.
        /// </summary>
        /// <param name="index">Current index number of the request meals list.</param>
        /// <returns>Image of the current requested meal.</returns>
        public Image getimg(int index)
        {
            return images[index];
        }

        /// <summary>
        /// Changes the scale of an image to an appropriate form.
        /// </summary>
        /// <param name="image">Original image.</param>
        /// <returns>Scaled version of the image</returns>
        public Image ScaleImage(Image image)
        {
            int maxWidth = 342;
            int maxHeight = 229;
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
