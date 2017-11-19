﻿using System;
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
        string inst;
        string ing;

        public Meal(string name, string description, 
            string mealtype, string instructions, string ingredients)
        {
            n = name.ToLower();
            des = description;
            type = mealtype.ToLower();
            inst = instructions;
            ing = ingredients.ToLower();
        }
        public void changeDescription(string newdescription)
        {
            des = newdescription;   
        }
        void changeName(string newName)
        {
            n = newName;
        }
        void changeinstructions(string newinstructions)
        {
            inst = newinstructions;
        }
        public string name()
        {
            return n;
        }
        public string mealtype()
        {
            return type;
        }
        public string description()
        {
            return des;
        }
        public string instructions()
        {
            return inst;
        }
        public string ingredients()
        {
            return ing;
        }
    }
}
