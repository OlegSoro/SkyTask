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
        static void Main(string[] args)
        {
            int grade = 0;
            int sum = 0;
            float result = 0f;
            int i = 1;

            Console.WriteLine("Введите оценку студента. Числа должны быть строго от 2 до 5 включительно");
            Console.WriteLine("Для вывода результата введите 0");

            while (i > 0)
            {
                grade = int.Parse(Console.ReadLine());

                if (grade >= 2 && grade <= 5)
                {
                    sum = sum + grade;                   
                    i++;
                }

                else
                {
                    if (grade == 0)
                    {
                        break;
                    }
                Console.WriteLine("Ошибка. Вы ввели неверное число");
                }
            }

            result = (float)sum / (i-1);
            //Console.WriteLine("Средняя оценка студента " + result);
            Console.WriteLine("Средняя оценка студента " + "{0: 0.0}",result);

            if (result > 3.5)
            {
                Console.WriteLine("Поздравляем!!! Вы сдали");
            } 
            else
            {
                Console.WriteLine("К сожалению, вы провалились");
            }

            
        }
    }
}
