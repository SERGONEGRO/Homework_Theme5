using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 5.Написание функции Аккермана с применением рекурсии

//Что нужно сделать
//Напишите метод, принимающий два числа ― n и m. Этот метод вычисляет
//функцию Аккермана и возвращает результат в виде числа.


namespace Homework_Theme5_Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число m: ");
            int n = EnterNumber();
            Console.Write("Введите число n: ");
            int m = EnterNumber();

            Console.WriteLine($"Функция Анкермана от {m} и {n} равна: {AnkerManFunc(m, n)}");

        }
        /// <summary>
        /// Вычисляет функцию анкермана рекурсией
        /// </summary>
        /// <param name="m">первое число</param>
        /// <param name="n">второе число</param>
        /// <returns>результат</returns>
        static int AnkerManFunc(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return AnkerManFunc(m - 1, 1);
            if (m > 0 && n > 0) return AnkerManFunc(m - 1, AnkerManFunc(m, n - 1));
            return AnkerManFunc(m, n);
        }

        /// <summary>
        /// Проверка введенного символа на принадлежность к числам
        /// </summary>
        /// <returns>Если символ = числу, возвращает это число</returns>
        static int EnterNumber()
        {
            string s;
            do
            {
                s = Console.ReadLine();
            }
            while (s != "0" && s != "1" && s != "2" && s != "3" && s != "4" && s != "5" && s != "6" && s != "7" && s != "8" && s != "9");

            return Int32.Parse(s);
        }
    }
}
