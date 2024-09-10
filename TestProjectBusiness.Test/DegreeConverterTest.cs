using ClassLibraryBusiness;

namespace TestProjectBusiness.Test
{
    [TestFixture]
    public class DegreeConverterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToFahrenheit_ConvertZeroCelsius_Returns32Fahrenheit()
        {
            //Arrange
            double celsuis = 0;

            //Act
            double result=DegreeConverter.ToFahrenheit(celsuis);

            //Assert helps us to verify the expected result
            //Check the output of the code against the expected results.
            //Use assertions to compare the actual values with expected values
            Assert.AreEqual(33,result,0.001);
        }
    }
}