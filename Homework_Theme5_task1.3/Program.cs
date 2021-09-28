using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Третий метод аналогичен предыдущему, только выполняется не сложение, а вычитание.

namespace Homework_Theme5_task1._3
{
    class Program
    {

        static Random rand = new Random();
        static void Main(string[] args)
        {
            int str, stolb;     //количество строк и стоблцов матриц

            Console.WriteLine("\n Вычитание матриц :");

            Console.WriteLine("\tВведите количество строк матрицы (0-9):");
            str = EnterNumber();

            Console.WriteLine("\tВведите количество столбцов матрицы (0-9):");
            stolb = EnterNumber();

            Console.WriteLine("\n Матрица А:");          //определение и заполнение матриц 
            int[,] matrixA = MatrixFill(str, stolb);
            Console.WriteLine("\n Матрица B:");
            int[,] matrixB = MatrixFill(str, stolb);

            Console.WriteLine("\n Вычтенные матрицы:");
            PrintMatrix(MatrixSub(matrixA, matrixB));

        }

        /// <summary>
        /// Метод вычитания двух матриц
        /// </summary>
        /// <param name="matrixa">Первая матрица</param>
        /// <param name="matrixb">Вычитаемая матрица</param>
        /// <returns></returns>
        static int[,] MatrixSub(int[,] matrixa, int[,] matrixb)
        {
            int[,] matrixS = new int[matrixa.GetLength(0), matrixa.GetLength(1)];
            for (int i = 0; i < matrixa.GetLength(0); i++)
            {
                for (int j = 0; j < matrixa.GetLength(1); j++)
                {
                    matrixS[i, j] = matrixa[i, j] - matrixb[i, j];
                }
            }
            return matrixS;
        }


        /// <summary>
        /// Ввод числа и его проверка 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Метод для заполнения матрицы
        /// </summary>
        /// <param name="stroka">количество столбцов</param>
        /// <param name="stolbec">количество строк</param>
        /// <returns></returns>
        static int[,] MatrixFill(int stroka, int stolbec)
        {
            int[,] matrixX = new int[stroka, stolbec];
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    matrixX[i, j] = rand.Next(5);
                    Console.Write($"{matrixX[i, j]}\t");
                }
                Console.WriteLine();
            }
            return matrixX;
        }


        /// <summary>
        /// Печатает матрицу
        /// </summary>
        /// <param name="matrix">исходная матрица</param>
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
