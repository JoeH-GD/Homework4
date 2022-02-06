using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArrayLibrary;
using System.Threading.Tasks;

namespace Homework4
{
    public class MyArray
    {
        #region Поля

        private int[] arr;

        #endregion

        #region Properties

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        public int Summ
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < arr.Length; i++)
                {

                    summ += arr[i];
                }

                return summ;
            }
        }

        //Возвращаем количество максимальных значений 
        public int MaxCount
        {
            get
            {
                int maxCount = 0;

                Array.Sort(arr);

                //После сотртировки максимальные значения должны быть в конце массива
                //Смотрим сколько ячеек с конца заполнены такими же значениями
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] == arr[arr.Length - 1])
                    {
                        maxCount++;
                    }

                    //Как только равенство не соблюдается цикл можно прервать 
                    else break;
                }

                return maxCount;
            }
        }

        #endregion

        #region Constructors

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        //Заполнение от начального значения с заданным шагом
        public MyArray(int[] arr, int a, int b, int size)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = a;
                a += b;
            }

            this.arr = arr;
        }
        #endregion


        #region Methods

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        public static int[] Inverse(int[] arr)
        {
            int[] arrInverted = new int[arr.Length];
            Array.Copy(arr, arrInverted, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                arrInverted[i] = -arrInverted[i];
            }

            return arrInverted;
        }

        public static int[] Multi(int[] arr,int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i]*n;
            }
            return arr;
        }

        #endregion


        class Class2
        {
            static void Main(string[] args)
            {
                #region LibraryMethods
                //Демонстрация работы метода из библиотеки
                string numToArray = "142775675346890568";
                int[] newArr = ArrayLibrary.ArrayLibrary.intToArray(numToArray);
                for (int i =0; i<newArr.Length; i++)
                {
                    Console.Write($"{newArr[i]}\t");
                }

//Демонстрация работы другого методе из библиотеки
                Console.WriteLine();
                Console.WriteLine("Current array length is " + newArr.Length);

                newArr = ArrayLibrary.ArrayLibrary.ChangeArrayLength(newArr, 30);

                Console.WriteLine("New array length is {0}",newArr.Length);
                #endregion

                int[] arr = new int[30];
                MyArray localArray = new MyArray(arr, 100, 10, 30);

                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {

                    Console.Write($"{localArray[i]}\t");
                }
               
                Console.WriteLine();
                arr = Multi(arr, 5);

                for (int i = 0; i < arr.Length; i++)
                {
                    
                    Console.Write($"{arr[i]}\t");
                }


                Console.WriteLine();
                arr = Inverse(arr);

                PrintArray(arr);

                Console.ReadLine();
            }

        }
    }
}