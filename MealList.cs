using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOAD_Project
{
    class MealList
    {
        int count = 0;
        Meal[] meals = new Meal[100];
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
                           String[] parts = text.Split('/');      // Breaks the current line into parts
                           meals[count] = new Meal(parts[0], parts[1], parts[2], parts[3], parts[4]);
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
        }

        public void addMeal(Meal newMeal)
        {
            meals[count] = newMeal;
            count++;
        }
        public int searchList(string mealname)
        {
            mealname = mealname.ToLower();
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
            if (meals[index].mealtype() == type)
                return true;
            else
                return false;
        }
        public int getcount()
        {
            return count;
        }
        //addMeal()
        // name.ToLower()
    }
}