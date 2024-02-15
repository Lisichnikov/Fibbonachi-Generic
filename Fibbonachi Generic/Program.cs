using System;
using System.Collections.Generic;

class FibonacciGenerator<T>
{
    public static List<T> GenerateFibonacciNumbers(int n)
    {
        List<T> fibonacciNumbers = new List<T>();

        dynamic a = (dynamic)0;
        dynamic b = (dynamic)1;

        fibonacciNumbers.Add((T)a);

        for (int i = 2; i <= n; i++)
        {
            fibonacciNumbers.Add((T)b);
            dynamic temp = b;
            b += a;
            a = temp;
        }

        return fibonacciNumbers;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи для генерации:");
        int n = int.Parse(Console.ReadLine());

        List<int> fibonacciIntegers = FibonacciGenerator<int>.GenerateFibonacciNumbers(n);

        Console.WriteLine("Первые " + n + " чисел Фибоначчи:");
        foreach (var num in fibonacciIntegers)
        {
            Console.Write(num + " ");
        }
    }
}