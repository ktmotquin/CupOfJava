using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    class MealList
    {
        int count = 0;
        Meal[] meals = new Meal[100];
        public MealList()
        {
            count = 0;
            for (int i = 0; i < 100; i++)
                meals[i] = null;
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