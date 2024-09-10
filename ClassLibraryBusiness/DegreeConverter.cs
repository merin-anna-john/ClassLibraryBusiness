namespace ClassLibraryBusiness
{
    public class DegreeConverter
    {
        //To Fahrenheit
        public static double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        //To Celsius
        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
