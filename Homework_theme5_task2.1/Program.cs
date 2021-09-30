using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Первый метод принимает строку с текстом и возвращает строку, содержащую слово с минимальной длиной.
//Второй метод также принимает на вход текст, но возвращает одно или несколько слов с максимальной длиной.

namespace Homework_theme5_task2._1
{
    class Program
    {
        static char[] charSeparators = new char[] { ' ' };   //разделитель слов
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");
            string str = Console.ReadLine();

            Console.WriteLine($"Минимальное по длине слово (слова) : ");

            string[] resultMin = ReturnMinWord(str);
            foreach (var e in resultMin) Console.WriteLine(e);

            Console.ReadKey();

            Console.WriteLine($"Максимальное по длине слово (слова) : ");

            string[] resultMax = ReturnMaxWord(str);
            foreach (var e in resultMax) Console.WriteLine(e);



        }

        /// <summary>
        /// Метод, принимающий строку и возвращающий массив минимальных по длине строк
        /// </summary>
        /// <param name="s">Входная строка</param>
        /// <returns></returns>
        static string[] ReturnMinWord(string s)
        {
            //разделяем строку на массив слов
            string[] result = s.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            //ищем длину минимального слова
            int minLenght = (from n in result select n.Length).Min();

            //заполняем массив всеми словами, чья длина = минимальной
            string[] minWords = Array.FindAll(result, x => x.Length == minLenght);

            return minWords;
        }

        /// <summary>
        /// Метод, принимающий строку и возвращающий массив максимальных по длине строк
        /// </summary>
        /// <param name="s">Входная строка</param>
        /// <returns></returns>
        static string[] ReturnMaxWord(string s)
        {
            //разделяем строку на массив слов
            string[] result = s.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            //ищем длину максимального слова
            int maxLenght = (from n in result select n.Length).Max();

            //заполняем массив всеми словами, чья длина = максимальной
            string[] minWords = Array.FindAll(result, x => x.Length == maxLenght);

            return minWords;
        }
    }
}
