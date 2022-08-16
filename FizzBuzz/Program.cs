// RULES

// Print integers 1 to N,
// but print “Fizz” if an integer is divisible by 3,
// “Buzz” if an integer is divisible by 5,
// and “FizzBuzz” if an integer is divisible by both 3 and 5.

// NEW RULES
// Print integers 50 to 110,
// If an integer is divisible by 7 print “Woof”,
// If an integer is divisible by both 3 and 7 prints “FizzWoof”,
// If an integer is divisible by both 5 and 7 prints “BuzzWoof,
// If an integer is divisible by 3,5 and 7 prints “FizzBuzzWoof.

using System;


for (int i = 50; i <= 110; i++)
{
    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBuzzWoof");
    }

    else if (i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("BuzzWoof");
    }

    else if (i % 3 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzWoof");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine("Woof");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}