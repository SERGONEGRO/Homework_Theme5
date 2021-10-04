using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Первый метод умножает матрицу на число. Для этого он принимает в качестве параметров матрицу и число,
  на которое будет происходить умножение. В качестве результата этот метод возвращает новую матрицу,
  а исходная матрица остаётся неизменной.*/
namespace Homework_Theme5_task1._1
{
    class Program
    {
        static int[,] matrixA;     //исходная матрица
        //static int[,] matrixB;      //полученная матрица
        static Random rand = new Random();


        static void Main(string[] args)
        {
            int str, stolb;     //количество строк и стоблцов
            int num;            //число

            Console.WriteLine("\n Перемножение матрицы на число :");

            Console.WriteLine("\nВведите количество строк матрицы(0-9) :");
            str = EnterNumber();

            Console.WriteLine("\nВведите количество столбцов матрицы(0-9) :");
            stolb = EnterNumber();

            Console.WriteLine("\nВведите число(0-9) :");
            num = EnterNumber();

            matrixA = MatrixFill(str, stolb);
            Console.WriteLine($"\nИсходная матрица: ");
            PrintMatrix(matrixA);

            Console.WriteLine("\n Перемноженная матрица на число: ");
            PrintMatrix(MatrixMultiply(matrixA, num));

            Console.ReadKey();
        }

        /// <summary>
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="matrix">исходная матрица</param>
        /// <param name="num">исходное число</param>
        /// <returns>Перемноженная матрица</returns>
        static int[,] MatrixMultiply(int[,] matrix, int num)
        {
            int matrixLength0 = matrix.GetLength(0);
            int matrixLength1 = matrix.GetLength(1);

            for (int i = 0; i < matrixLength0; i++)
            {
                for (int j = 0; j < matrixLength1; j++)
                {
                    matrix[i, j] = matrix[i, j] * num;
                }
            }
            return matrix;
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
