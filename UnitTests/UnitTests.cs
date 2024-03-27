using NUnit.Framework;
using SquareLib;

namespace Tests
{
    public class SquareLibTests
    {
        [Test]
        public void CircleSquare_CalculatedCorrectly()
        {
            Circle circle = new Circle(5);

            var area = circle.CalculateSquare();

            Assert.That(area, Is.EqualTo(78.53981633974483).Within(0.0001));
        }

        [Test]
        public void TriangleSquare_CalculatedCorrectly()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var area = triangle.CalculateSquare();

            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void RightAngledTriangle_IsRightAngled()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var isRightAngled = triangle.IsRightAngled();

            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void NonRightAngledTriangle_IsNotRightAngled()
        {
            Triangle triangle = new Triangle(3, 3, 3);

            var isRightAngled = triangle.IsRightAngled();

            Assert.IsFalse(isRightAngled);
        }
    }
}
