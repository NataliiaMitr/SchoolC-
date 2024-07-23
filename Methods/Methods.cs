using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int[] array1 = new int[5];
            Console.WriteLine("Enter digits for the first array:");
            InitializeArray(array1);

            int[] array2 = new int[5];
            Console.WriteLine("Enter digits for the second array:");
            InitializeArray(array2);

            Console.WriteLine("First array before sort:");
            PrintArray(array1);

            Console.WriteLine("Second array before sort:");
            PrintArray(array2);

            SortArray(array1);

            SortArray(array2);

            Console.WriteLine("First array after sort:");
            PrintArray(array1);

            Console.WriteLine("Second array after sort:");
            PrintArray(array2);

            bool areEqual = Equal(array1, array2);
            
            if (Equal(array1, array2))
            {
                Console.WriteLine("Arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }

        static void InitializeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static bool Equal(int[] array1, int[] array2)
        {
           for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

