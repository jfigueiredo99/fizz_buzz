namespace FizzBuzzOOP;

public class FizzBuzz
{
    private List<IFizzBuzzNumber> numbers { get; set; } 

    public FizzBuzz(int limitNumber)
    {
        numbers = new List<IFizzBuzzNumber>();
        for (int i = 1; i <= limitNumber; i++)
        {
            if (i % 5 == 0)
            {
                numbers.Add( new NumberDivisibleBy5(i));
            }
            else if (i % 3 == 0)
            {
                numbers.Add( new NumberDivisibleBy3(i));
            }
            else
            {
                numbers.Add(new FizzBuzzNumber(i));
            }
        }
    }
    public void PrintNumbers()
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number.getMessage());
        }
    }
}