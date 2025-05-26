namespace Tests;

using Xunit;
using ShapeSpace;

public class UnitTest1
{
    [Fact]
    public void Test_CalculateArea_When_Shape_IsACircle()
    {
        var circle = new Circle(2);
        var result = circle.CalculateArea();
        Assert.Equal($"The size of the area's circle is : 12,566370614359172\n", result);
    }

    [Fact]
    public void Test_CalculateArea_When_Shape_IsASquare()
    {
        var square = new Square(2);
        var result = square.CalculateArea();
        Assert.Equal($"The size of the area's square is : 4\n", result);
    }

    [Fact]
    public void Test_Paint_When_Shape_IsACircle()
    {
        var square = new Circle(2);
        string colorCircle = "blue";
        var result = square.Paint(colorCircle);
        Assert.Equal($"The circle has been painted in blue", result);
    }

    [Fact]
    public void Test_Paint_When_Shape_IsASquare()
    {
        var square = new Square(2);
        string colorSquare = "red";
        var result = square.Paint(colorSquare);
        Assert.Equal($"The square has been painted in red", result);
    }
}
