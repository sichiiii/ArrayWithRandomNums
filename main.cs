using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows count: ");
            int rowsCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns count: ");
            int columnsCount = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rowsCount, columnsCount];

            FillUnique(matrix);
            Display(matrix);
            Console.ReadKey();
        }

        static void FillUnique(int[,] matrixForFilling)
        {
            // в типо блэклист будем закидывать уже добавленные элементы
            List<int> blackList = new List<int>()  ;
            Random rnd = new Random();

            int rowCount = matrixForFilling.GetLength(0);
            int columnCount = matrixForFilling.GetLength(1);
            int tmp;

            for (int rowNumber = 0; rowNumber < rowCount; rowNumber++)
                for (int columnNumber = 0; columnNumber < columnCount; columnNumber++)
                {
                    do
                    {
                        tmp = rnd.Next(-99, 99);
                    }
                    while (blackList.Exists(value => value == tmp));
                    matrixForFilling[rowNumber, columnNumber] = tmp;
                    blackList.Add(tmp);
                }
        }

        static void Display(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            for (int rowNumber = 0; rowNumber < rowCount; rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < columnCount; columnNumber++)
                {
                    Console.Write(matrix[rowNumber, columnNumber] + ", ");
                }
                Console.WriteLine();
            }
        }

    }
}
