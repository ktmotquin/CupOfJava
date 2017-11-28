using System;
using System.Collections.Generic;
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
            pp = new PayPlan(p);
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
            /*orderPage.display(selectedItems); 
             * orderPage.displayCount(cust.getPayPlan().getCount()); */
        }

    }
}
