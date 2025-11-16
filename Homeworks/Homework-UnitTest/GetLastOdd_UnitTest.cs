using Homeworks;

namespace Homeworks_UnitTest;

public class GetLastOddEven_UnitTest
{
    [Fact]
    public void GetLastOddNumber_ShouldReturnNothing_WhenNoNumbersExist()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{};
        var expected = new int{};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetLastOddNumber_ShouldReturnNothing_WhenOnlyEvenNumbersExist()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2,4,88,1466,266622};
        var expected = new int{};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetLastOddNumber_ShouldReturnLastOdd_WhenMixUnput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{88,135,22,55,66,99};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(99, result);
    }
    
    [Fact]
    public void GetLastOddNumber_ShouldReturnLastOdd_WhenOneEvenAtTheEnd()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{88,66,44,444444,9};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(9, result);
    }
    
    [Fact]
    public void GetLastOddNumber_ShouldReturnLastOdd_WhenOneOddWithZeroes()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{0,00,000,99,000,000,0,87};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(87, result);
    }
    
    [Fact]
    public void GetLastOddNumber_ShouldReturnLastOdd_WhenNegativeOdd()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{-5,0,6,2,-9};
        
        //Act
        var result = consoleApp.GetLastOddNumber(input);
        
        //Arrange
        Assert.Equal(-9, result);
    }
}