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
        PayPlan pp;
        OrderSummary orderPage;

        public CartManager(Customer c, PayPlan p)
        {
            cust = new Customer(c);
            pp = p;
            //pp = new PayPlan(p);
            orderPage = new OrderSummary();
            orderPage.Hide();
        }

        public void emptyCart()
        {
            foreach (Meal m in cust.getCart())
                cust.removeItem(m);
        }

        public bool add(Meal m)
        {
            if (cust.getPayPlan().getCount() < cust.getPayPlan().getMaxMeals())
            {
                selectedItems[++index] = m;
                cust.getPayPlan().increaseMealCount(1);
                cust.removeItem(m);
                return true;
            }
            return false;
        }

        public void processOrder()
        {
            //orderPage.Show();
            //orderPage.display(selectedItems); 
            //orderPage.displayCount(cust.getPayPlan().getCount());
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
