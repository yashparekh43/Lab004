using NUnit.Framework;

namespace TriangleTests
{
    [TestFixture]
    public class Triangle01Tests
    {
        [Test]
        public void Triangle01_Constructor_ValidInput_SetsProperties()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            // Act
            var triangle = new Triangle01(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }

        [Test]
        public void Triangle01_IsValid_ValidTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle01(3, 4, 5);

            // Act
            bool isValid = triangle.IsValid();

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void Triangle01_IsValid_InvalidTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle01(1, 1, 10);

            // Act
            bool isValid = triangle.IsValid();

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void Triangle01_IsEquilateral_ValidEquilateralTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle01(5, 5, 5);

            // Act
            bool isEquilateral = triangle.IsEquilateral();

            // Assert
            Assert.IsTrue(isEquilateral);
        }

        [Test]
        public void Triangle01_IsEquilateral_NotEquilateralTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle01(3, 4, 5);

            // Act
            bool isEquilateral = triangle.IsEquilateral();

            // Assert
            Assert.IsFalse(isEquilateral);
        }

        [Test]
        public void Triangle01_IsIsosceles_ValidIsoscelesTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle01(5, 5, 8);

            // Act
            bool isIsosceles = triangle.IsIsosceles();

            // Assert
            Assert.IsTrue(isIsosceles);
        }

        [Test]
        public void Triangle01_IsIsosceles_NotIsoscelesTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle01(3, 4, 5);

            // Act
            bool isIsosceles = triangle.IsIsosceles();

            // Assert
            Assert.IsFalse(isIsosceles);
        }

        [Test]
        public void Triangle01_IsScalene_ValidScaleneTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle01(3, 4, 6);

            // Act
            bool isScalene = triangle.IsScalene();

            // Assert
            Assert.IsTrue(isScalene);
        }

        [Test]
        public void Triangle01_IsScalene_NotScaleneTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle01(3, 3, 3);

            // Act
            bool isScalene = triangle.IsScalene();

            // Assert
            Assert.IsFalse(isScalene);
        }
    }
}
