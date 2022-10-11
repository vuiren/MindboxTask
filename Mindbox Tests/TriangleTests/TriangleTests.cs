using MindboxTask;

namespace Mindbox_Tests.TriangleTests;

public class TriangleTests
{
    [Test]
    public void ThrowErrorOnImpossibleTriangle()
    {
        Assert.Catch(() => new Triangle(2, 342, 4));
        Assert.Catch(() => new Triangle(-2, 342, 4));
        Assert.Catch(() => new Triangle(2, -342, -4));
        Assert.Catch(() => new Triangle(2, 342, -4));
        Assert.Catch(() => new Triangle(2, 3, -4));
    }

    [Test]
    public void DegenerateTriangleAreaIsZero()
    {
        var triangle = new Triangle(0, 0, 0);
        Assert.AreEqual(0, triangle.CalculateArea());
    }

    [Test]
    public void TriangleIsRightAngled()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }

    [Test]
    public void TriangleIsNotRightAngled()
    {
        var triangle = new Triangle(3, 5, 6);
        Assert.IsFalse(!triangle.IsRightTriangle());
    }

    [Test]
    public void TriangleAreaIsCorrect()
    {
        const double delta = 0.01;

        var triangle = new Triangle(3, 6, 7);
        Assert.AreEqual(8.94, triangle.CalculateArea(), delta);

        var triangle2 = new Triangle(8, 11, 13);
        Assert.AreEqual(43.817, triangle2.CalculateArea(), delta);

        var triangle3 = new Triangle(4, 6, 8);
        Assert.AreEqual(11.61, triangle3.CalculateArea(), delta);
    }

    [Test]
    public void ThrowErrorOnTooBigTriangleSide()
    {
        Assert.Catch(() => new Triangle(double.MaxValue / 2, 4, 5));
        Assert.Catch(() => new Triangle(4, double.MaxValue / 2, 5));
        Assert.Catch(() => new Triangle(4, 5, double.MaxValue / 2));
    }
    
    [Test]
    public void ThrowErrorOnDoubleMinLengthSide()
    {
        Assert.Catch(() => new Triangle(double.MinValue, 4, 5));
        Assert.Catch(() => new Triangle(4, double.MinValue, 5));
        Assert.Catch(() => new Triangle(4, 5, double.MinValue));
    }
}