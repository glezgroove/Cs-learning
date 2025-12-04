using Homeworks;

namespace DistinctByIdUsers_UnitTest_;

public class DistinctByIdUsers_UnitTest
{
    [Fact]
    public void DistinctByIdUsers_ShouldReturn4Results_When4UsersAllUniqueIds()
    {
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
        
        var result = consoleApp.DistinctByIdUsers(input);

        Assert.Equal(4, result.Count);
    }
    
    [Fact]
    public void DistinctByIdUsers_ShouldReturn4Results_When7UsersBut3NotUniqueIds()
    {
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
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 14, Name = "NotSerega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 13, Name = "Serega_Steal" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 12, Name = "MeSerega_yes_yes" },
        };
        
        var result = consoleApp.DistinctByIdUsers(input);

        Assert.Equal(4, result.Count);
    }
    
    [Fact]
    public void DistinctByIdUsers_ShouldReturnСorrectUsers_When7UsersBut3NotUniqueIds()
    {
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
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 62, Name = "NotSerega" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 123, Name = "Serega_Steal" },
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Age = 43, Name = "MeSerega_yes_yes" },
        };
        
        var result = consoleApp.DistinctByIdUsers(input);
        
        var expected = new List<HomeworkConsoleApp.User>
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

        Assert.Equal(expected, result);
    }

    [Fact]
    public void DistinctByIdUsers_ShouldReturnEmptyDictionary_WhenInputIsEmpty()
    {
        // Arrange
        var consoleApp = new HomeworkConsoleApp();
        var input = new List<HomeworkConsoleApp.User>();
        
        // Act
        var result = consoleApp.DistinctByIdUsers(input);
        
        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}