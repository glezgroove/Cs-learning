using Homeworks;

namespace GroupUsersByAge_UnitTest;

public class GroupUsersByAge_UnitTest
{
    [Fact]
    public void GroupUsersByAge_ShouldReturnNumberOfGroups_When4EntitesAnd2SameAge()
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
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 60, Name = "SeregaOlimp" },
        };
        
        //Act
        var result = consoleApp.GroupUsersByAge(input);

        Assert.Equal(3, result.Count);
    }
    
    [Fact]
    public void GroupUsersByAge_ShouldReturnDictionaryAtCorrectAge_When4EntitesAnd2SameAge()
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
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 60, Name = "SeregaOlimp" },
        };
        
        //Act
        var result = consoleApp.GroupUsersByAge(input);
        
        Assert.Equal("Marina", result[50][0].Name);
        Assert.Equal("Serega", result[55][0].Name);
        Assert.Equal("SeregaBandit", result[60][0].Name);
        Assert.Equal("SeregaOlimp", result[60][1].Name);
    }
    
    [Fact]
    public void GroupUsersByAge_ShouldReturnEmptyDictionary_WhenInputIsEmpty()
    {
        // Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>();
        
        // Act
        var result = consoleApp.GroupUsersByAge(input);
        
        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}