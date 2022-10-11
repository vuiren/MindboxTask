using MindboxTask.Extensions;

namespace MindboxTask;

public class Triangle : Figure
{
    private readonly double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;

        var sqrtOfDoubleMaxValue = Math.Sqrt(double.MaxValue);
        if (a > sqrtOfDoubleMaxValue || b > sqrtOfDoubleMaxValue || c > sqrtOfDoubleMaxValue)
        {
            throw new Exception("One of the triangle sides is too big");
        }
        
        if (a + b < c || a + c < b || b + c < a)
        {
            throw new Exception("Impossible triangle");
        }
    }

    public bool IsRightTriangle()
    {
        const double delta = 0.01;
        return DoubleComparing.AreEqual(_a * _a, _b * _b + _c * _c, delta) ||
               DoubleComparing.AreEqual(_b * _b, _a * _a + _c * _c, delta) ||
               DoubleComparing.AreEqual(_c * _c, _a * _a + _b * _b, delta);
    }

    public override double CalculateArea()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
}