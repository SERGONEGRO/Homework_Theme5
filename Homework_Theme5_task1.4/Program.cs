using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Четвёртый метод выполняет перемножение двух матриц.
//В качестве параметров он принимает две матрицы, а в качестве результата
//возвращает новую матрицу. Исходные матрицы остаются неизменными.

namespace Homework_Theme5_task1._4
{
    class Program
    {
        static int strA, stolbA;                   //размерности матриц
        static int strB, stolbB;
        static int sum;

        static Random rand = new Random();
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("\n Умножение матрицы на матрицу :");

            //Ввод размерностей матриц и проверка условий
            do
            {
                Console.WriteLine("\t--->Введите размерность матриц<----\n" +
                    " Количество столбцов в матрице 1 должно совпадать с количеством строк в матрице 2\n");

                Console.WriteLine("\tВведите количество строк первой матрицы(0-9) :");
                strA = EnterNumber();
                Console.WriteLine("\tВведите количество столбцов первой матрицы(0-9) :");
                stolbA = EnterNumber();

                Console.WriteLine("\tВведите количество строк второй матрицы(0-9) :");
                strB = EnterNumber();
                Console.WriteLine("\tВведите количество столбцов второй матрицы(0-9) :");
                stolbB = EnterNumber();

            } while (stolbA != strB);

            Console.WriteLine("\n Матрица А:");          //определение и заполнение матриц 
            int[,] matrixA = MatrixFill(strA, stolbA);
            PrintMatrix(matrixA);

            Console.WriteLine("\n Матрица B:");
            int[,] matrixB = MatrixFill(strB, stolbB);
            PrintMatrix(matrixB);

            Console.WriteLine("\n Умноженные матрицы:");
            PrintMatrix(MatrixMult(matrixA, matrixB));

        }

        /// <summary>
        /// Умножение двух матриц
        /// </summary>
        /// <param name="matrixa">Первая матрица</param>
        /// <param name="matrixb">Вторая матрица</param>
        /// <returns></returns>
        static int[,] MatrixMult(int[,] matrixa, int[,] matrixb)
        {
            int[,] matrixS = new int[strA, stolbB];
            
            for (int i = 0; i < strA; i++)
            {
                for (int j = 0; j < stolbB; j++)
                {
                    //встаем в каждую ячейку по очереди и считаем значение элемента согласно правилу
                    sum = 0;
                    for (int z = 0; z < stolbA; z++)           //stolbA=strB (по правилу)
                    {
                        //Операция вычисления матрицы , каждый элемент которой равен сумме произведений
                        //элементов в соответствующей строке первого множителя и столбце второго
                        sum = sum + matrixa[i, z] * matrixb[z, j];
                    }
                    matrixS[i, j] = sum;
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
