using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class ArrayLibrary
    {
  
        
        //Распечатать 
        public void PrintArray(int arr[])
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        //сменить знак
        public int[] Inverse(int[] arr)
        {
            int[] arrInverted = new int[arr.Length];
            Array.Copy(arr, arrInverted, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                arrInverted[i] = -arrInverted[i];
            }

            return arrInverted;
        }

        //умножить на одно и то же число каждый элемент массива
        public int[] Multi(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * n;
            }
            return arr;
        }


        //Метод для перевода чисел записаных в одну строку типа 123343653 в массив
        static int[] intToArray(string num)
        {
            //измеряем длину строки, она будет длиной массива 
            int[] arrayNumber = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {

                //Я видел решения лучше, но они сложнее для понимания, сделал сам через перменную-костыль
                //В нее записывается поочередно кайдый символ в строке
                char x = num[i];
                // символ конвертируется в число и записывается в соответствующую ячейку массива
                arrayNumber[i] = (Convert.ToInt32(x) - 48);
            }

            return arrayNumber;
        }

        //Ну а вдруг все-таки надо поменять размер массива...
        static int[] ChangeArrayLength(int[] n, int newLength)
        {
            int length = 0;
            length = n.Length;
            Array.Resize(ref n, newLength);
            length = n.Length;
            return n;
        }


        static int FindMaxNumber()
        {

        }
    }
}

