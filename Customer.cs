﻿namespace OOAD_Project
{
    public class Customer
    {
        const int MAXMEALS = 30;
        string email, password, phoneNum, address, username, name,
            creditcard, securitynum, expdate;
        int next = 0, numMeals = 0;
        //PaymentPlan currentPlan;
        Meal[] cart = new Meal[MAXMEALS];

        public Customer(string u, string pass, string n, 
            string e, string p, string a, string c, string s, string ed)
        {
            name = n;
            password = pass;
            username = u;
            email = e;
            phoneNum = p;
            address = a;
            creditcard = c;
            securitynum = s;
            expdate = ed;

        }

        //----------------------------------------------------------------
        // Getter methods for all private members of Customer class
        //----------------------------------------------------------------
        public string getuser() { return username; }
        public string getname() { return name; }
        public string getpassword() { return password;}
        public string getemail(){ return email;}
        public string getphone() { return phoneNum; }
        public string getaddress() { return address; }
        public Meal[] getCart() { return cart; }

        //public void setPayPlan(PaymentPlan pp) { currentPlan = pp; }

        //----------------------------------------------------------------
        // Clears the entire cart upon completion of an order or deletion
        // of a user's account.
        //----------------------------------------------------------------
        public void emptyCart()
        {
            for (int i = 0; i < cart.Length; i++)
                cart[i] = null;
            next = numMeals = 0;
        }

        //----------------------------------------------------------------
        // Adds a meal to the next available index of the cart array,
        // and increments the number of meals currently in cart[].
        //----------------------------------------------------------------
        public void addToCart(Meal m)
        {
            cart[next++] = m;
            ++numMeals;
        }

        //----------------------------------------------------------------
        // Removes an item at its index and shifts all other elements
        // up in the array
        //----------------------------------------------------------------
        public void removeItem(Meal m)
        {
            int index = findCartItem(m);
            if (index != -1)
                for (int i = index + 1; i < cart.Length; i++)
                    cart[i - 1] = cart[i];
        }

        //----------------------------------------------------------------
        // Finds and returns the index of the specified meal in cart
        //----------------------------------------------------------------
        public int findCartItem(Meal m)
        {
            int index = -1;
            for(int i = 0; i < cart.Length; i++)
            {
                if (cart[i].name() == m.name())
                    index = i;
                break;
            }
            return index;
        }
    }
}
