// RULES

// Print integers 1 to N,
// but print “Fizz” if an integer is divisible by 3,
// “Buzz” if an integer is divisible by 5,
// and “FizzBuzz” if an integer is divisible by both 3 and 5.

// NEW RULE If an integer is divisible by 7 print “Woof”,

using System;


for ( int i = 1; i <= 50; i++)
{
   
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
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