using System.Drawing;

namespace OOAD_Project
{
    public class Meal
    { 
        private string n;
        private string des;
        private string type;
        private string inst;
        private string ing;
        private string img;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="mealtype"></param>
        /// <param name="instructions"></param>
        /// <param name="ingredients"></param>
        /// <param name="imgfilename"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newdescription"></param>
        public void changeDescription(string newdescription)
        {
            des = newdescription;   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newName"></param>
        void changeName(string newName)
        {
            n = newName;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newinstructions"></param>
        void changeinstructions(string newinstructions)
        {
            inst = newinstructions;
        }

        //----------------------------------------------------------------
        // Getter methods for all private members in Meal class
        //----------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string name() { return n; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string mealtype() { return type; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string description() { return des; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string instructions() { return inst; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ingredients() { return ing; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getimg() { return img; }
    }
}
