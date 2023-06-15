/*
####  Return the Sum of Two Numbers  ####

Create a function that takes two numbers as arguments and returns their sum.


[Examples]

___
Sum(3, 2) ➞ 5

Sum(-3, -6) ➞ -9

Sum(7, 3) ➞ 10
_____



[Notes]

___
*) Don't forget to return the result.
*) If you get stuck on a challenge, find help in the Resources tab.
*) If you're really stuck, unlock solutions in the Solutions tab.
___



[algebra] [language_fundamentals] [math] [numbers] 



-------------------------------------------------------------------
[Resources]
_________
Math Class
https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.7.2
Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.
_________
_________
Addition Operator (+)
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#addition-operator-
Computes the sum of its operands.
_________
_________
Lambda Expressions
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
Is an expression of any of the following two forms: Expression lambda that has an expression as its body: (input-parameters) => expression. Statement lambda that has …
_________

*/
//Your code should go here:

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


