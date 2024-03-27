namespace SquareLib
{
    public abstract class Shape
    {
        public abstract double CalculateSquare();
    }

    public class Circle(double radius) : Shape
    {
        public double Radius = radius;

        public override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle(double side1, double side2, double side3) : Shape
    {
        public double Side1 = side1;
        public double Side2 = side2;
        public double Side3 = side3;

        public override double CalculateSquare()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public bool IsRightAngled()
        {
            List<double> sides = [Side1, Side2, Side3];
            sides.Sort();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}