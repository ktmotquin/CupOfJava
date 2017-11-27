using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace OOAD_Project
{
    class RequestMealQueue
    {
        int count = 0;
        Meal[] meals = new Meal[100];
        Image[] images = new Image[100];
        public RequestMealQueue()
        {
            string text;

            bool done = false;  // True when end of user list has been reached
                                //  var fileStream = new FileStream(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read); // Joe's link
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\MealRequests.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {


                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    if (!text.Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("1"))
                        {
                            String[] parts = text.Split('$');      // Breaks the current line into parts
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
            fileStream.Close();

            for (int i = 0; i < count; i++)
            {
                string filestring = meals[i].getimg();
                string test = Directory.GetCurrentDirectory() + @"\" + filestring;
                images[i] = Image.FromFile(test);
                // string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\" + filestring);

            }
        }

        public int searchList(string mealname)
        {
            // mealname = mealname.ToUpp();
            for (int i = 0; i < count; i++)
            {
                if (mealname == meals[i].name())
                    return i;
            }
            return -1;
        }
        public bool searchtype(string type, int index)
        {

            if (type == meals[index].mealtype())
            {
                return true;
            }
            else
                return false;
        }
        public Meal sendmeal(int index)
        {
            return meals[index];
        }
        public bool checktype(int index, string type)
        {
            if (index == -1)
                return false;
            if (meals[index].mealtype() == type)
                return true;
            else
                return false;
        }
        public int getcount()
        {
            return count;
        }
        public Image getimg(int index)
        {
            return images[index];
        }
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
        //addMeal()
        // name.ToLower()
    }
}
