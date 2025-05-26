namespace Tests;

using Xunit;
using VehicleSpace;
using System;
using System.IO;

public class UnitTest1
{
    [Fact]
    public void Start_When_Vehicle_Are_Motorcycle()
    {
        var moto = new Motorcycle();
        var result = moto.Start();
        Assert.Equal("The motorcycle starts with a loud rev.", result);
    }

    [Fact]
    public void Start_When_Vehicle_Are_Car()
    {
        var car = new Car();
        var result = car.Start();
        Assert.Equal("The car starts with a roar.", result);
    }
}
