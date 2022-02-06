using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class ArrayPairs
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            int counter = 0;
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(-10000, 10000);
                Console.Write($"{array[i]}\t");
            }

            for (int i = 0; i < 19; i++)
            {
                if (array[i] % 3 == 0 ^ array[(i + 1)] % 3 == 0)
                {
                    counter++;
                }

            }

            Console.WriteLine();

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
