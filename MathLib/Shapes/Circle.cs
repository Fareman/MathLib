namespace MathLib.Shapes;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IShape
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
            throw new ArgumentException("Радиус должен быть больше 0.");

        _radius = r;
    }

    /// <summary>
    /// Получение площади круга.
    /// </summary>
    /// <returns> Площадь фигуры. </returns>
    public double Square()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
