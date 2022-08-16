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


for (var i = 50; i <= 110; i++)
{
    if (IsDivisibleBy3(i) && IsDivisibleBy5(i) && IsDivisibleBy7(i))
    {
        Console.WriteLine("FizzBuzzWoof");
    }

    else if (IsDivisibleBy5(i) && IsDivisibleBy7(i))
    {
        Console.WriteLine("BuzzWoof");
    }

    else if (IsDivisibleBy3(i) && IsDivisibleBy7(i))
    {
        Console.WriteLine("FizzWoof");
    }
    else if (IsDivisibleBy3(i) && IsDivisibleBy5(i))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (IsDivisibleBy7(i))
    {
        Console.WriteLine("Woof");
    }
    else if (IsDivisibleBy5(i))
    {
        Console.WriteLine("Buzz");
    }
    else if (IsDivisibleBy3(i))
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

bool IsDivisibleBy3(int i1)
{
    return i1 % 3 == 0;
}

bool IsDivisibleBy5(int i2)
{
    return i2 % 5 == 0;
}

bool IsDivisibleBy7(int i3)
{
    return i3 % 7 == 0;
}