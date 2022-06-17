namespace BL.Tests;

public class HandlerTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(45)]
    [InlineData(int.MaxValue)]
    public void DetermineNumber_ForPositive_ReturnPositiveString(int value)
    {
        // Arrange
        var handler = new Handler();

        // Act
        var result = handler.DetermineNumber(value);

        // Assert
        Assert.Equal("positive", result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-35478)]
    [InlineData(int.MinValue)]
    public void DetermineNumber_ForNegative_ReturnNegativeString(int value)
    {
        // Arrange
        var handler = new Handler();

        // Act
        var result = handler.DetermineNumber(value);

        // Assert
        Assert.Equal("negative", result);
    }

    [Fact]
    public void DetermineNumber_ForZero_ReturnZeroString()
    {
        // Arrange
        var handler = new Handler();

        // Act
        var result = handler.DetermineNumber(0);

        // Assert
        Assert.Equal("zero", result);
    }

}