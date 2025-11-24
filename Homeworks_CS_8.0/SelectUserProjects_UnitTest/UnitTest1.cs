using Homeworks;

namespace SelectUserProjects_UnitTest;

public class UnitTest1
{
    [Fact]
    public void SelectUserProjects_ShouldReturnStandartOutput_StandartInputAllAges()
    {
        //Arrange (4 users created, 3 projects)
        var consoleApp = new HomeworkConsoleApp();
        var users = new List<HomeworkConsoleApp.User2>
        {
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50, Name = "Marina",
                Projects = new List<HomeworkConsoleApp.Project>
                {
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-1000-100000000000"), Name = "Resolver" },
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-1000-200000000000"), Name = "Projecto" }
                }
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega"
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 60, Name = "SeregaBandit",
                Projects = new List<HomeworkConsoleApp.Project>
                {
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-3000-100000000000"), Name = "NedoResolver" }
                }
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 65, Name = "SeregaOlimp"
            }
        };
        
        //Act
        var result = consoleApp.SelectUserProjects(users, 40);

        IList<HomeworkConsoleApp.Project> expected = new List<HomeworkConsoleApp.Project>
        {
            new HomeworkConsoleApp.Project()
                { Id = Guid.Parse("00000000-0000-0000-1000-100000000000"), Name = "Resolver" },
            new HomeworkConsoleApp.Project()
                { Id = Guid.Parse("00000000-0000-0000-1000-200000000000"), Name = "Projecto" },
            new HomeworkConsoleApp.Project()
                { Id = Guid.Parse("00000000-0000-0000-3000-100000000000"), Name = "NedoResolver" },
        };

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SelectUserProjects_ShouldReturnOnlyOneProjectWithCorrectAge_StandartInputOnlyOneUserIsFine()
    {
        //Arrange (4 users created, 3 projects)
        var consoleApp = new HomeworkConsoleApp();
        var users = new List<HomeworkConsoleApp.User2>
        {
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50, Name = "Marina",
                Projects = new List<HomeworkConsoleApp.Project>
                {
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-1000-100000000000"), Name = "Resolver" },
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-1000-200000000000"), Name = "Projecto" }
                }
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 55, Name = "Serega"
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Age = 60, Name = "SeregaBandit",
                Projects = new List<HomeworkConsoleApp.Project>
                {
                    new HomeworkConsoleApp.Project { Id = Guid.Parse("00000000-0000-0000-3000-100000000000"), Name = "NedoResolver" }
                }
            },
            new HomeworkConsoleApp.User2
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 65, Name = "SeregaOlimp"
            }
        };
        
        //Act
        var result = consoleApp.SelectUserProjects(users, 58);

        IList<HomeworkConsoleApp.Project> expected = new List<HomeworkConsoleApp.Project>
        {
            new HomeworkConsoleApp.Project()
                { Id = Guid.Parse("00000000-0000-0000-3000-100000000000"), Name = "NedoResolver" },
        };

        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SelectUserProjects_ShouldReturnEmptyArray_EmptyArrayInput()
    {
        //Arrange
        var consoleApp = new HomeworkConsoleApp();
        var users = new List<HomeworkConsoleApp.User2>
        { };
        
        //Act
        var result = consoleApp.SelectUserProjects(users, -1);

        IList<HomeworkConsoleApp.Project> expected = new List<HomeworkConsoleApp.Project>
        { };

        //Assert
        Assert.Equal(expected, result);
    }
}