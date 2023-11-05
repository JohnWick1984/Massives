using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        
        double[] A = new double[5];
        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Convert.ToDouble(Console.ReadLine());
        }

        double[,] B = new double[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = rand.NextDouble() * 100;
            }
        }

        Console.Write("Массив A: ");
        foreach (double num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        double maxA = A[0];
        double minA = A[0];
        double maxB = B[0, 0];
        double minB = B[0, 0];

        double sumA = 0;
        double sumB = 0;
        double productA = 1;
        double productB = 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > maxA)
            {
                maxA = A[i];
            }
            if (A[i] < minA)
            {
                minA = A[i];
            }
            sumA += A[i];
            productA *= A[i];
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (B[i, j] > maxB)
                {
                    maxB = B[i, j];
                }
                if (B[i, j] < minB)
                {
                    minB = B[i, j];
                }
                sumB += B[i, j];
                productB *= B[i, j];
            }
        }

        Console.WriteLine($"Общий максимальный элемент в массивах: {Math.Max(maxA, maxB)}");
        Console.WriteLine($"Общий минимальный элемент в массивах: {Math.Min(minA, minB)}");
        Console.WriteLine($"Общая сумма всех элементов в массивах А и В: {sumA+sumB}");
        Console.WriteLine($"Общее произведение всех элементов в массивах A и B: {productA*productB}");

        double sumEvenA = 0;
        double sumOddColumnsB = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (i % 2 == 1)
            {
                sumEvenA += A[i];
            }
        }


        for (int j = 0; j < 4; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }
        }


        Console.WriteLine($"Сумма четных элементов в массиве A: {sumEvenA}");
        Console.WriteLine($"Сумма нечетных столбцов в массиве B: {sumOddColumnsB}");
    }
}

