namespace Unit_Test;

public class UnitTest
{
    
    [Fact]
    public void GetOdd_ShouldReturnOnlyOdd_WhenMixedInput()
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
    public void GetOdd_ShouldReturnEmpty_WhenNoInput()
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
    public void GetOdd_ShouldReturnOddNegative_WhenNegativeNumbersInput()
    {
        //Arrange
        var input = new List<int>{-3,-9,-2,-4,};
        var expected = new List<int>{-3,-9};

        //Act
        var result = ConsoleApp.ConsoleApp.GetOdd(input);

        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetOdd_ShouldReturnEmpty_WhenOneEvenNumber()
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
    public void GetOdd_ShouldReturnOneOdd_WhenOnlyOddNumber()
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
    public void GetOdd_ShouldReturnEmpty_WhenMultipleZeroes()
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