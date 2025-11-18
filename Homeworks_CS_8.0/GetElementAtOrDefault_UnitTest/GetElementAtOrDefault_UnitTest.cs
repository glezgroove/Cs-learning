using Homeworks;

namespace GetElementAtOrDefault_UnitTest;

public class GetElementAtOrDefault_UnitTest
{
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnNothing_WhenNoInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,2);
        
        //Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnNothing_WhenOutOfRange()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2,1,2,53,4,5,6,7,8,9,2};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,999);
        
        //Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnNothing_WhenIndexIsNegative()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2,1,2,53,4,5,6,7,8,9,2};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,-1);
        
        //Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnIndexedItem_WhenStandartInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{2,1,2,53,4,5,6,7,8,9,2};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,3);
        
        //Assert
        Assert.Equal(input[3],result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnFirstItem_WhenIndexIsZero()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{99,1,2,3,2,1,2,0,1,2,1};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,0);
        
        //Assert
        Assert.Equal(input[0],result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnZero_WhenIndexItemIsZero()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<int>{6,3,2,5,2,0};
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,5);
        
        //Assert
        Assert.Equal(0,result);
    }
    
    [Fact]
    public void GetElementAtOrDefault_ShouldReturnIndexeditem_WhenListIsReallyLong()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        List<int> input = new List<int> (50000);
        for (int i = 0; i < 50000; i++)
        {
            input.Add(i);
        }
        
        //Act
        var result = consoleApp.GetElementAtOrDefault(input,45854);
        
        //Assert
        Assert.Equal(45854,result);
    }
}