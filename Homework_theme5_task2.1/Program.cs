using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Первый метод принимает строку с текстом и возвращает строку, содержащую слово с минимальной длиной.

namespace Homework_theme5_task2._1
{
    class Program
    {
        static char[] charSeparators = new char[] { ' ' };   //разделитель слов
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");
            string str = Console.ReadLine();

            Console.WriteLine($"Минимальное слово : {ReturnMinWord(str)}");

        }

        static string ReturnMinWord(string s)
        {
            
            string[] result;
            result = s.Split(charSeparators, StringSplitOptions.None);
            string minWord = result[0];
            //foreach (var e in result) Console.WriteLine(e);
            for (int i=0; i < result.Length; i++)
            {
               if (minWord.Length > result[i].Length) minWord = result[i] ;
            }
            return minWord;
        }
    }
}
