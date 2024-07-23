using System;

namespace TaskArray
{
    public class TaskArray
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int size = 8;
            int[,] array = new int[size,size];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    array[i, j] = rand.Next(-50, 51);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int countInLine = 0; 
            int totalCount = 0;  
            int maxOddPositive = int.MinValue; 

            Console.WriteLine("\nНечетные и положительные элементы массива:");
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j] > 0 && array[i, j] % 2 != 0)
                    {
                        Console.Write(array[i, j] + "\t");
                        countInLine++;
                        totalCount++;

                        if (array[i, j] > maxOddPositive)
                        {
                            maxOddPositive = array[i, j];
                        }

                        if (countInLine >= 5)
                        {
                            Console.WriteLine();
                            countInLine = 0;
                        }
                    }
                }
            }

            if (countInLine > 0)
            {
                Console.WriteLine();
            }

            Console.WriteLine($"\nОбщее количество нечетных и положительных элементов: {totalCount}");

            if (totalCount > 0)
            {
                Console.WriteLine($"Максимальное значение среди полученных элементов: {maxOddPositive}");
            }
            else
            {
                Console.WriteLine("Нет нечетных и положительных элементов в массиве.");
            }
        }
    }
    
}


