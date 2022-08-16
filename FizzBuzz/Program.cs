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
    if (isDivisibleBy3(i) && isDivisibleBy5(i) && isDivisibleBy7(i))
    {
        Console.WriteLine("FizzBuzzWoof");
    }

    else if (isDivisibleBy5(i) && isDivisibleBy7(i))
    {
        Console.WriteLine("BuzzWoof");
    }

    else if (isDivisibleBy3(i) && isDivisibleBy7(i))
    {
        Console.WriteLine("FizzWoof");
    }
    else if (isDivisibleBy3(i) && isDivisibleBy5(i))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (isDivisibleBy7(i))
    {
        Console.WriteLine("Woof");
    }
    else if (isDivisibleBy5(i))
    {
        Console.WriteLine("Buzz");
    }
    else if (isDivisibleBy3(i))
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

bool isDivisibleBy3(int i1)
{
    return i1 % 3 == 0;
}

bool isDivisibleBy5(int i2)
{
    return i2 % 5 == 0;
}

bool isDivisibleBy7(int i3)
{
    return i3 % 7 == 0;
}