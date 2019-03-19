using System;

/* 
 * Our task is to implement an algorithm that determines whether shoppers should take the given order or not.

 * Before taking an order a shopper wants to ensure they will make it in time but arriving early isn't an option either.
 * For each shopper you know their travel speed, distance to the store and the estimated amount of time they will spend there. 
 * Figure out which of them can take the order, assuming it is known when the customer wants to receive the groceries 
 * and the distance between their house and the store.         
 */

namespace InstaCartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // test data
            // ([200, 20, 15], [[300, 40, 5], [600, 40, 10]]);
        }

        static bool[] delivery(int[] order, int[][] shoppers)
        {
            bool[] answer = new bool[shoppers.Length];

            double custTimeLimit = order[1] + order[2];

            for (int i = 0; i < shoppers.Length; i++)
            {
                double meters = (shoppers[i][0] + order[0]);

                double bestOrderTime = (meters / shoppers[i][1]) + shoppers[i][2];

                if (bestOrderTime < custTimeLimit && bestOrderTime > order[1])
                {
                    answer[i] = true;
                }
                else
                {
                    answer[i] = false;
                }
            }
            return answer;
        }
    }
}

