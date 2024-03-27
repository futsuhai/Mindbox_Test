using System;
using SquareLib;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);
            Shape runtimeCircle = new Circle(12);

            var circleSquare = circle.CalculateSquare();
            var runtimeCircleSquare = runtimeCircle.CalculateSquare();
            var triangleSquare = triangle.CalculateSquare();
            var isRightAngled = triangle.IsRightAngled();

            Console.WriteLine($"Площадь круга: {circleSquare}");
            Console.WriteLine($"Площадь runtime круга: {runtimeCircleSquare}");
            Console.WriteLine($"Площадь треугольника: {triangleSquare}");
            Console.WriteLine($"Прямоугольный ли треугольник: {isRightAngled}");
        }
    }
}
