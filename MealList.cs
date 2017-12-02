using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace OOAD_Project
{
    class MealList
    {
        int count = 0;
        Meal[] meals = new Meal[100];
        Image[] images = new Image[100];
        public MealList()
        {
            string text;

            bool done = false;  // True when end of user list has been reached
                                //  var fileStream = new FileStream(@"C:\Users\restore\Documents\Visual Studio 2015\Projects\OOAD Project\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read); // Joe's link
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
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
                                                                                       //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    string[] stuff = text.Split('$');
                    if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (stuff[0].ToLower() != mealname.ToLower())
                        {
                            toBeWrit += text + '\n';
                        }

                        String[] parts = text.Split('$');      // Breaks the current line into parts
                        if (stuff[0].ToLower() == mealname.ToLower())
                        {
                            found = true;
                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
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
        public bool editmeal(string mealname, string description, string ingredients, string instructions)
        {

            string toBeWrit = "";
            string text;
            bool found = false;
            bool done = false;
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\Meals.txt");
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
                                                                                       //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line

                    string[] stuff = text.Split('$');
                    if (!stuff[0].Equals("-1"))                 // Check if end of file has been reached 
                    {
                        if (stuff[0].ToLower() != mealname.ToLower())
                        {
                            toBeWrit += text + '\n';
                        }

                        String[] parts = text.Split('$');      // Breaks the current line into parts
                        if (stuff[0].ToLower() == mealname.ToLower())
                        {
                            found = true;
                            stuff[1] = description;
                            stuff[3] = instructions;
                            stuff[4] = ingredients;
                            toBeWrit = toBeWrit + stuff[0] + "$" + stuff[1] + "$" + stuff[2] + "$" + 
                                stuff[3] + "$" + stuff[4] + "$" + stuff[5] + '\n';

                        }
                    }
                    else
                    {
                        done = true;                        // Info not found
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