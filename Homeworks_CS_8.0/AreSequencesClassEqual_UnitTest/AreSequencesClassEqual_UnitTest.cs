using Homeworks;
using Homeworks;

namespace AreSequencesClassEqual_UnitTest;

public class AreSequencesClassEqual_UnitTest
{
    private readonly HomeworkConsoleApp.SequenceComparer _comparer = new HomeworkConsoleApp.SequenceComparer();

    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_BothListsNull()
    {
        // Arrange
        ICollection<HomeworkConsoleApp.TheUser> firstList = null;
        ICollection<HomeworkConsoleApp.TheUser> secondList = null;

        // Act
        var result = _comparer.AreSequencesEqual(firstList, secondList);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AreSequencesEqual_ShouldReturnFalse_FirstNullSecondNotNull()
    {
        // Arrange
        ICollection<HomeworkConsoleApp.TheUser> firstList = null;
        var secondList = new List<HomeworkConsoleApp.TheUser>
        {
            new() { Id = Guid.NewGuid(), Age = 25 }
        };

        // Act
        var result = _comparer.AreSequencesEqual(firstList, secondList);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_SameUsers()
    {
        // Arrange
        var userId1 = Guid.NewGuid();
        var userId2 = Guid.NewGuid();

        var firstList = new List<HomeworkConsoleApp.TheUser>
        {
            new() { Id = userId1, Age = 25 },
            new() { Id = userId2, Age = 30 }
        };

        var secondList = new List<HomeworkConsoleApp.TheUser>
        {
            new() { Id = userId1, Age = 25 },
            new() { Id = userId2, Age = 30 }
        };

        // Act
        var result = _comparer.AreSequencesEqual(firstList, secondList);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AreSequencesEqual_ShouldReturnFalse_DifferentAges()
    {
        // Arrange
        var userId1 = Guid.NewGuid();
        var userId2 = Guid.NewGuid();

        var firstList = new List<HomeworkConsoleApp.TheUser>
        {
            new() { Id = userId1, Age = 25 },
            new() { Id = userId2, Age = 30 }
        };

        var secondList = new List<HomeworkConsoleApp.TheUser>
        {
            new() { Id = userId1, Age = 25 },
            new() { Id = userId2, Age = 31 }
        };

        // Act
        var result = _comparer.AreSequencesEqual(firstList, secondList);

        // Assert
        Assert.False(result);
    }
}