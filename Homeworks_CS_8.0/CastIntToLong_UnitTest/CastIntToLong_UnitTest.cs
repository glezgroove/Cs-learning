using Homeworks;

namespace CastIntToLong_UnitTest;

public class CastIntToLong_UnitTest
{
    [Fact]
    public void CastIntToLong_ShouldReturnNothing_WhenNoInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{};
        
        //Act
        var result = consoleApp.CastIntToLong(input);
        var expected = new List<long> {};
        //Assert
        Assert.Equal(expected,result);
    }
    
    [Fact]
    public void CastIntToLong_ShouldReturnLongs_WhenStandartInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{5,25,55555,9999999};
        
        //Act
        var result = consoleApp.CastIntToLong(input);
        var expected = new List<long> {5,25,55555,9999999};
        //Assert
        Assert.Equal(expected,result);
    }
    
    [Fact]
    public void CastIntToLong_ShouldReturnLongs_WhenNegativeAndMaxInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2147483647,-2147483647,0,0,-1,999,8,2147483647};
        
        //Act
        var result = consoleApp.CastIntToLong(input);
        var expected = new List<long> {2147483647,-2147483647,0,0,-1,999,8,2147483647};
        //Assert
        Assert.Equal(expected,result);
    }
}