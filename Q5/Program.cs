using System;

namespace Q5
{
    class Program
    {

        static void SortArray(in int[] array,out int[] sorteddesc,out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);
        }



        static int[] SortArrayDesc(int[] result)
        {
            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        static int[] SortArrayAsc(int[] result)
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


        static int[] GetArray(ref int num)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static void GetName(ref string  name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        

        static void Main(string[] args)
        {
            var someName = "Евгения";
            Console.WriteLine(someName);
            GetName(ref someName);
            Console.WriteLine(someName);
        }
    }
}

