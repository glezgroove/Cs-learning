using Homeworks;

namespace EqualSequenceTests;

public class EqualSequenceTests
{
    [Fact]
    public void AreSequencesEqual_ShouldReturnFalse_FirstNullSecondStandart()
    {
        // Arrange
        var equalSequence = new HomeworkConsoleApp.EqualSequence();
        ICollection<HomeworkConsoleApp.User>? firstList = null;
        var secondList = new List<HomeworkConsoleApp.User>
        {
            new() { Id = Guid.NewGuid(), Age = 25 }
        };
        
        // Act
        var result = equalSequence.AreSequencesEqual(firstList, secondList);
        
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_BothNull()
    {
        // Arrange
        var equalSequence = new HomeworkConsoleApp.EqualSequence();
        ICollection<HomeworkConsoleApp.User>? firstList = null;
        ICollection<HomeworkConsoleApp.User>? secondList = null;
        
        // Act
        var result = equalSequence.AreSequencesEqual(firstList, secondList);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_BothEmpty()
    {
        // Arrange
        var equalSequence = new HomeworkConsoleApp.EqualSequence();
        var firstList = new List<HomeworkConsoleApp.User>();
        var secondList = new List<HomeworkConsoleApp.User>();
        
        // Act
        var result = equalSequence.AreSequencesEqual(firstList, secondList);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_BothSame()
    {
        // Arrange
        var equalSequence = new HomeworkConsoleApp.EqualSequence();
        
        var firstList = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50},
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 25},
        };
        
        var secondList = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50},
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 25},
        };
        
        // Act
        var result = equalSequence.AreSequencesEqual(firstList, secondList);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnFalse_BothNotTheSame()
    {
        // Arrange
        var equalSequence = new HomeworkConsoleApp.EqualSequence();
        
        var firstList = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50},
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 25},
        };
        
        var secondList = new List<HomeworkConsoleApp.User>
        {
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), Age = 50},
            new HomeworkConsoleApp.User
                { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Age = 26},
        };
        
        // Act
        var result = equalSequence.AreSequencesEqual(firstList, secondList);
        
        // Assert
        Assert.False(result);
    }
}