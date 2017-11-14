using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    class Meal
    {
        string n;
        string des;
        string type;
        int numorder;

 public Meal(string name, string description, string mealtype, int ordernumber)
        {
            n = name.ToLower();
            des = description;
            type = mealtype.ToLower();
            numorder = 0;

        }
 public       void changeDescription(string newdescription)
        {
            des = newdescription;   
        }
        void changeName(string newName)
        {
            n = newName;
        }
        void addOrder()
        {
            numorder++;
        }
    public    string name()
        {
            return n;
        }
        public string mealtype()
        {
            return type;
        }
    }
}
