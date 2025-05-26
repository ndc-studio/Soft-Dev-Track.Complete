namespace Tests;

using Xunit;
using AnimalSpace;
using System;
using System.IO;

public class UnitTest1
{
    [Fact]
    public void Start_When_Object_Are_Dog()
    {
        var dog = new Dog();
        var result = dog..MakeNoise();
        Assert.Equal("Barks", result);
    }

    [Fact]
    public void Start_When_Object_Are_Cat()
    {
        var cat = new Cat();
        var result = cat..MakeNoise();
        Assert.Equal("Meows", result);
    }
}
