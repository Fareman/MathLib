namespace MathLib.Tests;

using MathLib.Shapes;
using Xunit;

public class MathLibTests
{
    [Theory]
    [InlineData(4, 50.26548245743669d)]
    public void CircleSquarePositiveTest(double r, double answer)
    {
        // Act
        var result = new Circle(r).Square();

        // Assert
        Assert.Equal(answer, result);
    }

    [Fact]
    public void CreateCircleNegativeTest()
    {
        // Arrange
        const double r = -1;
        var expression = () => new Circle(r);

        // Assert
        Assert.Throws<ArgumentException>(expression);
    }

    [Fact]
    public void TriagleSquare()
    {
        // Arrange
        const double A = 3;
        const double B = 6;
        const double C = 7;

        const double Answer = 8.9442719099991592;

        // Act
        var result = new Triangle(A, B, C).Square();

        // Assert
        Assert.Equal(Answer, result);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    public void IsTriangleRightPositiveTest(double a, double b, double c)
    {
        const bool Answer = true;

        // Act
        var result = new Triangle(a, b, c).IsRightAngled;

        // Assert
        Assert.Equal(Answer, result);
    }
}