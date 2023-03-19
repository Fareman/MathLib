namespace MathLib.Shapes;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    /// Сторона треугольника.
    /// </summary>
    private readonly double _sideA;

    /// <summary>
    /// Сторона треугольника.
    /// </summary>
    private readonly double _sideB;

    /// <summary>
    /// Сторона треугольника.
    /// </summary>
    private readonly double _sideC;

    /// <summary>
    /// Является ли прямоугольник прямоугольным.
    /// </summary>
    public readonly bool IsRightAngled;

    /// <summary>
    /// Треугольник.
    /// </summary>
    /// <param name="a"> Сторона треугольника. </param>
    /// <param name="b"> Сторона треугольника. </param>
    /// <param name="c"> Сторона треугольника. </param>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Сторона не может быть меньше или равна 0.");

        _sideA = a;
        _sideB = b;
        _sideC = c;
        IsRightAngled = IsRight();
    }

    /// <summary>
    /// Получение площади треугольника.
    /// </summary>
    /// <returns> Площадь треугольника. </returns>
    public double Square()
    {
        var s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    /// <summary>
    /// Проверка на правильность треугольника.
    /// </summary>
    /// <returns> True - треугольник прямоугольный, иначе - False. </returns>
    private bool IsRight()
    {
        var sides = new List<double> { _sideA, _sideB, _sideC };
        var hypotenuse = sides.Max();
        var cathetuses = sides.Where(s => s != hypotenuse).Select(s => Math.Pow(s, 2)).Sum();

        return Math.Sqrt(cathetuses) == hypotenuse;
    }
}
