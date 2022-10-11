namespace MindboxTask.Extensions;

public static class DoubleComparing
{
    public static bool AreEqual(double a, double b, double delta)
    {
        return Math.Abs(a - delta) < b;
    }
}