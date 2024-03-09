
using modelLaba1;

class Program
{
    static void Main()
    {
        var solution = new Approximations(100, 4);
        var result = solution.PiecewiseApproximationDensityFunction();
        // Вывод результатов
        Console.WriteLine("Границы:");
        foreach (var center in result.Item1)
        {
            Console.Write($"{center:F3} ");
        }
        
        Console.WriteLine("\nЗначения плотности:");
        foreach (var density in result.Item2)
        {
            Console.Write($"{density:F2} ");
        }
    }
}