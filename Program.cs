using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int minValue = 0;
            int maxValue = 9;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(minValue, maxValue);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tempValueForChange = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tempValueForChange;
                    }
                }

                Console.WriteLine();

                for (int d = 0; d < array.Length; d++)
                    Console.Write(array[d] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();
        }
    }