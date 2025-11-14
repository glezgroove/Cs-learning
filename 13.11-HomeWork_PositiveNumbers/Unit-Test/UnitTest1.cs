using _13_11_HomeWork_ConsoleApp;

namespace Unit_Test;

public class UnitTest1
{
    [Fact]
    public void GetPositiveNumbers_ShouldReturnNothing_WhenNoNumbersExist()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{};
        var expected = new List<int>{};
        
        //Act
        var result = consoleApp.GetPositiveNumbers(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetPositiveNumbers_ShouldReturnOne_WhenOnePositiveAndMultipleNegative()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{0,-2,-5,-12,-666,-9999,999,-8};
        var expected = new List<int>{999};
        
        //Act
        var result = consoleApp.GetPositiveNumbers(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetPositiveNumbers_ShouldReturnNothing_WhenOnlyNegative()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{-1,-2,-3,-4,-5,-6,-7,-8,-2159120};
        var expected = new List<int>{};
        
        //Act
        var result = consoleApp.GetPositiveNumbers(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void GetPositiveNumbers_ShouldReturnSameAsInput_WhenOnlyPositive()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{9999,8888,77777,912311,01,22,5};
        var expected = new List<int>{9999,8888,77777,912311,1,22,5};
        
        //Act
        var result = consoleApp.GetPositiveNumbers(input);
        
        //Arrange
        Assert.Equal(expected, result);
    }
    
}