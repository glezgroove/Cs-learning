using Homeworks;

namespace SelectUserIds_UnitTest;

public class SelectUserIds_UnitTest
{
    [Fact]
    public void SelectUserIds_ShouldReturnAllIds_WhenAllInputsIsOkay()
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
        var result = consoleApp.SelectUserIds(input, 40);
        
        var expected = new List<Guid>
        {
            Guid.Parse("00000000-0000-0000-0000-000000000000"),
            Guid.Parse("00000000-0000-0000-0000-000000000001"),
            Guid.Parse("00000000-0000-0000-0000-000000000002"),
            Guid.Parse("00000000-0000-0000-0000-000000000003")
        };

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SelectUserIds_ShouldReturnTwoThatGood_WhenOnly2InputsIsOkay()
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
        var result = consoleApp.SelectUserIds(input, 55);
        
        var expected = new List<Guid>
        {
            Guid.Parse("00000000-0000-0000-0000-000000000002"),
            Guid.Parse("00000000-0000-0000-0000-000000000003")
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
        
        var result = consoleApp.SelectUserIds(input, 55);

        //Act
        var expected = new List<Guid>
        {
        };

        //Assert
        Assert.Equal(expected, result);
    }
}