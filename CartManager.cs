using System;
using System.IO;
using System.Text;

namespace OOAD_Project
{
    class CartManager
    {
        const int MAX_SIZE = 50;
        int index = -1;
        Customer cust;
        Meal[] selectedItems = new Meal[MAX_SIZE];
        int[] quantities = new int[MAX_SIZE];
        OrderSummary orderPage;

        public CartManager(Customer c)
        {
            cust = c;
            orderPage = new OrderSummary();
            orderPage.Hide();
        }

        /// <summary>
        /// Removes all meal objects from the 
        /// current user's cart array
        /// </summary>
        public void emptyCart()
        {
            foreach (Meal m in cust.getCart())
                cust.removeItem(m);
        }

        /// <summary>
        /// Adds a meal object to the selected items array if the customer has not exceeded their maximum number of meals,
        /// and removes the number of units from the user's maximum number of meals.
        /// </summary>
        /// <param name="m">Meal object to be added to the 
        /// order and removed from the customer's cart</param>
        /// <returns>Returns true if meal successfully added to the order, false otherwise</returns>
        public bool addToOrder(Meal m)
        {
            if (cust.getCartCounter()[findIndex(m)] <= cust.getNumMeals())
            {
                selectedItems[++index] = m;
                cust.setNumMeals(-cust.getCartCounter()[findIndex(m)]);
                quantities[index] = cust.getCartCounter()[findIndex(m)];
                cust.removeItem(m);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finds the index of a meal object in the current customer's cart array
        /// </summary>
        /// <param name="m">Meal object to be searched for</param>
        /// <returns>Index of the meal in cart array OR -1 if meal wasn't found</returns>
        private int findIndex(Meal m)
        {
            int index;
            for (index = 0; index < cust.getCartMeals(); index++)
                if (cust.getCart()[index] == m)
                    return index;
            return -1;
        }

        /// <summary>
        /// Creates an order summary page and populates it with the "purchased" meal objects,
        /// and calls mealsSoldStats to update the system's statistics.
        /// </summary>
        public void processOrder()
        {
            orderPage.Show();
            orderPage.display(selectedItems);
            orderPage.displayCount(cust.getNumMeals());
            mealsSoldStats(selectedItems);
        }

        /// <summary>
        /// Updates the number of units sold of all meals in a meal array
        /// </summary>
        /// <param name="m">Array of meals to update stats for</param>
        public void mealsSoldStats(Meal[] m)
        {

            string toBeWrit = "$\n";
            string text;
            bool found = false; // True if an account is associated with the login info
            bool done = false;  // True when end of user list has been reached
            string numsFileName = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\OrderStats.txt");
            string pieFileName = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\StatsPieGraph.txt");
            var fileStream = new FileStream(numsFileName, FileMode.Open, FileAccess.Read); // Joe's link
                                                                                           //var fileStream = new FileStream(@"C:\Users\ktmot\Documents\CupOfJava\trunk\LoginInfo.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while (!done)
                {
                    text = streamReader.ReadLine();         // read next line


                    if (!text.Equals("-$"))                 // Check if end of file has been reached 
                    {
                        if (!text.Equals("$"))
                        {
                            string[] stuff = text.Split('~');
                            for (int i = 0; i <= index; i++)
                            {
                                if (stuff[0] == m[i].name())
                                {
                                    int oldnum = Int32.Parse(stuff[1]) + quantities[i];
                                    toBeWrit = toBeWrit + m[i].name() + '~' + oldnum + '\n';
                                    Meal temp = m[index];
                                    m[i] = temp;
                                    m[index] = null;
                                    index--;
                                    found = true;
                                }
                            }
                            if(!found)
                            {
                                toBeWrit += text + '\n';
                            }
                        }

                    }
                        else
                        {
                            for (int i = 0; i <= index ; i++)
                            {
                                toBeWrit = toBeWrit + m[i].name() + '~' + quantities[i] + '\n';
                            }
                            done = true;                        // Info not found
                        }

                }
                toBeWrit += "-$";
                fileStream.Close();
                System.IO.File.WriteAllText(numsFileName, toBeWrit);
            }

        }

    }
}
