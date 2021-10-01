using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Второй метод производит сложение двух матриц.
//В качестве параметров он принимает две матрицы, а в качестве результата возвращает новую матрицу.
//Исходные матрицы в процессе выполнения метода не изменяются.

namespace Homework_Theme5_task1._2
{

    class Program
    {
       
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int str, stolb;     //количество строк и стоблцов матриц
            
            Console.WriteLine("\n Сложение матриц :");

            Console.WriteLine("\tВведите количество строк матрицы (0-9):");
            str = EnterNumber();

            Console.WriteLine("\tВведите количество столбцов матрицы (0-9):");
            stolb = EnterNumber();

            Console.WriteLine("\n Матрица А:");          //определение и заполнение матриц 
            int[,] matrixA = MatrixFill(str, stolb);
            PrintMatrix(matrixA);

            Console.WriteLine("\n Матрица B:");
            int[,] matrixB = MatrixFill(str, stolb);
            PrintMatrix(matrixB);

            Console.WriteLine("\n Сложенные матрицы::");
            PrintMatrix(MatrixSum(matrixA, matrixB));

        }

        /// <summary>
        /// Метод сложения двух матриц
        /// </summary>
        /// <param name="matrixa"></param>
        /// <param name="matrixb"></param>
        /// <returns></returns>
        static int[,] MatrixSum(int[,] matrixa, int[,] matrixb)
        {
            int[,] matrixS = new int[matrixa.GetLength(0), matrixa.GetLength(1)];
            for (int i = 0; i < matrixa.GetLength(0); i++)
            {
                for (int j = 0; j < matrixa.GetLength(1); j++)
                {
                    matrixS[i, j] = matrixa[i, j] + matrixb[i, j];
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
                }
            }
            return matrixX;
        }


        /// <summary>
        /// Печатает матрицу
        /// </summary>
        /// <param name="matrix">исходная матрица</param>
        static void PrintMatrix(int[,] matrix)
        {
            int matrixLength0 = matrix.GetLength(0);
            int matrixLength1 = matrix.GetLength(1);

            for (int i = 0; i < matrixLength0; i++)
            {
                for (int j = 0; j < matrixLength1; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
