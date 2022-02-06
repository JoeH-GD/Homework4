using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Homework4
{
    struct Account
    {
        string loggin;
        string password;

        public static string[] LogFromFile(String fileName)
        {
            if (!File.Exists(fileName)) return null;

            string[] arr = new string[50];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                arr[counter] = line;
                counter++;
            }

            string[] correctData = new string[counter];

            Array.Copy(arr, correctData, counter);
            sr.Close();

            return correctData;
        }

//Решено через костыль, но работает стабильно
        public static bool Authorisation(string [] correctData, string loggin, string password)
        {
            bool isOk = false;

//Склеиваем логин и пароль в одну строку через пробел (так пара логин-пароль хранится в массиве)
            string EnteredData = (loggin + " " + password);
            Console.WriteLine(EnteredData);

            int DataCheck = 0;

//Проверка строк из массива и введенных пользователем на равенство
            for (int i =0; i<correctData.Length; i++)
            {
                if (string.Compare(correctData[i], EnteredData) == 0)  DataCheck++;
                Console.WriteLine(DataCheck);
            }

            if (DataCheck == 1) isOk = true;

            return isOk;
        }
        
    }
    class ArrayAuthorise
    {
        static void Main (string[] args)
        {

            string[] trueData = Account.LogFromFile(AppDomain.CurrentDomain.BaseDirectory + "LogAndPass.txt");

            int counter = 3;

            // Переменная нужна, чтобы сохранить результат, который вернет метод авторизации
            bool isAutorized = false;

            do
            {

            //Запрашиваем ввод от пользователя и сохраняем его в переменные
               Console.Write("Enter the login:");
               string loggin = Console.ReadLine();
               Console.Write("Enter the password:");
               string password = Console.ReadLine();

                isAutorized = Account.Authorisation(trueData, loggin, password);

            //    //Предупредим пользователя о количестве оставшихся попыток
             counter--;
            Console.WriteLine("You have {0} attempts left", counter);

            // Если пользователь успешно авторизовался - нужно прервать цикл до выполнения условий
               if (isAutorized == true)
             {
                Console.WriteLine("congrats! You're in!");

                break;
              }

            }
            while (counter > 0);

            ////Сообщение выводится только если авторизация все еще не пройдена после трех попыток
            if (isAutorized == false)
            {
                Console.WriteLine("You've tried three times. The system is temporary blocked. Try again later.");
            }

            Console.ReadLine();
        }
    }
}
