using Homeworks;

namespace SelectUsers_UnitTest;

public class UnitTest1
{
    [Fact]
    public void SelectUsers_ShouldReturnAgeCorrectly_WhenStandartUnput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 60, Name = "Marina" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 62, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 65, Name = "SeregaOlimp" },
        };

        //Act
        var result = consoleApp.SelectUsers(input);
        
        var expected = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 60, Name = "Marina" },
            new HomeworkConsoleApp.User 
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 62, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 65, Name = "SeregaOlimp" },
        };

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SelectUsers_ShouldReturnAgeCorrectly_WhenNonStandartUnput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = -1, Name = "Marina" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 0, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = -99, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 262112121, Name = "SeregaOlimp" },
        };

        //Act
        var result = consoleApp.SelectUsers(input);
        
        var expected = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = -99, Name = "SeregaBandit" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = -1, Name = "Marina" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 0, Name = "Serega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 262112121, Name = "SeregaOlimp" },
        };


        //Assert
        Assert.Equal(expected, result);
    }
    
    
    [Fact]
    public void SelectUserIds_ShouldReturnEmptyArray_WhenNoInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>
        {
        };
        
        var result = consoleApp.SelectUsers(input);

        //Act
        var expected = new List<HomeworkConsoleApp.User>
        {
        };

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SelectUserIds_ShouldReturnEmptyArray_WhenNullInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        ICollection<HomeworkConsoleApp.User>? input = null;
        
        var result = consoleApp.SelectUsers(input);

        //Act
        var expected = new List<HomeworkConsoleApp.User>
        {
        };

        //Assert
        Assert.Equal(expected, result);
    }
}