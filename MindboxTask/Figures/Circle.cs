using MindboxTask.Extensions;

namespace MindboxTask;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;

        if (_radius > Math.Sqrt(double.MaxValue))
        {
            throw new Exception("Radius is too big");
        }
        
        if (_radius < 0)
        {
            throw new Exception("Impossible circle");
        }
    }
    
    public override double CalculateArea()
    {
        return _radius * _radius * Math.PI;
    }
}