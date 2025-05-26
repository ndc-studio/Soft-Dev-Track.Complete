namespace Tests;
using GenericSpace;
using System;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test_DisplayValue()
    {
        var intBox = new Box<int>(42);
        var result = intBox.DisplayValue();
        Assert.Equal($"42", result);
    }

    [Fact]
    public void Test_SwapTheValuesOf_TwoBoxObjects()
    {
        var utility = new Utility();
        var x = new Box<int>(10);
        var y = new Box<int>(20);
        utility.Swap(ref x, ref y);
        var result = $"\nx = {x}, y = {y} above the swap";
        Assert.Equal($"\nx = 20, y = 10 above the swap", result);
    }

    [Fact]
    public void Test_GetInTheList_byIndex()
    {

        var list = new MyList<string>();
        list.Add("Hello");
        var result = list.Get(0);
        Assert.Equal("Hello", result);

    }

    [Fact]
    public void Test_Greet_OnPersonObject()
    {
        var greeter = new Greeter<Person>();
        var person1 = new Person("Jean");
        var result = greeter.Greet(person1);
        Assert.Equal($"Hello Jean", result);
    }


    [Fact]
    public void Filter_ShouldReturnOnlyEvenNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        var result = FilterUtility.Filter(numbers, n => n % 2 == 0);

        var expected = new List<int> { 2, 4, 6 };
        Assert.Equal(expected, [.. result]);
    }
}

            