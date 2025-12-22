using Homeworks;

namespace AreSequencesEqual_UnitTest;

public class AreSequencesEqual
{
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_WhenSequencesAreEqual()
    {
        //Arrange
        var EqualSequence = new HomeworkConsoleApp.EqualSequence();
        var list = Enumerable.Range(0, 100).ToList();
        var list1 = Enumerable.Range(0, 100).ToList();

        //Act
        bool result = EqualSequence.AreSequencesEqual(list, list1);

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnFalse_WhenSequencesAreNotEqual()
    {
        //Arrange
        var EqualSequence = new HomeworkConsoleApp.EqualSequence();
        var list = Enumerable.Range(0, 100).ToList();
        var list1 = Enumerable.Range(0, 1).ToList();

        //Act
        bool result = EqualSequence.AreSequencesEqual(list, list1);

        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_WhenSequencesAreEqualAndBig()
    {
        //Arrange
        var EqualSequence = new HomeworkConsoleApp.EqualSequence();
        var list = Enumerable.Range(0, 999999999).ToList();
        var list1 = Enumerable.Range(0, 999999999).ToList();

        //Act
        bool result = EqualSequence.AreSequencesEqual(list, list1);

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AreSequencesEqual_ShouldReturnTrue_WhenNoSequence()
    {
        //Arrange
        var EqualSequence = new HomeworkConsoleApp.EqualSequence();
        var list = Enumerable.Range(0, 0).ToList();
        var list1 = Enumerable.Range(0, 0).ToList();

        //Act
        bool result = EqualSequence.AreSequencesEqual(list, list1);

        // Assert
        Assert.True(result);
    }
}
