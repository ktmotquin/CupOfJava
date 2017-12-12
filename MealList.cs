using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace OOAD_Project
{
    class MealList
    {
        int count = 0;
        Meal[] meals = new Meal[100];
        Image[] images = new Image[100];

        /// <summary>
        /// 
        /// </summary>
        public MealList()
        {
            string text;
            bool done = false; // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
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
            fileStream.Close();

            for (int i = 0; i < count; i++)
            {
                string filestring = meals[i].getimg();
                string test = Directory.GetCurrentDirectory() + @"\" + filestring;
                images[i] = Image.FromFile(test);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Image ScaleImage(Image image)
        {
            int maxWidth = 342;
            int maxHeight = 229;
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = System.Math.Min(ratioX, ratioY);
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mealname"></param>
        /// <returns></returns>
        public int searchList(string mealname)
        {
            for (int i = 0; i < count; i++)
            {
                if (mealname.ToLower() == meals[i].name().ToLower())
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool searchtype(string type, int index)
        {
            if (type == meals[index].mealtype())
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Meal sendmeal(int index)
        {
            return meals[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool removemeal(int index)
        {
            string mealname;
            mealname = meals[index].name();
            string toBeWrit = "";
            string text;
            bool found = false;
            bool done = false;
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine(); // read next line
                    string[] stuff = text.Split('$');
                    if (!stuff[0].Equals("-1")) // Check if end of file has been reached
                    {
                        if (stuff[0].ToLower() != mealname.ToLower())
                        {
                            toBeWrit += text + '\n';
                        }
                        String[] parts = text.Split('$'); // Breaks the current line into parts
                        if (stuff[0].ToLower() == mealname.ToLower())
                        {
                            found = true;
                        }
                    }
                    else
                    {
                        done = true; // Info not found
                    }
                }
            }
            fileStream.Close();
            if (found)
            {
                toBeWrit += "-1\n";
                System.IO.File.WriteAllText(fileName, toBeWrit);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="mealName"></param>
        /// <param name="description"></param>
        /// <param name="ingredients"></param>
        /// <param name="instructions"></param>
        public void editmeal(string mealName, string description, string ingredients, string instructions)
        {
            string replaceWith = "~";
            string overallText = "1\n";
            string temp;
            string tempname;
            bool done = false; // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    temp = streamReader.ReadLine();
                    String[] parts = temp.Split('$'); // read next line
                    if (!temp.Equals("-1")) // Check if end of file has been reached
                    {
                        System.Console.WriteLine("Entered text " + temp);
                        if (!temp.Equals("1"))
                        {

                            if (parts[0].ToLower().Equals(mealName.ToLower()))
                            {
                                tempname = mealName + "$" + description.Replace("\n", replaceWith) + "$" + parts[2] + "$"
                                + instructions.Replace("\n", replaceWith) + "$" +
                                ingredients.Replace("\n", replaceWith) + "$" + parts[5] + "" + '\n';
                                overallText = overallText + tempname;
                            }
                            else
                                overallText += temp + '\n';
                        }
                    }
                    else
                    {
                        done = true; // Info not found
                    }
                }
            }
            fileStream.Close();

            overallText += "-1";
            System.IO.File.WriteAllText(fileName, overallText);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool checktype(int index, string type)
        {
            if (index == -1)
                return false;
            if (meals[index].mealtype() == type)
                return true;
            else
                return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public int getcount()
        {
            return count;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Image getimg(int index)
        {
            return images[index];
        }
    }
}