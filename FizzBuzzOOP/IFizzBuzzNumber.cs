using System.Security.AccessControl;

namespace FizzBuzzOOP;

public interface IFizzBuzzNumber
{
    public String getMessage();
    
}

public class FizzBuzzNumber : IFizzBuzzNumber
{
    public int numberValue { get; set; }
    public FizzBuzzNumber(int number)
    {
        numberValue = number;
    }

    public string getMessage() => numberValue.ToString();


}
public class NumberDivisibleBy3 : IFizzBuzzNumber
{
    public int numberValue { get; set; }
    public NumberDivisibleBy3(int number)
    {
        numberValue = number;
    }

    public string getMessage() => "Fizz";


}

public class NumberDivisibleBy5 : IFizzBuzzNumber
{
    public int numberValue { get; set; }
    public NumberDivisibleBy5(int number)
    {
        numberValue = number;
    }

    public string getMessage() => "Buzz";


}