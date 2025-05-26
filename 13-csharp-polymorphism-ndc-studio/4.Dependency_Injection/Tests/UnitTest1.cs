namespace Tests;

using Xunit;
using EngineSpace;

public class UnitTest1
{
    [Fact]
    public void Test_Start_When_CarHaveDieselEngine()
    {
        DieselEngine diesel = new();
        Car car = new(diesel);
        var result = car.Start();
        Assert.Equal("This engine runs on diesel.", result);
    }

    [Fact]
    public void Test_Start_When_CarHaveGasolineEngine()
    {
        GasolineEngine gas = new();
        Car car = new(gas);
        var result = car.Start();
        Assert.Equal("This engine runs on gasoline.", result);
    }
}
