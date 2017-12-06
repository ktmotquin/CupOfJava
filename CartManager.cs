using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    class CartManager
    {
        const int MAX_SIZE = 50;
        int index = -1;
        Customer cust;
        Meal[] selectedItems = new Meal[MAX_SIZE];
        OrderSummary orderPage;

        public CartManager(Customer c)
        {
            cust = c;
            orderPage = new OrderSummary();
            orderPage.Hide();
        }

        public void emptyCart()
        {
            foreach (Meal m in cust.getCart())
                cust.removeItem(m);
        }

        public bool addToOrder(Meal m)
        {
            if (cust.getCartCounter()[findIndex(m)] < cust.getNumMeals())
            {
                selectedItems[++index] = m;
                cust.setNumMeals(-cust.getCartCounter()[findIndex(m)]);
                cust.removeItem(m);
                return true;
            }
            return false;
        }

        private int findIndex(Meal m)
        {
            int index;
            for (index = 0; index < cust.getCartMeals(); index++)
                if (cust.getCart()[index] == m)
                    break;
            return index;
        }

        public void processOrder()
        {
            orderPage.Show();
            orderPage.display(selectedItems); 
            orderPage.displayCount(cust.getNumMeals());
            mealsSoldStats(selectedItems);
        }

        public void mealsSoldStats(Meal [] m)
        {
            string toBeWrit = "1\n";
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\StatsPieGraph.txt");
            //var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Joe's link
            int counter = 0; 

            for (int i = 0; i > m.Length; i++)
            {
                if (!found)
                {
                    String line = m[i] + "~";
                    toBeWrit += m[i];
                }
                else
                    counter++;

            }
        }

    }
}
