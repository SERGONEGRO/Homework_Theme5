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
           
            double[] numbers = new double[] { 0,1};

            if (numbers.Length>=3)  Console.WriteLine(CheckNumbers(numbers));
            else Console.WriteLine("Для определения типа прогрессии нужно минимум три числа.");

        }
        /// <summary>
        /// Принимает массив чисел и проверяет, если ли в них прогрессия
        /// </summary>
        /// <param name="nums">массив чисел</param>
        /// <returns>строка</returns>
        static string CheckNumbers(double[] nums)
        {
            string str="";
            bool flagAP = true;
            bool flafGP = true;
            for (int i = 1; i<nums.Length-1;i++)
            {
                if ((nums[i] - nums[i - 1]) != (nums[i + 1] - nums[i])) flagAP = false;
                if(nums[i-1] !=0 || nums[i]!=0)
                if ((nums[i] / nums[i - 1]) != (nums[i + 1] / nums[i])) flafGP = false;
            }

            if (flagAP) str += "Найдена Арифметическая прогрессия\n";
            if (flafGP) str += "Найдена Геометрическая прогрессия\n";
            if (str == "") str = "Прогрессии отсутсвуют";

            return str;
        }
    }
}
