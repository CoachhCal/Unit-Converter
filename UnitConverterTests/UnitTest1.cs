using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;
using Unit_Converter;

namespace UnitConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        private ConversionMethods conversionMethods = new ConversionMethods();

        [DataTestMethod]

        //Volume
        [DataRow("US liquid gallon", .25, "Cubic meter", 0.0009463525)]
        [DataRow("Cubic foot", 25, "US cup", 2949.675)]
        [DataRow("Millilitre", 20, "Cubic foot", 0.0007063)]

        //Mass
        [DataRow("Microgram", 200, "Metric ton", 0.0000000002)]
        [DataRow("Stone (UK)", 15, "Kilogram", 95.2543977)]
        [DataRow("Imperial ton", 25.8, "Ounce", 924672)]

        //Speed
        [DataRow("Foot per second", 5, "Knot", 2.9624190065)]
        [DataRow("Mile per hour", 150, "Foot per second", 220.000000005)]
        [DataRow("Kilometer per hour", 120, "Mile per hour", 74.564543064)]

        //Pressure
        [DataRow("Bar", 15.8, "Standard atmosphere", 15.59338761386)]
        [DataRow("Kilopascal", 25, "Kilopound per square inch", 0.0036259425)]
        [DataRow("Standard atmosphere", 250, "Pound per square inch", 3673.98719375)]

        //Energy
        [DataRow("Joules", 168, "Therms (EC)", 0.000001592332539672)]
        [DataRow("Calories", 970, "Joules", 4061.196)]
        [DataRow("British thermal units (IT)", 28, "Foot-pound", 21788.73934412)]

        //Time
        [DataRow("Nanosecond", 225, "Millennium", 0.0000000000000000071347502853)]
        [DataRow("Month", 12, "Hour", 8760.012)]
        [DataRow("Century", 1, "Minute", 52560000)]

        //Frequency
        [DataRow("Hertz", 175, "Gigahertz", 0.000000175)]
        [DataRow("Kilohertz", 125, "Megahertz", 0.125)]
        [DataRow("Gigahertz", 5, "Kilohertz", 5000000)]

        //Temperature
        [DataRow("Celsius", 43.2, "Kelvin", 316.35)]
        [DataRow("Fahrenheit", 67, "Celsius", 19.444444444444444444444444444444)]
        [DataRow("Kelvin", 120, "Fahrenheit", -243.67)]

        //Length
        [DataRow("Nanometer", 350, "Nautical mile", 0.000000000188986)]
        [DataRow("Kilometer", 3, "Foot", 9842.519685)]
        [DataRow("Mile", 2, "Inch", 126720)]

        //Area
        [DataRow("Square millimeter", 1250, "Square mile", 0.000000000482625)]
        [DataRow("Acres", 3.25, "Square inch", 20386080)]
        [DataRow("Square kilometer", 5, "Square foot", 53819552.08355)]

        public void TestMethod(string unitToConvert, double value, string resultUnit, double expected)
        {
            string methodName = modifyString(unitToConvert);
            MethodInfo methodInfo = typeof(ConversionMethods).GetMethod(methodName);
            Object[] parameters = { resultUnit, value };
            double result = (double)methodInfo.Invoke(conversionMethods, parameters);
            Assert.AreEqual(expected, result, 0.0001, $"Conversion from {unitToConvert} to {resultUnit} failed.");
        }
        private string modifyString(string str) {
            
            string fixedString = new string((from c in str
                                             where char.IsLetter(c)
                                             select c
                   ).ToArray());
            return fixedString; 
        }
    }
}
