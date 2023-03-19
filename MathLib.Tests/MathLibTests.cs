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

    [Theory]
    [InlineData(-1, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, -1)]
    public void CreateTriagleNegativeSideTest(double a, double b, double c)
    {
        // Act
        var expression = () => new Triangle(a, b, c);

        // Assert
        Assert.Throws<ArgumentException>(expression);
    }

    [Theory]
    [InlineData(3, 6, 7, 8.9442719099991592)]
    public void TriagleSquarePositiveTest(double a, double b, double c, double answer)
    {
        // Act
        var result = new Triangle(a, b, c).Square();

        // Assert
        Assert.Equal(answer, result);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    public void IsTriangleRightPositiveTest(double a, double b, double c, bool answer)
    {
        // Act
        var result = new Triangle(a, b, c).IsRightAngled;

        // Assert
        Assert.True(answer == result);
    }

    [Fact]
    public void UnknownShapeTest()
    {
        // Arrange
        const double Answer = 78.539816339744831;
        const double Radius = 5;

        // Act
        var circle = ShapeFactory.CreateCircle(Radius);
        var result = circle.Square();

        // Assert
        Assert.Equal(Answer, result);
    }
}