using Homeworks;

namespace DescendingAgeUsers_UnitTest;

public class DescendingAgeUsers_UnitTest
{
    [Fact]
    public void DescendingAgeUsers_ShouldReturnCorrectly_WhenNormalInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50, Name = "Marina" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 60, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 65, Name = "SeregaOlimp" },
        };
        //Act
        var result = consoleApp.DescendingAgeUsers(input, 40);

        IList<HomeworkConsoleApp.User> expected = new List<HomeworkConsoleApp.User> 
            { input[3], input[2], input[1], input[0] };
        
        //Assert
        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void DescendingAgeUsers_ShouldReturnCorrectly_WhenInsideInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50, Name = "Marina" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 60, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 65, Name = "SeregaOlimp" },
        };
        var result = consoleApp.DescendingAgeUsers(input, 58);

        //Act
        IList<HomeworkConsoleApp.User> expected = new List<HomeworkConsoleApp.User> 
            { input[3], input[2]};
        
        //Assert
        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void DescendingAgeUsers_ShouldReturnEmptyArray_WhenNoInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
        };
        
        var result = consoleApp.DescendingAgeUsers(input, 55);

        //Act
        IList<HomeworkConsoleApp.User> expected = new List<HomeworkConsoleApp.User> 
            {};

        //Assert
        Assert.Equal(expected, result);
    }
}