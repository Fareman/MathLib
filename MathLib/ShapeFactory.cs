using MathLib.Shapes;

namespace MathLib
{
    /// <summary>
    /// Фабрика фигур.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Создание круга.
        /// </summary>
        /// <param name="r"> Радиус. </param>
        /// <returns> Круг. </returns>
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Создание треугольника.
        /// </summary>
        /// <param name="a"> Сторона треугольника. </param>
        /// <param name="b"> Сторона треугольника. </param>
        /// <param name="c"> Сторона треугольника. </param>
        /// <returns> Треугольник. </returns>
        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        /// <summary>
        /// Посчитать площадь неизвестной заранее фигуры.
        /// </summary>
        /// <param name="shape"> Фигара. </param>
        /// <returns> Площадь. </returns>
        public static double GetArea(IShape shape)
        {
            return shape.Square();
        }
    }
}
