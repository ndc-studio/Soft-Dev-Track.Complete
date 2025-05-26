namespace Tests;

using Xunit;
using ImsSpace;

public class UnitTest1
{
    [Fact]
    public void Test_Display_All_Articles_In_The_Store()
    {
        var store = new Store();
        var kiwis = new Article("Kiwi", 15);
        store.AddArticle(kiwis);

        var result = store.Display();
        Assert.Equal($"\n•Kiwi: 15", result);
    }

    [Fact]
    public void Test_Display_Low_Quantity_Articles_In_The_Store()
    {
        var store = new Store();
        var kiwis = new Article("Kiwi", 9);
        store.AddArticle(kiwis);

        var result = store.LowCapacity(); ;
        Assert.Equal($"The quantity of Kiwi is too low!\nQuantity = 9\n", result);
        store.LowCapacity();
    }
}
