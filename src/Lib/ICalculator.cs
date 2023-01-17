using System.Numerics;

namespace Lib;

public interface ICalculator<T> where T : INumber<T>
{
    T Sum(params T[] numbers);
}
