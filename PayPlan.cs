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
        int numPeople, mealCount, maxMeals, plan;
        const int MIN_PEOPLE = 2, MEALS_PER_WEEK = 4;
        const float BASE_PRICE = 8.50f, ADDITIONAL_PERSON_PRICE = 6.50f;
        enum planType { twoPerson, family };

        public PayPlan(int ppl)
        {
            numPeople = ppl;
            mealCount = 0;
            if(numPeople == MIN_PEOPLE)
            {
                maxMeals = MEALS_PER_WEEK;
                price = BASE_PRICE * MIN_PEOPLE * MEALS_PER_WEEK;
                plan = (int)planType.twoPerson;
            }
            else if(numPeople > MIN_PEOPLE)
            {  
                maxMeals = MEALS_PER_WEEK * numPeople;
                price = BASE_PRICE * MIN_PEOPLE + 
                    ADDITIONAL_PERSON_PRICE * (numPeople - MIN_PEOPLE);
                plan = (int)planType.family;
            }
        }

    }
}
