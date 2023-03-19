namespace MathLib.Shapes;

/// <summary>
/// Круг.
/// </summary>
public class Circle : Shape
{
    /// <summary>
    /// Радиус.
    /// </summary>
    private readonly double _radius;

    /// <summary>
    /// Круг.
    /// </summary>
    /// <param name="r"> Радиус. </param>
    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentException(nameof(r));

        _radius = r;
    }

    /// <summary>
    /// Получение площади круга.
    /// </summary>
    /// <returns> Площадь фигуры. </returns>
    public override double Square()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
