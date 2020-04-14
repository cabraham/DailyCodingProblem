using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCP.Exercises.Problem_002
{
    /*
     * Good morning! Here's your coding interview problem for today.

This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
     */

    public class Problem
    {
        private readonly int[] input;

        public Problem(int[] input)
        {
            this.input = input;
        }

        public int[] Solve()
        {
            var arr = new int[input.Length];
            Array.Copy(input, arr, input.Length);

            for (var i = 0; i < arr.Length; i++)
            {
                var product = 1;
                for (var j = 0; j < input.Length; j++)
                {
                    if (j == i)
                        continue;

                    product *= input[j];
                }

                arr[i] = product;
            }

            return arr;
        }
    }
}
