using System.Numerics;

namespace Lib;

public class Calculator<T> : ICalculator<T> where T : INumber<T>
{
    public T Sum(params T[] numbers)
    {
        var result = T.Zero;
        return numbers is null ? 
            result : 
            numbers.Aggregate(result, (x, y) => x + y);
    }
}