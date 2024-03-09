

using modelLaba1;

class Program
{
    static void Main()
    {
        var data = new List<double>();

        var test = new Approximations(100);
        test.Modeling(data);
    }
}