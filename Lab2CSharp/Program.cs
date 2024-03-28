using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lab 1. Choose task: ");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Task 3");
            Console.WriteLine("4. Task 4");
            Console.WriteLine("5. Exit");

            int choice;
            bool isValidChoice = false;

            do
            {
                Console.Write("Enter number of task: ");
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Error: Invalid choice!");
                    isValidChoice = false;
                }
            } while (!isValidChoice);

            switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

        static void Task1()
        {
            Console.Write("Enter the size of the square array: ");
            int size = int.Parse(Console.ReadLine());

            int[,] array = new int[size, size];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Indices of odd elements:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        Console.WriteLine($"[{i},{j}]: {array[i, j]}");
                    }
                }
            }
        }

        static void Task2()
        {
            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int maxNeg = MaxNegative(a);

            if (maxNeg != 0)
            {
                Console.WriteLine($"Maximum negative number: {maxNeg}");
            }
            else
            {
                Console.WriteLine("There are no negative numbers in the sequence.");
            }
        }

        static int MaxNegative(int[] a)
        {
            int maxNegative = int.MinValue;

            foreach (int num in a)
            {
                if (num < 0 && num > maxNegative)
                {
                    maxNegative = num;
                }
            }

            if (maxNegative == int.MinValue)
            {
                maxNegative = 0; // Якщо немає від'ємних чисел у послідовності
            }

            return maxNegative;
        }

        static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
           {
                Console.Write($"{matrix[i, j],5}"); 
            }
            Console.WriteLine();
        }
     }
       static void Task3()
    {
       int[,] array;
       int size;

       Console.Write("Enter the size of the square array: ");
       size = int.Parse(Console.ReadLine());

    // Ініціалізація масиву з введеним розміром
       array = new int[size, size];

    // Зчитування елементів масиву з клавіатури
       Console.WriteLine("Enter the elements of the array:");
       for (int i = 0; i < size; i++)
       {
           for (int j = 0; j < size; j++)
          {
            Console.Write($"Element [{i},{j}]: ");
            array[i, j] = int.Parse(Console.ReadLine());
           }
        }

        PrintMatrix(array);
        }

        static void Task4()
    {
        // Зчитуємо розмірність масиву з клавіатури
        Console.Write("Enter the number of rows in the array: ");
        int n = int.Parse(Console.ReadLine());

        // Оголошуємо початковий масив
        int[][] array = new int[n][];

        // Заповнюємо масив та рахуємо суму елементів кожного рядка
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the number of elements in row {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            array[i] = new int[m];

            Console.WriteLine($"Enter {m} elements for row {i + 1}:");
            for (int j = 0; j < m; j++)
            {
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Оголошуємо новий масив для зберігання сум кожного рядка
        int[] sums = new int[n];

        // Обчислюємо суми елементів кожного рядка і зберігаємо їх у новому масиві
        for (int i = 0; i < n; i++)
        {
            sums[i] = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                sums[i] += array[i][j];
            }
        }

        // Знаходимо максимальний елемент у новому масиві
        int maxSum = sums[0];
        for (int i = 1; i < n; i++)
        {
            if (sums[i] > maxSum)
            {
                maxSum = sums[i];
            }
        }

        Console.WriteLine($"The maximum sum of elements in a row is: {maxSum}");
    }
    }
}
