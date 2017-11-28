using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project
{
    public class PayPlan
    {
        float price;
        int mealCount, maxMeals;
        const int MAX_MEALS = 50;
        const float PRICE_PER_MEAL = 8.50f;

        public PayPlan()
        {
            mealCount = 0;
            maxMeals = MAX_MEALS;
            price = PRICE_PER_MEAL * MAX_MEALS;
        }

        public PayPlan(PayPlan other)
        {
            price = other.price;
            mealCount = other.mealCount;
            maxMeals = other.maxMeals;
        }

        public int getCount() { return mealCount; }
        public int getMaxMeals() { return maxMeals; }
        public int getRemaining() { return maxMeals - mealCount; }
        public void increaseMealCount(int num) { mealCount += num; }
        public void subtractMeals(int num) { mealCount -= num; }
    }
}
