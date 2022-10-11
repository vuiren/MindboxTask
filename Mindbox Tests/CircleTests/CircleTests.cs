using MindboxTask;

namespace Mindbox_Tests.CircleTests;

public class CircleTests
{
    [Test]
    public void ThrowErrorOnImpossibleCircle()
    {
        Assert.Catch(() => new Circle(-2));
    }

    [Test]
    public void AreaOfZeroRadiusCircleIsZero()
    {
        var circle = new Circle(0);
        Assert.AreEqual(0, circle.CalculateArea());
    }

    [Test]
    public void CirclesAreasAreCorrect()
    {
        const double delta = 0.01;
        var circle = new Circle(1.2);
        Assert.AreEqual(4.524, circle.CalculateArea(), delta);
        var circle2 = new Circle(2.6);
        Assert.AreEqual(21.237, circle2.CalculateArea(), delta);
        var circle3 = new Circle(3.9);
        Assert.AreEqual(47.78, circle3.CalculateArea(), delta);
    }

    [Test]
    public void ThrowErrorOnTooBigRadius()
    {
        Assert.Catch(() => new Circle(double.MaxValue));
    }

    [Test]
    public void ThrowErrorOnMinDoubleRadius()
    {
        Assert.Catch(() => new Circle(double.MinValue).CalculateArea());
    }
}