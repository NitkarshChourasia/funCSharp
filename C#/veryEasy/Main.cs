using System;

public class Program
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static void Main(string[] args)
    {
        // Example test cases
        Console.WriteLine(Sum(3, 2));    // Output: 5
        Console.WriteLine(Sum(-3, -6));  // Output: -9
        Console.WriteLine(Sum(7, 3));    // Output: 10
    }
}
