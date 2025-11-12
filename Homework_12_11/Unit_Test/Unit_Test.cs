namespace Unit_Test;

public class UnitTest
{
    
    [Fact]
    public void GetOdd_Standart()
    {
        //Arrange
        var input = new List<int>{1,2,5,10,15,25,125,9999,2165221,2147483647};
        var expected = new List<int>{1,5,15,25,125,9999,2165221,2147483647};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    [Fact]
    public void GetOdd_NoNumbers()
    {
        //Arrange
        var input = new List<int>();
        var expected = new List<int>();

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetOdd_NegativeAndPositive()
    {
        //Arrange
        var input = new List<int>{9,2,1,0,-1,-2,-3,-2147483647};
        var expected = new List<int>{9,1,-1,-3,-2147483647};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetOdd_OnlyOneEven()
    {
        //Arrange
        var input = new List<int>{2};
        var expected = new List<int>{};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetOdd_OnlyOneOdd()
    {
        //Arrange
        var input = new List<int>{9};
        var expected = new List<int>{9};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetOdd_MultpleZeroes()
    {
        //Arrange
        var input = new List<int>{0000000,-0000000};
        var expected = new List<int>{};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
}