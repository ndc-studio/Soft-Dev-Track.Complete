namespace Tests;

using Xunit;
using TwoDimension;

public class UnitTest1
{
    [Fact]
    public void Test_DistanceTo_With_TwoDifferentsPoints()
    {

        Point point1 = new(9, 9);
        Point point2 = new(1, 1);

        var result = point1.DistanceTo(point2);
        Assert.Equal(11.313708498984761, result);
    }
    [Fact]
    public void Test_CalculateArea_With_A_Rectangle()
    {
        Rectangle rectangle = new(5, 3);
        var result = rectangle.CalculateArea();
        Assert.Equal($"The area's rectangle is : 15", result);
    }

    [Fact]
    public void Test_Shape_Comparison_True_IfTheSame_ThenFalse()
    {
        var shape1 = new Shape(new Point(0, 0), 5);
        var shape2 = new Shape(new Point(0, 0), 5);
        var shape3 = new Shape(new Point(1, 1), 5);

        Assert.True(shape1 == shape2);
        Assert.False(shape1 == shape3);
        Assert.False(shape2 == shape3);
    }
}
