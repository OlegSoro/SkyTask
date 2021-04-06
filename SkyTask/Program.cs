using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyTask
{

    //Написать программу которая считает средне арифметическую оценку одного студента.
    //Количество оценок разное. Если средний бал ниже 3,5 сообщение вы провалились,
    //иначе поздравляю вы сдали.

    class Program
    {

        static void Query()
        {
            Console.WriteLine("Введите оценку студента. Числа должны быть строго от 2 до 5 включительно");
        }

        static float MiddleGrade(int x, int y, float z)
        {           
            z = (float)x / y;
            Console.WriteLine("Средняя оценка студента " + "{0: 0.0}", z);
            return z;
        }

        static void Result(float x)
        {
            if (x >= 3.5)
            {
                Console.WriteLine("Поздравляем!!! Вы сдали");
            }
            else
            {
                Console.WriteLine("К сожалению, вы провалились");
            }
        }

        static void Main(string[] args)
        {
            int sum = 0;
            float result = 0f;
            int i = 1;

            Query();

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] str = Console.ReadLine().Split(delimiterChars);

            try
            {
                int[] arr = str.Select(j => int.Parse(j)).ToArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] >= 2 && arr[j] <= 5)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!! Вы ввели недопустимые числа" + "\nНажмите Escape для выхода");
                        while (true)
                        {
                            var key = Console.ReadKey();
                            if (key.Key == ConsoleKey.Escape)
                            {
                                return;
                                //Или Environment.Exit(0);
                            }
                            else
                                Console.WriteLine("Неверно! Повторите попытку");
                        }
                    }
                }
                sum = arr.Sum();
                i = arr.Length;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка!!! Вы ввели недопустимый символ" + "\nНажмите Escape для выхода");
                while (true)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                        //Или Environment.Exit(0);
                    }
                    else
                        Console.WriteLine("Неверно! Повторите попытку");
                }
            }
            result = MiddleGrade(sum, i, result);

            Result(result);
        }
    }
}
