using System;

namespace TwoDimArray
{
    public class TwoDimantionalArray
    {
        int[,] arrTwo;


        // Конструктор со случайными числами

        public TwoDimantionalArray(int[,] arrTwo)
        {
            arrTwo = ArrayRandom(int[,] arrTwo);
        }


        public int MaxNum
        {
            get
            {
                int max = FindMaxElement(int[,] arrTwo);
                return max;
            }
        }

        public int MinNum
        {
            get
            {
                int min = FindMinElement();
                return min;
            }
             
        }

        //Метод заполнения случайными числами
        public int[,] ArrayRandom(int[,] arrTwo)
        {
            Random r = new Random();
            for (int i = 0; i < arrTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrTwo.GetLength(1); j++)
                {
                    arrTwo[i, j] = r.Next();
                }
            }

            return arrTwo;
        }

        public int SumArray(int[,] arrTwo)
        {
            int sum = 0;
            for (int i = 0; i < arrTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrTwo.GetLength(1); j++)
                {
                    sum += arrTwo[i, j];
                }
            }

            return sum;
        }

//Если речь идет о сумме значений элементов выше именно заданного элемента то есть ячейки, то получается такое:
        public int SumMoreThen(int[,] arrTwo, int a, int b)
        {
            int sum = 0;
            for (int i = a+1; i < arrTwo.GetLength(0); i++)
            {
                for (int j = b+1; j < arrTwo.GetLength(1); j++)
                {
                    sum += arrTwo[i, j];
                }
            }

            return sum;
        }

//Если все же имеется в виду заданное значение то будет что-то такое:

        public int SumHigherNumber(int[,] arrTwo, int a)
        {
            int sum = 0;
            for (int i = 0; i < arrTwo.GetLength(0); i++)
            {
                for (int j =0; j < arrTwo.GetLength(1); j++)
                {
                    if (arrTwo[i, j]>a) sum += arrTwo[i, j];
                }
            }

            return sum;
        }

//Ищем и возвращаем максимальный элемент        
        static int FindMaxElement(int[,] arrTwo)
        {
            int x = 0;
            int y = 0;
            int max = arrTwo[x, y];

            for (int i = 0; i < arrTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrTwo.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return max;
        }

//Никакого особого смысла, просто запоминаю, что массив можно шерстить из конца в начало тоже
        static int FindMinElement(int[,] arrTwo)
        {
            int x = (arrTwo.GetLength(0)-1);
            int y = (arrTwo.GetLength(1) - 1);
            int min = arrTwo[x, y];

//-2 чтобы сэкономить одну итерацию и не сравнивать последний элемент массива с собой же
            for (int i = (arrTwo.GetLength(0) - 2); i >= 0; i--)
            {
                for (int j = (arrTwo.GetLength(1) - 2); j >=0; j--)
                {
                    if (arrTwo[i, j] < min)
                    {
                        min = arrTwo[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            return min;

        }
      

       public int IndexMax()
        {
            
        }
    }
}
