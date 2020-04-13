using System;
using System.Collections.Generic;
using System.Text;

namespace DCP.Exercises.Problem_001
{
    /*
     * Good morning! Here's your coding interview problem for today.

This problem was recently asked by Google.

Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

Bonus: Can you do this in one pass?
     * */
    public class Problem
    {
        private readonly int[] input;

        public Problem(int[] input)
        {
            this.input = input;
        }

        public bool Solve(int k)
        {
            var set = new HashSet<int>(input);
            
            foreach (var item in set)
            {
                var remainder = k - item;
                if (set.Contains(remainder) && (remainder) != item)
                    return true;
            }

            return false;
        }
    }
}
