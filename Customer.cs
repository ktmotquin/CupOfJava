﻿namespace OOAD_Project
{
    public class Customer
    {
        const int MAXMEALS = 30;
        string email, password, phoneNum, address, username, name,
            creditcard, securitynum, expdate;
        int next = 0, numMeals = 0, cartMeals = 0;
        Meal[] cart = new Meal[MAXMEALS];
        int[] cartCounter = new int[MAXMEALS];

        public Customer(string u, string pass, string n, 
            string e, string p, string a, string c,
            string s, string ed, int meals)
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
            numMeals = meals;
        }

        public Customer(Customer c)
        {
            name = c.name;
            password = c.password;
            username = c.username;
            email = c.email;
            phoneNum = c.phoneNum;
            address = c.address;
            creditcard = c.creditcard;
            securitynum = c.securitynum;
            expdate = c.expdate;
        }

        public void setNumMeals(int n) { numMeals += n; }

        //----------------------------------------------------------------
        // Getter methods for all private members of Customer class
        //----------------------------------------------------------------
        public string getuser() { return username; }
        public int getCartMeals() { return cartMeals; }
        public int getNumMeals() { return numMeals; }
        public string getname() { return name; }
        public string getpassword() { return password;}
        public string getemail(){ return email;}
        public string getphone() { return phoneNum; }
        public string getaddress() { return address; }
        public string getcreditcard() { return creditcard; }
        public string getsecuritynum() { return securitynum; }
        public string getexpdate() { return expdate; }
        public Meal[] getCart() { return cart; }
        public int[] getCartCounter() { return cartCounter; }

        //----------------------------------------------------------------
        // Clears the entire cart upon completion of an order or deletion
        // of a user's account.
        //----------------------------------------------------------------
        public void emptyCart()
        {
            for (int i = 0; i < cart.Length; i++)
            {
                cart[i] = null;
                cartCounter[i] = 0;
            }
            next = numMeals = 0;
        }

        //----------------------------------------------------------------
        // Adds a meal to the next available index of the cart array,
        // and increments the number of meals currently in cart[].
        //----------------------------------------------------------------
        public void addToCart(Meal m, int i)
        {
            int index = findCartItem(m);
            if (index != -1)
            {
                cartCounter[index] += i;
                cartMeals += i;
            }
            else
            {
                cart[next] = m;
                cartCounter[next++] = i;
                cartMeals += i;
            }
            
        }


        //----------------------------------------------------------------
        // Removes an item at its index and shifts all other elements
        // up in the array
        //----------------------------------------------------------------
        public void removeItem(Meal m)
        {
            int index = findCartItem(m);
            if (index != -1)
            { 
                cartMeals -= cartCounter[index];
                for (int i = index + 1; i < cart.Length; i++)
                {
                    cart[i - 1] = cart[i];
                    cartCounter[i - 1] = cartCounter[i];
                }
                --next;
            }
        }

        //----------------------------------------------------------------
        // Finds and returns the index of the specified meal in cart
        //----------------------------------------------------------------
        public int findCartItem(Meal m)
        {
            if (cart[0] != null)
            {
                for (int i = 0; i < cart.Length; i++)
                {
                    if(cart[i] != null)
                        if (cart[i].name() == m.name())
                            return i;
                }
            }
            return -1;
        }

    }
}
