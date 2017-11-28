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
        Meal[] selectedItems;
        PayPlan pp;
        //OrderSummaryPage orderPage;

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
                cust.removeItem(m);
                return true;
            }
            return false;
        }

    }
}
