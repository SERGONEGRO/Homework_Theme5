using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 3.Создание метода, принимающего строку и возвращающего новую строку, в которой удалены все рядом стоящие повторяющиеся символы

//Что нужно сделать
//Создайте метод, который принимает произвольный текст в виде строки.
//Этот метод возвращает новую строку, в которой отсутствуют все повторяющиеся, рядом стоящие символы.

//Примеры:

//ПППОООГГГООООДДДААА >>> ПОГОДА

//Ххххоооорррооошшшиий деееннннь >>> хороший день

//Регистр символов не имеет значения.


namespace Homework_Theme5_task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");

            string stringWithDoubles = Console.ReadLine();

            Console.WriteLine($"Преобразованная строка: {ReturnStringWithoutDoubles(stringWithDoubles)}");

        }

        /// <summary>
        /// Метод, возвращающий строку без повторяющихся букв
        /// </summary>
        /// <param name="s">Входящая строка</param>
        /// <returns></returns>
        static string ReturnStringWithoutDoubles(string s)
        {
            //преобразуем строку в List из символов
            List<char> chars = s./*ToLower().*/ToCharArray().ToList();

            //Если текущий символ=предыдущему, то удаляем предыдущий , уменьшаем счетчик на 1
            for (int i = 1;i<chars.Count; i++)
            {
                if (chars[i-1] == chars[i]) { chars.RemoveAt(i-1); i--; }
            }
            //foreach (var e in chars) Console.WriteLine(e);

            //Преобразуем List букв в строку, для этого вначале преобразуем его в массив букв.
            string result = new string(chars.ToArray());
            return result;
        }
    }
}
