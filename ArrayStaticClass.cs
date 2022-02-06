using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Homework4
{
   public static class ArrayOperations
    {

        public static int PairCheck(int[] arr)
        {
            int counter =0;

            for (int i = 0; i < (arr.Length -1); i++)
            {
                if (arr[i]%3 == 0 ^ arr[i + 1] % 3 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int[] ArrayFromFile(String fileName)
        {
            if (!File.Exists(fileName)) return null;

            int[] arr = new int [1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++;
            }

            int[] newArr = new int[counter];

            Array.Copy(arr, newArr, counter);
            sr.Close();
            
            return newArr;
        }
    }
   public class ArrayStaticClass

    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
    
            for (int i = 0; i < 20; i++)
            
            {
                array[i] = rand.Next(-10000, 10000);
                Console.Write($"{array[i]}\t");
            }

            Console.WriteLine();
            Console.WriteLine ("The number of pairs is {0}", ArrayOperations.PairCheck(array));

            int[] arrayFile = ArrayOperations.ArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "Value.txt");

            Console.WriteLine();
            Console.WriteLine("The numbers in file are:");

            for (int i = 0; i<arrayFile.Length; i++)
            {
                Console.Write($"{arrayFile[i]}\t");
            }

            Console.ReadLine();
        }
    }
}
