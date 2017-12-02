using System.Drawing;

namespace OOAD_Project
{
    public class Meal
    {
        string n;
        string des;
        string type;
        string inst;
        string ing;
        string img;

        public Meal(string name, string description, 
            string mealtype, string instructions, 
            string ingredients, string imgfilename)
        {
            n = name.ToUpper();
            des = description;
            type = mealtype.ToLower();
            inst = instructions;
            ing = ingredients;
            img = imgfilename;
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

        //----------------------------------------------------------------
        // Getter methods for all private members in Meal class
        //----------------------------------------------------------------
        public string name() { return n; }
        public string mealtype() { return type; }
        public string description() { return des; }
        public string instructions() { return inst; }
        public string ingredients() { return ing; }
        public string getimg() { return img; }

    }
}
