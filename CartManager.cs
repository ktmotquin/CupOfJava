using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    class CartManager
    {
        Customer cust;
        PayPlan pp;
        //OrderSummaryPage orderPage;

        public CartManager(Customer c, PayPlan p)
        {
            cust = new OOAD_Project.Customer(c);
        }

        public void emptyCart()
        {
            foreach (Meal m in cust.getCart())
                cust.removeItem(m);
        }

        public float calculatePrices()
        {
            return 0.0f;
        }
    }
}
