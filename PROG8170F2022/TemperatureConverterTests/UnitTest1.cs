using NUnit.Framework;

namespace PROG8170F2022.Tests
{
    [TestFixture]
    public class TempTests
    {
        [Test]
        public void Test_TemperatureConverter_ReturnsTooHot_For30Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 30.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's Too Hot!!", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsTooHot_For40Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 40.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's Too Hot!!", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsPleasant_For20Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 20.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsPleasant_For29Point9Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 29.9f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's pleasant outside", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsQuiteComfortable_For10Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 10.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's quite comfortable", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsQuiteComfortable_For19Point9Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 19.9f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's quite comfortable", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsGettingCold_For0Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 0.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's getting cold out there!", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsGettingCold_For9Point9Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 9.9f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("It's getting cold out there!", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsOutOfRange_ForNegativeTemperature()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = -5.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }


        [Test]
        public void Test_TemperatureConverter_ReturnsOutOfRange_For41Degrees()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = 41.0f;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsOutOfRange_ForNegativeInfinity()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = float.NegativeInfinity;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsOutOfRange_ForPositiveInfinity()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = float.PositiveInfinity;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }

        [Test]
        public void Test_TemperatureConverter_ReturnsOutOfRange_ForNaN()
        {
            // Arrange
            Temp temp = new Temp();
            float ambientTemp = float.NaN;

            // Act
            string result = temp.TemperatureConverter(ambientTemp);

            // Assert
            Assert.AreEqual("Your input temperature is not within the acceptable range", result);
        }
    }
}