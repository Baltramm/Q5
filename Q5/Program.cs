﻿using System;

namespace Q5
{
    class Program
    {

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SortArray(array);
            }

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

        }
        static int[] SortArray(int[] result)
        {

            int temp;
            for (int i = 0; i < result.Length; i++)
            {


                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }

            }
            return result;
        }
        
    }
}

