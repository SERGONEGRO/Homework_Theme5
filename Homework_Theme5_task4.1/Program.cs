using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 4.Написание метода, определяющего, является ли последовательность чисел прогрессией

//Напишите метод, принимающий произвольное количество чисел в виде массива, который определяет,
//являются ли эти числа арифметической или геометрической прогрессией или не являются прогрессией вовсе.


namespace Homework_Theme5_task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[] { 8, 4, 2, 3 };

            Console.WriteLine(CheckNumbers(numbers));

        }
        /// <summary>
        /// Принимает массив чисел и проверяет, если ли в них прогрессия
        /// </summary>
        /// <param name="nums">массив чисел</param>
        /// <returns>строка</returns>
        static string CheckNumbers(int[] nums)
        {
            for(int i = 1; i<nums.Length-1;i++)
            {
                if ((nums[i] - nums[i - 1]) == (nums[i + 1] - nums[i])) return "Есть Арифметическая прогрессия";
                if ((nums[i]/nums[i-1]) == (nums[i + 1] / nums[i])) return "Есть Геометрическая прогрессия";
            }
                       
            return "Никакой прогрессии нет";
        }
    }
}
