namespace modelLaba1;

public class Approximations
{
    private int _size;
    private int _numBorders;
    public Approximations(int size, int numBorders)
    {
        _size = size;
        _numBorders = numBorders;
    }
    public Tuple<double[], double[]> PiecewiseApproximationDensityFunction()
    {
        var hist = new double[_numBorders];
        var bins = new double[_numBorders + 1];
        var data = GenerateData();
        Array.Sort(data);

        for (var i = 0; i < _numBorders; i++)
        {
            var n = i + data[i];
            var startIndex = i * data.Length / _numBorders;
            var endIndex = Math.Min((i + 1) * data.Length / _numBorders, data.Length - 1);
            bins[i] = data[startIndex];
            //hist[i] = (double)(endIndex - startIndex) / data.Length / (data[endIndex] - data[startIndex]);
            hist[i] = (-0.5) * n + 1;
        }

        bins[_numBorders] = data[^1];
        var binCenters = new double[_numBorders];
    
        for (var i = 0; i < _numBorders; i++)
        {
            binCenters[i] = (bins[i] + bins[i + 1]) / 2;
        }

        return Tuple.Create(binCenters, hist);
    }
    private double[] GenerateData()
    {
        var rand = new Random();
        var data = new double[_size];
        for (var i = 0; i < _size; i++)
        {
            data[i] = rand.NextDouble();
        }
        return data;
    }
}