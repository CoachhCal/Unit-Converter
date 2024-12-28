using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class ConversionMethods
    {

        /// <summary>
        /// 
        /// Volume
        /// 
        /// </summary>

        public double USliquidgallon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number;
                case "US liquid quart": return number * 4;
                case "US liquid pint": return number * 8;
                case "US cup": return number * 15.7725;
                case "US fluid ounce": return number * 128;
                case "US tablespoon": return number * 256;
                case "US teaspoon": return number * 768;
                case "Cubic meter": return number * 0.00378541;
                case "Liter": return number * 3.78541;
                case "Milliliter": return number * 3785.41;
                case "Imperial gallon": return number * 0.832674;
                case "Imperial quart": return number * 3.3307;
                case "Imperial pint": return number * 6.66139;
                case "Imperial cup": return number * 13.3228;
                case "Imperial fluid ounce": return number * 133.228;
                case "Imperial tablespoon": return number * 213.165;
                case "Imperial teaspoon": return number * 639.494;
                case "Cubic foot": return number * 0.133681;
                case "Cubic inch": return number * 231;

                default: return 0;
            }
        }

        public double USliquidquart(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.25;
                case "US liquid quart": return number;
                case "US liquid pint": return number * 2;
                case "US cup": return number * 3.94314;
                case "US fluid ounce": return number * 32;
                case "US tablespoon": return number * 64;
                case "US teaspoon": return number * 192;
                case "Cubic meter": return number * 0.000946353;
                case "Liter": return number * 0.946353;
                case "Milliliter": return number * 946.353;
                case "Imperial gallon": return number * 0.208169;
                case "Imperial quart": return number * 0.832674;
                case "Imperial pint": return number * 1.66535;
                case "Imperial cup": return number * 3.3307;
                case "Imperial fluid ounce": return number * 33.307;
                case "Imperial tablespoon": return number * 53.2911;
                case "Imperial teaspoon": return number * 159.873;
                case "Cubic foot": return number * 0.0334201;
                case "Cubic inch": return number * 57.75;

                default: return 0;
            }
        }

        public double USliquidpint(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.125;
                case "US liquid quart": return number * 0.5;
                case "US liquid pint": return number;
                case "US cup": return number * 1.97157;
                case "US fluid ounce": return number * 16;
                case "US tablespoon": return number * 32;
                case "US teaspoon": return number * 96;
                case "Cubic meter": return number * 0.000473176;
                case "Liter": return number * 0.473176;
                case "Milliliter": return number * 473.176;
                case "Imperial gallon": return number * 0.104084;
                case "Imperial quart": return number * 0.416337;
                case "Imperial pint": return number * 0.832674;
                case "Imperial cup": return number * 1.66535;
                case "Imperial fluid ounce": return number * 16.6535;
                case "Imperial tablespoon": return number * 26.6456;
                case "Imperial teaspoon": return number * 79.9367;
                case "Cubic foot": return number * 0.0167101;
                case "Cubic inch": return number * 28.875;
                default: return 0;
            }
        }

        public double UScup(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.0634013;
                case "US liquid quart": return number * 0.253605;
                case "US liquid pint": return number * 0.50721;
                case "US cup": return number;
                case "US fluid ounce": return number * 8.11537;
                case "US tablespoon": return number * 16.2307;
                case "US teaspoon": return number * 48.6922;
                case "Cubic meter": return number * 0.00024;
                case "Liter": return number * 0.24;
                case "Milliliter": return number * 240;
                case "Imperial gallon": return number * 0.0527926;
                case "Imperial quart": return number * 0.21117;
                case "Imperial pint": return number * 0.422341;
                case "Imperial cup": return number * 0.844682;
                case "Imperial fluid ounce": return number * 8.44682;
                case "Imperial tablespoon": return number * 13.5149;
                case "Imperial teaspoon": return number * 40.5447;
                case "Cubic foot": return number * 0.00847552;
                case "Cubic inch": return number * 14.6457;
                default: return 0;
            }
        }

        public double USfluidounce(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.0078125;
                case "US liquid quart": return number * 0.03125;
                case "US liquid pint": return number * 0.0625;
                case "US cup": return number * 0.123223;
                case "US fluid ounce": return number;
                case "US tablespoon": return number * 2;
                case "US teaspoon": return number * 6;
                case "Cubic meter": return number * 2.9574e-5;
                case "Liter": return number * 0.0295735;
                case "Milliliter": return number * 29.5735;
                case "Imperial gallon": return number * 0.00650527;
                case "Imperial quart": return number * 0.0260211;
                case "Imperial pint": return number * 0.0520421;
                case "Imperial cup": return number * 0.104084;
                case "Imperial fluid ounce": return number * 1.04084;
                case "Imperial tablespoon": return number * 1.66535;
                case "Imperial teaspoon": return number * 4.99604;
                case "Cubic foot": return number * 0.00104438;
                case "Cubic inch": return number * 1.80469;
                default: return 0;
            }
        }

        public double UStablespoon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.00390625;
                case "US liquid quart": return number * 0.015625;
                case "US liquid pint": return number * 0.03125;
                case "US cup": return number * 0.0616115;
                case "US fluid ounce": return number * 0.5;
                case "US tablespoon": return number;
                case "US teaspoon": return number * 3;
                case "Cubic meter": return number * 1.4787e-5;
                case "Liter": return number * 0.0147868;
                case "Milliliter": return number * 14.7868;
                case "Imperial gallon": return number * 0.00325263;
                case "Imperial quart": return number * 0.0130105;
                case "Imperial pint": return number * 0.0260211;
                case "Imperial cup": return number * 0.0520421;
                case "Imperial fluid ounce": return number * 0.520421;
                case "Imperial tablespoon": return number * 0.832674;
                case "Imperial teaspoon": return number * 2.49802;
                case "Cubic foot": return number * 0.00052219;
                case "Cubic inch": return number * 0.902344;
                default: return 0;
            }
        }

        public double USteaspoon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.00130208;
                case "US liquid quart": return number * 0.00520833;
                case "US liquid pint": return number * 0.0104167;
                case "US cup": return number * 0.0205372;
                case "US fluid ounce": return number * 0.166667;
                case "US tablespoon": return number * 0.333333;
                case "US teaspoon": return number;
                case "Cubic meter": return number * 4.9289e-6;
                case "Liter": return number * 0.00492892;
                case "Milliliter": return number * 4.92892;
                case "Imperial gallon": return number * 0.00108421;
                case "Imperial quart": return number * 0.00433684;
                case "Imperial pint": return number * 0.00867369;
                case "Imperial cup": return number * 0.0173474;
                case "Imperial fluid ounce": return number * 0.173474;
                case "Imperial tablespoon": return number * 0.277558;
                case "Imperial teaspoon": return number * 0.832674;
                case "Cubic foot": return number * 0.000174063;
                case "Cubic inch": return number * 0.300781;
                default: return 0;
            }
        }

        public double Cubicmeter(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 264.172;
                case "US liquid quart": return number * 1056.69;
                case "US liquid pint": return number * 2113.38;
                case "US cup": return number * 4166.67;
                case "US fluid ounce": return number * 33814;
                case "US tablespoon": return number * 67628;
                case "US teaspoon": return number * 202884;
                case "Cubic meter": return number;
                case "Liter": return number * 1000;
                case "Milliliter": return number * 1e+6;
                case "Imperial gallon": return number * 219.969;
                case "Imperial quart": return number * 879.877;
                case "Imperial pint": return number * 1759.75;
                case "Imperial cup": return number * 3519.51;
                case "Imperial fluid ounce": return number * 35195.1;
                case "Imperial tablespoon": return number * 56312.1;
                case "Imperial teaspoon": return number * 168936;
                case "Cubic foot": return number * 35.3147;
                case "Cubic inch": return number * 61023.7;
                default: return 0;
            }
        }

        public double Litre(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.264172;
                case "US liquid quart": return number * 1.05669;
                case "US liquid pint": return number * 2.11338;
                case "US cup": return number * 4.16667;
                case "US fluid ounce": return number * 33.814;
                case "US tablespoon": return number * 67.628;
                case "US teaspoon": return number * 202.884;
                case "Cubic meter": return number * 0.001;
                case "Liter": return number;
                case "Milliliter": return number * 1000;
                case "Imperial gallon": return number * 0.219969;
                case "Imperial quart": return number * 0.879877;
                case "Imperial pint": return number * 1.75975;
                case "Imperial cup": return number * 3.51951;
                case "Imperial fluid ounce": return number * 35.1951;
                case "Imperial tablespoon": return number * 56.3121;
                case "Imperial teaspoon": return number * 168.936;
                case "Cubic foot": return number * 0.0353147;
                case "Cubic inch": return number * 61.0237;
                default: return 0;
            }
        }

        public double Millilitre(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.000264172;
                case "US liquid quart": return number * 0.00105669;
                case "US liquid pint": return number * 0.00211338;
                case "US cup": return number * 0.00416667;
                case "US fluid ounce": return number * 0.033814;
                case "US tablespoon": return number * 0.067628;
                case "US teaspoon": return number * 0.202884;
                case "Cubic meter": return number * 1e-6;
                case "Liter": return number * 0.001;
                case "Milliliter": return number;
                case "Imperial gallon": return number * 0.000219969;
                case "Imperial quart": return number * 0.000879877;
                case "Imperial pint": return number * 0.00175975;
                case "Imperial cup": return number * 0.00351951;
                case "Imperial fluid ounce": return number * 0.0351951;
                case "Imperial tablespoon": return number * 0.0563121;
                case "Imperial teaspoon": return number * 0.168936;
                case "Cubic foot": return number * 3.5315e-5;
                case "Cubic inch": return number * 0.0610237;
                default: return 0;
            }
        }

        public double Imperialgallon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 1.20095;
                case "US liquid quart": return number * 4.8038;
                case "US liquid pint": return number * 9.6076;
                case "US cup": return number * 18.942;
                case "US fluid ounce": return number * 153.722;
                case "US tablespoon": return number * 307.443;
                case "US teaspoon": return number * 922.33;
                case "Cubic meter": return number * 0.00454609;
                case "Liter": return number * 4.54609;
                case "Milliliter": return number * 4546.09;
                case "Imperial gallon": return number;
                case "Imperial quart": return number * 4;
                case "Imperial pint": return number * 8;
                case "Imperial cup": return number * 16;
                case "Imperial fluid ounce": return number * 160;
                case "Imperial tablespoon": return number * 256;
                case "Imperial teaspoon": return number * 768;
                case "Cubic foot": return number * 0.160544;
                case "Cubic inch": return number * 277.419;
                default: return 0;
            }
        }

        public double Imperialquart(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.300237;
                case "US liquid quart": return number * 1.20095;
                case "US liquid pint": return number * 2.4019;
                case "US cup": return number * 4.73551;
                case "US fluid ounce": return number * 38.4304;
                case "US tablespoon": return number * 76.8608;
                case "US teaspoon": return number * 230.582;
                case "Cubic meter": return number * 0.00113652;
                case "Liter": return number * 1.13652;
                case "Milliliter": return number * 1136.52;
                case "Imperial gallon": return number * 0.25;
                case "Imperial quart": return number;
                case "Imperial pint": return number * 2;
                case "Imperial cup": return number * 4;
                case "Imperial fluid ounce": return number * 40;
                case "Imperial tablespoon": return number * 64;
                case "Imperial teaspoon": return number * 192;
                case "Cubic foot": return number * 0.0401359;
                case "Cubic inch": return number * 69.3549;
                default: return 0;
            }
        }

        public double Imperialpint(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.150119;
                case "US liquid quart": return number * 0.600475;
                case "US liquid pint": return number * 1.20095;
                case "US cup": return number * 2.36776;
                case "US fluid ounce": return number * 19.2152;
                case "US tablespoon": return number * 38.4304;
                case "US teaspoon": return number * 115.291;
                case "Cubic meter": return number * 0.000568261;
                case "Liter": return number * 0.568261;
                case "Milliliter": return number * 568.261;
                case "Imperial gallon": return number * 0.125;
                case "Imperial quart": return number * 0.5;
                case "Imperial pint": return number;
                case "Imperial cup": return number * 2;
                case "Imperial fluid ounce": return number * 20;
                case "Imperial tablespoon": return number * 32;
                case "Imperial teaspoon": return number * 96;
                case "Cubic foot": return number * 0.020068;
                case "Cubic inch": return number * 34.6774;
                default: return 0;
            }
        }

        public double Imperialcup(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.0750594;
                case "US liquid quart": return number * 0.300237;
                case "US liquid pint": return number * 0.600475;
                case "US cup": return number * 1.18388;
                case "US fluid ounce": return number * 9.6076;
                case "US tablespoon": return number * 19.2152;
                case "US teaspoon": return number * 57.6456;
                case "Cubic meter": return number * 0.000284131;
                case "Liter": return number * 0.284131;
                case "Milliliter": return number * 284.131;
                case "Imperial gallon": return number * 0.0625;
                case "Imperial quart": return number * 0.25;
                case "Imperial pint": return number * 0.5;
                case "Imperial cup": return number;
                case "Imperial fluid ounce": return number * 10;
                case "Imperial tablespoon": return number * 16;
                case "Imperial teaspoon": return number * 48;
                case "Cubic foot": return number * 0.010034;
                case "Cubic inch": return number * 17.3387;
                default: return 0;
            }
        }

        public double Imperialfluidounce(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.00750594;
                case "US liquid quart": return number * 0.0300237;
                case "US liquid pint": return number * 0.0600475;
                case "US cup": return number * 0.118388;
                case "US fluid ounce": return number * 0.96076;
                case "US tablespoon": return number * 1.92152;
                case "US teaspoon": return number * 5.76456;
                case "Cubic meter": return number * 2.8413e-5;
                case "Liter": return number * 0.0284131;
                case "Milliliter": return number * 28.4131;
                case "Imperial gallon": return number * 0.00625;
                case "Imperial quart": return number * 0.025;
                case "Imperial pint": return number * 0.05;
                case "Imperial cup": return number * 0.1;
                case "Imperial fluid ounce": return number;
                case "Imperial tablespoon": return number * 1.6;
                case "Imperial teaspoon": return number * 4.8;
                case "Cubic foot": return number * 0.0010034;
                case "Cubic inch": return number * 1.73387;
                default: return 0;
            }
        }

        public double Imperialtablespoon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.00469121;
                case "US liquid quart": return number * 0.0187649;
                case "US liquid pint": return number * 0.0375297;
                case "US cup": return number * 0.0739924;
                case "US fluid ounce": return number * 0.600475;
                case "US tablespoon": return number * 1.20095;
                case "US teaspoon": return number * 3.60285;
                case "Cubic meter": return number * 1.7758e-5;
                case "Liter": return number * 0.0177582;
                case "Milliliter": return number * 17.7582;
                case "Imperial gallon": return number * 0.00390625;
                case "Imperial quart": return number * 0.015625;
                case "Imperial pint": return number * 0.03125;
                case "Imperial cup": return number * 0.0625;
                case "Imperial fluid ounce": return number * 0.625;
                case "Imperial tablespoon": return number;
                case "Imperial teaspoon": return number * 3;
                case "Cubic foot": return number * 0.000627124;
                case "Cubic inch": return number * 1.08367;
                default: return 0;
            }
        }

        public double Imperialteaspoon(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.00156374;
                case "US liquid quart": return number * 0.00625495;
                case "US liquid pint": return number * 0.0125099;
                case "US cup": return number * 0.0246641;
                case "US fluid ounce": return number * 0.200158;
                case "US tablespoon": return number * 0.400317;
                case "US teaspoon": return number * 1.20095;
                case "Cubic meter": return number * 5.9194e-6;
                case "Liter": return number * 0.00591939;
                case "Milliliter": return number * 5.91939;
                case "Imperial gallon": return number * 0.00130208;
                case "Imperial quart": return number * 0.00520834;
                case "Imperial pint": return number * 0.0104167;
                case "Imperial cup": return number * 0.0208333;
                case "Imperial fluid ounce": return number * 0.208333;
                case "Imperial tablespoon": return number * 0.333333;
                case "Imperial teaspoon": return number * 3;
                case "Cubic foot": return number * 0.000209041;
                case "Cubic inch": return number * 0.361223;
                default: return 0;
            }
        }

        public double Cubicfoot(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 7.48052;
                case "US liquid quart": return number * 29.9221;
                case "US liquid pint": return number * 59.8442;
                case "US cup": return number * 117.987;
                case "US fluid ounce": return number * 957.506;
                case "US tablespoon": return number * 1915.01;
                case "US teaspoon": return number * 5745.04;
                case "Cubic meter": return number * 0.0283168;
                case "Liter": return number * 28.3168;
                case "Milliliter": return number * 28316.8;
                case "Imperial gallon": return number * 6.22884;
                case "Imperial quart": return number * 24.9153;
                case "Imperial pint": return number * 49.8307;
                case "Imperial cup": return number * 99.6614;
                case "Imperial fluid ounce": return number * 996.614;
                case "Imperial tablespoon": return number * 1594.58;
                case "Imperial teaspoon": return number * 4783.74;
                case "Cubic foot": return number * 0.000209041;
                case "Cubic inch": return number * 1728;
                default: return 0;
            }
        }

        public double Cubicinch(string unit, double number)
        {
            switch (unit)
            {
                case "US liquid gallon": return number * 0.004329;
                case "US liquid quart": return number * 0.017316;
                case "US liquid pint": return number * 0.034632;
                case "US cup": return number * 0.0682794;
                case "US fluid ounce": return number * 0.554113;
                case "US tablespoon": return number * 1.10823;
                case "US teaspoon": return number * 3.32468;
                case "Cubic meter": return number * 1.6387e-5;
                case "Liter": return number * 0.0163871;
                case "Milliliter": return number * 16.3871;
                case "Imperial gallon": return number * 0.00360465;
                case "Imperial quart": return number * 0.0144186;
                case "Imperial pint": return number * 0.0288372;
                case "Imperial cup": return number * 0.0576744;
                case "Imperial fluid ounce": return number * 0.576744;
                case "Imperial tablespoon": return number * 0.92279;
                case "Imperial teaspoon": return number * 2.76837;
                case "Cubic foot": return number * 0.000578704;
                case "Cubic inch": return number * 1728;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Mass
        /// 
        /// </summary>

        public double Microgram(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number;
                case "Milligram": return number * 0.001;
                case "Gram": return number * 0.000001;
                case "Ounce": return number * 3.527396194E-8;
                case "Pound": return number * 2.204622621E-9;
                case "Kilogram": return number * 1.0E-9;
                case "Stone (UK)": return number * 1.574730444E-10;
                case "US ton": return number * 1.10231131E-12;
                case "Imperial ton": return number * 9.842065276E-13;
                case "Metric ton": return number * 1.0E-12;
                default: return 0;
            }
        }

        public double Milligram(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 1000;
                case "Milligram": return number;
                case "Gram": return number * 0.001;
                case "Ounce": return number * 0.000035274;
                case "Pound": return number * 0.0000022046;
                case "Kilogram": return number * 0.000001;
                case "Stone (UK)": return number * 1.574730444E-7;
                case "US ton": return number * 0.0000342857;
                case "Imperial ton": return number * 0.0000306122;
                case "Metric ton": return number * 1.0E-9;
                default: return 0;
            }
        }

        public double Gram(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 1000000;
                case "Milligram": return number * 1000;
                case "Gram": return number;
                case "Ounce": return number * 0.0352739619;
                case "Pound": return number * 0.0022046226;
                case "Kilogram": return number * 0.001;
                case "Stone (UK)": return number * 0.000157473;
                case "US ton": return number * 0.0000011023;
                case "Imperial ton": return number * 9.842065276E-7;
                case "Metric ton": return number * 0.000001;
                default: return 0;
            }
        }

        public double Ounce(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 28349523.125;
                case "Milligram": return number * 28349.523125;
                case "Gram": return number * 28.349523125;
                case "Ounce": return number;
                case "Pound": return number * 0.0625;
                case "Kilogram": return number * 0.0283495231;
                case "Stone (UK)": return number * 0.0044642857;
                case "US ton": return number * 0.00003125;
                case "Imperial ton": return number * 0.0000279018;
                case "Metric ton": return number * 0.0000283495;
                default: return 0;
            }
        }

        public double Pound(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 453592370;
                case "Milligram": return number * 453592.37;
                case "Gram": return number * 453.59237;
                case "Ounce": return number * 16;
                case "Pound": return number;
                case "Kilogram": return number * 0.45359237;
                case "Stone (UK)": return number * 0.0714285714;
                case "US ton": return number * 0.0005;
                case "Imperial ton": return number * 0.0004464286;
                case "Metric ton": return number * 0.0004535924;
                default: return 0;
            }
        }

        public double Kilogram(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 1000000000;
                case "Milligram": return number * 1000000;
                case "Gram": return number * 1000;
                case "Ounce": return number * 35.27396195;
                case "Pound": return number * 2.2046226218;
                case "Kilogram": return number;
                case "Stone (UK)": return number * 0.1574730444;
                case "US ton": return number * 0.0011023113;
                case "Imperial ton": return number * 0.0009842065;
                case "Metric ton": return number * 0.001;
                default: return 0;
            }
        }

        public double StoneUK(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 6350293180;
                case "Milligram": return number * 6350293.18;
                case "Gram": return number * 6350.29318;
                case "Ounce": return number * 224;
                case "Pound": return number * 14;
                case "Kilogram": return number * 6.35029318;
                case "Stone (UK)": return number;
                case "US ton": return number * 0.007;
                case "Imperial ton": return number * 0.00625;
                case "Metric ton": return number * 0.0063502932;
                default: return 0;
            }
        }

        public double USton(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 907184740000;
                case "Milligram": return number * 907184740;
                case "Gram": return number * 907184.74;
                case "Ounce": return number * 32000;
                case "Pound": return number * 2000;
                case "Kilogram": return number * 907.18474;
                case "Stone (UK)": return number * 142.85714286;
                case "US ton": return number;
                case "Imperial ton": return number * 0.8928571429;
                case "Metric ton": return number * 0.90718474;
                default: return 0;
            }
        }

        public double Imperialton(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 1016046908800;
                case "Milligram": return number * 1016046908.8;
                case "Gram": return number * 1016046.9088;
                case "Ounce": return number * 35840;
                case "Pound": return number * 2240;
                case "Kilogram": return number * 1016.0469088;
                case "Stone (UK)": return number * 160;
                case "US ton": return number * 1.12;
                case "Imperial ton": return number;
                case "Metric ton": return number * 1.0160469088;
                default: return 0;
            }
        }

        public double Metricton(string unit, double number)
        {
            switch (unit)
            {
                case "Microgram": return number * 1000000000000;
                case "Milligram": return number * 1000000000;
                case "Gram": return number * 1000000;
                case "Ounce": return number * 35273.96195;
                case "Pound": return number * 2204.6226218;
                case "Kilogram": return number * 1000;
                case "Stone (UK)": return number * 157.47304442;
                case "US ton": return number * 1.1023113109;
                case "Imperial ton": return number * 0.9842065276;
                case "Metric ton": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Speed
        /// 
        /// </summary>

        public double Footpersecond(string unit, double number)
        {
            switch (unit)
            {
                case "Foot per second": return number;
                case "Meter per second": return number * 0.3048;
                case "Kilometer per hour": return number * 1.09728;
                case "Mile per hour": return number * 0.6818181818;
                case "Knot": return number * 0.5924838013;
                default: return 0;
            }
        }

        public double Meterpersecond(string unit, double number)
        {
            switch (unit)
            {
                case "Foot per second": return number * 3.280839895;
                case "Meter per second": return number;
                case "Kilometer per hour": return number * 3.6;
                case "Mile per hour": return number * 2.2369362921;
                case "Knot": return number * 1.9438444924;
                default: return 0;
            }
        }

        public double Kilometerperhour(string unit, double number)
        {
            switch (unit)
            {
                case "Foot per second": return number * 0.9113444153;
                case "Meter per second": return number * 0.2777777778;
                case "Kilometer per hour": return number;
                case "Mile per hour": return number * 0.6213711922;
                case "Knot": return number * 0.5399568035;
                default: return 0;
            }
        }

        public double Mileperhour(string unit, double number)
        {
            switch (unit)
            {
                case "Foot per second": return number * 1.4666666667;
                case "Meter per second": return number * 0.44704;
                case "Kilometer per hour": return number * 1.609344;
                case "Mile per hour": return number;
                case "Knot": return number * 0.8689762419;
                default: return 0;
            }
        }

        public double Knot(string unit, double number)
        {
            switch (unit)
            {
                case "Foot per second": return number * 1.6878098571;
                case "Meter per second": return number * 0.5144444444;
                case "Kilometer per hour": return number * 1.852;
                case "Mile per hour": return number * 1.150779448;
                case "Knot": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Pressure
        /// 
        /// </summary>

        public double Bar(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number;
                case "Pascal": return number * 100000;
                case "Kilopascal": return number * 100;
                case "Pound per square inch": return number * 14.503773773;
                case "Kilopound per square inch": return number * 0.0145037738;
                case "Torr": return number * 750.0616827;
                case "Standard atmosphere": return number * 0.9869232667;
                default: return 0;
            }
        }

        public double Pascal(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 0.00001;
                case "Pascal": return number;
                case "Kilopascal": return number * 0.001;
                case "Pound per square inch": return number * 0.0001450377;
                case "Kilopound per square inch": return number * 1.450377377E-7;
                case "Torr": return number * 0.0075006168;
                case "Standard atmosphere": return number * 0.0000098692;
                default: return 0;
            }
        }

        public double Kilopascal(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 0.01;
                case "Pascal": return number * 1000;
                case "Kilopascal": return number;
                case "Pound per square inch": return number * 0.1450377377;
                case "Kilopound per square inch": return number * 0.0001450377;
                case "Torr": return number * 7.500616827;
                case "Standard atmosphere": return number * 0.0098692327;
                default: return 0;
            }
        }

        public double Poundpersquareinch(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 0.0689475729;
                case "Pascal": return number * 6894.7572932;
                case "Kilopascal": return number * 6.8947572932;
                case "Pound per square inch": return number;
                case "Kilopound per square inch": return number * 0.001;
                case "Torr": return number * 51.714932572;
                case "Standard atmosphere": return number * 0.0680459639;
                default: return 0;
            }
        }

        public double Kilopoundpersquareinch(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 68.947572932;
                case "Pascal": return number * 6894757.2932;
                case "Kilopascal": return number * 6894.7572932;
                case "Pound per square inch": return number * 1000;
                case "Kilopound per square inch": return number;
                case "Torr": return number * 51714.932572;
                case "Standard atmosphere": return number * 68.04596391;
                default: return 0;
            }
        }

        public double Torr(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 0.0013332237;
                case "Pascal": return number * 133.32236842;
                case "Kilopascal": return number * 0.1333223684;
                case "Pound per square inch": return number * 0.0193367747;
                case "Kilopound per square inch": return number * 0.0000193368;
                case "Torr": return number;
                case "Standard atmosphere": return number * 0.0013157895;
                default: return 0;
            }
        }

        public double Standardatmosphere(string unit, double number)
        {
            switch (unit)
            {
                case "Bar": return number * 1.01325;
                case "Pascal": return number * 101325;
                case "Kilopascal": return number * 101.325;
                case "Pound per square inch": return number * 14.695948775;
                case "Kilopound per square inch": return number * 0.0146959488;
                case "Torr": return number * 760;
                case "Standard atmosphere": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Energy
        /// 
        /// </summary>

        public double Joules(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number;
                case "Kilojoules": return number * 0.001;
                case "Calories": return number * 0.2390057361;
                case "Kilocalories": return number * 0.0002390057;
                case "Watt-hour": return number * 0.0002777778;
                case "Kilowatt-hour": return number * 2.777777777E-7;
                case "Foot-pound": return number * 0.7375621493;
                case "British thermal units (IT)": return number * 0.0009478171;
                case "Therms (EC)": return number * 9.478169879E-9;
                default: return 0;
            }
        }

        public double Kilojoules(string unit, double number) //Not done. unsure about btbu's if they are th or it
        {
            switch (unit)
            {
                case "Joules": return number * 1000;
                case "Kilojoules": return number;
                case "Calories": return number * 239.00573614;
                case "Kilocalories": return number * 0.2390057361;
                case "Watt-hour": return number * 0.2777777778;
                case "Kilowatt-hour": return number * 0.0002777778;
                case "Foot-pound": return number * 737.5621493;
                case "British thermal units (IT)": return number * 0.9478171203;
                case "Therms (EC)": return number * 0.0000094782;
                default: return 0;
            }
        }

        public double Calories(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 4.1868;
                case "Kilojoules": return number * 0.0041868;
                case "Calories": return number;
                case "Kilocalories": return number * 0.001;
                case "Watt-hour": return number * 0.001163;
                case "Kilowatt-hour": return number * 0.000001163;
                case "Foot-pound": return number * 3.0880252067;
                case "British thermal units (IT)": return number * 0.0039683207;
                case "Therms (EC)": return number * 3.968320164E-8;
                default: return 0;
            }
        }

        public double Kilocalories(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 4186.8;
                case "Kilojoules": return number * 4.1868;
                case "Calories": return number * 1000;
                case "Kilocalories": return number;
                case "Watt-hour": return number * 1.163;
                case "Kilowatt-hour": return number * 0.001163;
                case "Foot-pound": return number * 3088.0252067;
                case "British thermal units (IT)": return number * 3.9683207193;
                case "Therms (EC)": return number * 0.0000396832;
                default: return 0;
            }
        }

        public double Watthour(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 3600;
                case "Kilojoules": return number * 3.6;
                case "Calories": return number * 859.84522786;
                case "Kilocalories": return number * 0.8598452279;
                case "Watt-hour": return number;
                case "Kilowatt-hour": return number * 0.001;
                case "Foot-pound": return number * 2655.2237375;
                case "British thermal units (IT)": return number * 3.4121416331;
                case "Therms (EC)": return number * 0.0000341214;
                default: return 0;
            }
        }

        public double KilowattHour(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 3600000;
                case "Kilojoules": return number * 3600;
                case "Calories": return number * 859845.22786;
                case "Kilocalories": return number * 859.84522786;
                case "Watt-hour": return number * 1000;
                case "Kilowatt-hour": return number;
                case "Foot-pound": return number * 2655223.7375;
                case "British thermal units (IT)": return number * 3412.1416331;
                case "Therms (EC)": return number * 0.0341214116;
                default: return 0;
            }
        }

        public double Footpound(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 1.3558179483;
                case "Kilojoules": return number * 0.0013558179;
                case "Calories": return number * 0.3238315535;
                case "Kilocalories": return number * 0.0003238316;
                case "Watt-hour": return number * 0.0003766161;
                case "Kilowatt-hour": return number * 3.766160967E-7;
                case "Foot-pound": return number;
                case "British thermal units (IT)": return number * 0.0012850675;
                case "Therms (EC)": return number * 1.285067283E-8;
                default: return 0;
            }
        }

        public double BritishthermalunitsIT(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 1055.0558526;
                case "Kilojoules": return number * 1.0550558526;
                case "Calories": return number * 251.99576111;
                case "Kilocalories": return number * 0.2519957611;
                case "Watt-hour": return number * 0.2930710702;
                case "Kilowatt-hour": return number * 0.0002930711;
                case "Foot-pound": return number * 778.16926229;
                case "British thermal units (IT)": return number;
                case "Therms (EC)": return number * 0.00001;
                default: return 0;
            }
        }

        public double ThermsEC(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 105505600;
                case "Kilojoules": return number * 105505.6;
                case "Calories": return number * 25199579.631;
                case "Kilocalories": return number * 25199.579631;
                case "Watt-hour": return number * 29307.111111;
                case "Kilowatt-hour": return number * 29.307111111;
                case "Foot-pound": return number * 77816937.099;
                case "British thermal units (IT)": return number * 100000.01397;
                case "Therms (EC)": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Time
        /// 
        /// </summary>

        public double Nanosecond(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number;
                case "Microsecond": return number * 0.001;
                case "Millisecond": return number * 0.000001;
                case "Second": return number * 1e-9;
                case "Minute": return number * 1.6667e-11;
                case "Hour": return number * 2.77783333e-13;
                case "Day": return number * 1.1574305541667e-14;
                case "Week": return number * 1.6534722202381e-15;
                case "Month": return number * 3.8052469668526e-16;
                case "Year": return number * 3.1710426141553e-17;
                case "Decade": return number * 3.1710426141553e-18;
                case "Century": return number * 3.1710426141553e-19;
                case "Millennium": return number * 3.168808781e-20;
                default: return 0;
            }
        }

        public double Microsecond(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 1000;
                case "Microsecond": return number;
                case "Millisecond": return number * 0.001;
                case "Second": return number * 1e-6;
                case "Minute": return number * 1.666666666E-8;
                case "Hour": return number * 2.777777777E-10;
                case "Day": return number * 1.157407407E-11;
                case "Week": return number * 1.653439153E-12;
                case "Month": return number * 3.805175038E-13;
                case "Year": return number * 3.168808781E-14;
                case "Decade": return number * 3.168808781E-15;
                case "Century": return number * 3.168808781E-16;
                case "Millennium": return number * 3.168808781E-17;
                default: return 0;
            }
        }

        public double Millisecond(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 1000000;
                case "Microsecond": return number * 1000;
                case "Millisecond": return number;
                case "Second": return number * 0.001;
                case "Minute": return number * 0.0000166667;
                case "Hour": return number * 2.777777777E-7;
                case "Day": return number * 1.157407407E-8;
                case "Week": return number * 1.653439153E-9;
                case "Month": return number * 3.805175038E-10;
                case "Year": return number * 3.168808781E-11;
                case "Decade": return number * 3.168808781E-12;
                case "Century": return number * 3.168808781E-13;
                case "Millennium": return number * 3.168808781E-14;
                default: return 0;
            }
        }

        public double Second(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 1000000000;
                case "Microsecond": return number * 1000000;
                case "Millisecond": return number * 1000;
                case "Second": return number;
                case "Minute": return number * 0.0166666667;
                case "Hour": return number * 0.0002777778;
                case "Day": return number * 0.0000115741;
                case "Week": return number * 0.0000016534;
                case "Month": return number * 3.805175038E-7;
                case "Year": return number * 3.168808781E-8;
                case "Decade": return number * 3.168808781E-9;
                case "Century": return number * 3.168808781E-10;
                case "Millennium": return number * 3.168808781E-11;
                default: return 0;
            }
        }

        public double Minute(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 60000000000;
                case "Microsecond": return number * 60000000;
                case "Millisecond": return number * 60000;
                case "Second": return number * 60;
                case "Minute": return number;
                case "Hour": return number * 0.0166666667;
                case "Day": return number * 0.0006944444;
                case "Week": return number * 0.0000992063;
                case "Month": return number * 0.0000228311;
                case "Year": return number * 0.0000019013;
                case "Decade": return number * 1.901285268E-7;
                case "Century": return number * 1.901285268E-8;
                case "Millennium": return number * 1.901285268E-9;
                default: return 0;
            }
        }

        public double Hour(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 3600000000000;
                case "Microsecond": return number * 3600000000;
                case "Millisecond": return number * 3600000;
                case "Second": return number * 3600;
                case "Minute": return number * 60;
                case "Hour": return number;
                case "Day": return number * 0.0416666667;
                case "Week": return number * 0.005952381;
                case "Month": return number * 0.001369863;
                case "Year": return number * 0.0001140771;
                case "Decade": return number * 0.0000114077;
                case "Century": return number * 0.0000011408;
                case "Millennium": return number * 1.140771161E-7;
                default: return 0;
            }
        }

        public double Day(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 86400000000000;
                case "Microsecond": return number * 86400000000;
                case "Millisecond": return number * 86400000;
                case "Second": return number * 86400;
                case "Minute": return number * 1440;
                case "Hour": return number * 24;
                case "Day": return number;
                case "Week": return number * 0.1428571429;
                case "Month": return number * 0.0328767123;
                case "Year": return number * 0.0027378508;
                case "Decade": return number * 0.0002737851;
                case "Century": return number * 0.0000273785;
                case "Millennium": return number * 0.0000027379;
                default: return 0;
            }
        }

        public double Week(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 604800000000002;
                case "Microsecond": return number * 604800000000;
                case "Millisecond": return number * 604800000;
                case "Second": return number * 604800;
                case "Minute": return number * 10080;
                case "Hour": return number * 168;
                case "Day": return number * 7;
                case "Week": return number;
                case "Month": return number * 0.2301369863;
                case "Year": return number * 0.0191649555;
                case "Decade": return number * 0.0019164956;
                case "Century": return number * 0.0001916496;
                case "Millennium": return number * 0.000019165;
                default: return 0;
            }
        }

        public double Month(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 2628000000000000;
                case "Microsecond": return number * 2628000000000;
                case "Millisecond": return number * 2628000000;
                case "Second": return number * 2628000;
                case "Minute": return number * 43800;
                case "Hour": return number * 730;
                case "Day": return number * 30.416666667;
                case "Week": return number * 4.3452380952;
                case "Month": return number;
                case "Year": return number * 0.0832762948;
                case "Decade": return number * 0.0083276295;
                case "Century": return number * 0.0008327629;
                case "Millennium": return number * 0.0000832763;
                default: return 0;
            }
        }

        public double Year(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 31557599999999904;
                case "Microsecond": return number * 31557600000000;
                case "Millisecond": return number * 31557600000;
                case "Second": return number * 31557600;
                case "Minute": return number * 525960;
                case "Hour": return number * 8766;
                case "Day": return number * 365.25;
                case "Week": return number * 52.178571429;
                case "Month": return number * 12.008219178;
                case "Year": return number;
                case "Decade": return number * 0.1;
                case "Century": return number * 0.01;
                case "Millennium": return number * 0.001;
                default: return 0;
            }
        }
        public double Decade(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 315575999999999040;
                case "Microsecond": return number * 315575999999999;
                case "Millisecond": return number * 315576000000;
                case "Second": return number * 315576000;
                case "Minute": return number * 5259600;
                case "Hour": return number * 8766;
                case "Day": return number * 3652.5;
                case "Week": return number * 521.78571429;
                case "Month": return number * 120.08219178;
                case "Year": return number * 10;
                case "Decade": return number;
                case "Century": return number * 0.1;
                case "Millennium": return number * 0.01;
                default: return 0;
            }
        }

        public double Century(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 3155759999999990300;
                case "Microsecond": return number * 3155759999999991;
                case "Millisecond": return number * 3155760000000;
                case "Second": return number * 3155760000;
                case "Minute": return number * 52596000;
                case "Hour": return number * 876600;
                case "Day": return number * 36525;
                case "Week": return number * 5217.8571429;
                case "Month": return number * 1200.8219178;
                case "Year": return number * 100;
                case "Decade": return number * 10;
                case "Century": return number;
                case "Millennium": return number * 0.1;
                default: return 0;
            }
        }

        public double Millennium(string unit, double number)
        {
            switch (unit)
            {
                case "Nanosecond": return number * 3.15575999999999e+19;
                case "Microsecond": return number * 31557599999999904;
                case "Millisecond": return number * 31557600000000;
                case "Second": return number * 31557600000;
                case "Minute": return number * 525960000;
                case "Hour": return number * 8766000;
                case "Day": return number * 365250;
                case "Week": return number * 52178.571429;
                case "Month": return number * 12008.219178;
                case "Year": return number * 1000;
                case "Decade": return number * 100;
                case "Century": return number * 10;
                case "Millennium": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Frequency
        /// 
        /// </summary>

        public double Hertz(string unit, double number)
        {
            switch (unit)
            {
                case "Hertz": return number;
                case "Kilohertz": return number * 0.001;
                case "Megahertz": return number * 1e-6;
                case "Gigahertz": return number * 1e-9;
                default: return 0;
            }
        }

        public double Kilohertz(string unit, double number)
        {
            switch (unit)
            {
                case "Hertz": return number * 1000;
                case "Kilohertz": return number;
                case "Megahertz": return number * 0.001;
                case "Gigahertz": return number * 1e-6;
                default: return 0;
            }
        }

        public double Megahertz(string unit, double number)
        {
            switch (unit)
            {
                case "Hertz": return number * 1e+6;
                case "Kilohertz": return number * 1000;
                case "Megahertz": return number;
                case "Gigahertz": return number * 0.001;
                default: return 0;
            }
        }

        public double Gigahertz(string unit, double number)
        {
            switch (unit)
            {
                case "Hertz": return number * 1e+9;
                case "Kilohertz": return number * 1e+6;
                case "Megahertz": return number * 1000;
                case "Gigahertz": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Temperature
        /// 
        /// </summary>

        public double Celsius(string unit, double number)
        {
            switch (unit)
            {
                case "Celsius": return number;
                case "Fahrenheit": return number * 33.8;
                case "Kelvin": return number * 274.15;
                default: return 0;
            }
        }

        public double Fahrenheit(string unit, double number)
        {
            switch (unit)
            {
                case "Celsius": return number * -17.222222222;
                case "Fahrenheit": return number;
                case "Kelvin": return number * 255.92777778;
                default: return 0;
            }
        }

        public double Kelvin(string unit, double number)
        {
            switch (unit)
            {
                case "Celsius": return number * -272.15;
                case "Fahrenheit": return number * -457.87;
                case "Kelvin": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Length
        /// 
        /// </summary>

        public double Nanometer(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number;
                case "Micrometer": return number * 0.001;
                case "Millimeter": return number * 1.0E-6;
                case "Centimeter": return number * 1.0E-7;
                case "Inch": return number * 3.937E-8;
                case "Foot": return number * 3.2808E-9;
                case "Yard": return number * 1.0936E-9;
                case "Meter": return number * 1.0E-9;
                case "Kilometer": return number * 1.0E-12;
                case "Mile": return number * 6.2137E-13;
                case "Nautical mile": return number * 5.3996e-13;
                default: return 0;
            }
        }

        public double Micrometer(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1000;
                case "Micrometer": return number;
                case "Millimeter": return number * 0.001;
                case "Centimeter": return number * 0.0001;
                case "Inch": return number * 3.937E-5;
                case "Foot": return number * 3.2808E-6;
                case "Yard": return number * 1.0936E-6;
                case "Meter": return number * 1.0E-6;
                case "Kilometer": return number * 1.0E-9;
                case "Mile": return number * 6.2137E-10;
                case "Nautical mile": return number * 5.3996e-10;
                default: return 0;
            }
        }

        public double Millimeter(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1000000;
                case "Micrometer": return number * 1000;
                case "Millimeter": return number;
                case "Centimeter": return number * 0.1;
                case "Inch": return number * 0.0393701;
                case "Foot": return number * 0.00328084;
                case "Yard": return number * 0.00109361;
                case "Meter": return number * 0.001;
                case "Kilometer": return number * 1e-6;
                case "Mile": return number * 6.2137e-7;
                case "Nautical mile": return number * 5.3996e-7;
                default: return 0;
            }
        }

        public double Centimeter(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 10000000;
                case "Micrometer": return number * 10000;
                case "Millimeter": return number * 10;
                case "Centimeter": return number;
                case "Inch": return number * 0.3937007874;
                case "Foot": return number * 0.0328084;
                case "Yard": return number * 0.010936133;
                case "Meter": return number * 0.01;
                case "Kilometer": return number * 0.00001;
                case "Mile": return number * 0.0000062137;
                case "Nautical mile": return number * 0.0000053996;
                default: return 0;
            }
        }

        public double Inch(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 25400000;
                case "Micrometer": return number * 25400;
                case "Millimeter": return number * 25.4;
                case "Centimeter": return number * 2.54;
                case "Inch": return number;
                case "Foot": return number * 0.0833333333;
                case "Yard": return number * 0.0277777778;
                case "Meter": return number * 0.0254;
                case "Kilometer": return number * 0.0000254;
                case "Mile": return number * 0.0000157828;
                case "Nautical mile": return number * 0.0000137149;
                default: return 0;
            }
        }

        public double Foot(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 304800000;
                case "Micrometer": return number * 304800;
                case "Millimeter": return number * 304.8;
                case "Centimeter": return number * 30.48;
                case "Inch": return number * 12;
                case "Foot": return number;
                case "Yard": return number * 0.3333333333;
                case "Meter": return number * 0.3048;
                case "Kilometer": return number * 0.0003048;
                case "Mile": return number * 0.0001893939;
                case "Nautical mile": return number * 0.0001645788;
                default: return 0;
            }
        }

        public double Yard(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 914400000;
                case "Micrometer": return number * 914400;
                case "Millimeter": return number * 914.4;
                case "Centimeter": return number * 91.44;
                case "Inch": return number * 36;
                case "Foot": return number * 3;
                case "Yard": return number;
                case "Meter": return number * 0.9144;
                case "Kilometer": return number * 0.0009144;
                case "Mile": return number * 0.0005681818;
                case "Nautical mile": return number * 0.0004937365;
                default: return 0;
            }
        }

        public double Meter(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1000000000;
                case "Micrometer": return number * 1000000;
                case "Millimeter": return number * 1000;
                case "Centimeter": return number * 100;
                case "Inch": return number * 39.37007874;
                case "Foot": return number * 3.280839895;
                case "Yard": return number * 1.0936132983;
                case "Meter": return number;
                case "Kilometer": return number * 0.001;
                case "Mile": return number * 0.0006213712;
                case "Nautical mile": return number * 0.0005399568;
                default: return 0;
            }
        }

        public double Kilometer(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1000000000000;
                case "Micrometer": return number * 1000000000;
                case "Millimeter": return number * 1000000;
                case "Centimeter": return number * 100000;
                case "Inch": return number * 39370.07874;
                case "Foot": return number * 3280.839895;
                case "Yard": return number * 1093.6132983;
                case "Meter": return number * 1000;
                case "Kilometer": return number;
                case "Mile": return number * 0.6213711922;
                case "Nautical mile": return number * 0.5399568035;
                default: return 0;
            }
        }

        public double Mile(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1609344000000;
                case "Micrometer": return number * 1609344000;
                case "Millimeter": return number * 1609344;
                case "Centimeter": return number * 160934.4;
                case "Inch": return number * 63360;
                case "Foot": return number * 5280;
                case "Yard": return number * 1760;
                case "Meter": return number * 1609.344;
                case "Kilometer": return number * 1.609344;
                case "Mile": return number;
                case "Nautical mile": return number * 0.8689762419;
                default: return 0;
            }
        }

        public double Nauticalmile(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometer": return number * 1852000000000;
                case "Micrometer": return number * 1852000000;
                case "Millimeter": return number * 1852000;
                case "Centimeter": return number * 185200;
                case "Inch": return number * 72913.385827;
                case "Foot": return number * 6076.1154856;
                case "Yard": return number * 2025.3718285;
                case "Meter": return number * 1852;
                case "Kilometer": return number * 1.852;
                case "Mile": return number * 1.150779448;
                case "Nautical mile": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Area
        /// 
        /// </summary>

        public double Squaremillimeter(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number;
                case "Square centimeter": return number * 0.01;
                case "Square inch": return number * .00155;
                case "Square foot": return number * 1.0764E-5;
                case "Square yard": return number * 1.196E-6;
                case "Square meter": return number * 1.0E-6;
                case "Acres": return number * 2.4711E-10;
                case "Hectares": return number * 1.0E-10;
                case "Square kilometer": return number * 1.0E-12;
                case "Square mile": return number * 3.861E-13;
                default: return 0;
            }
        }

        public double Squarecentimeter(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 100;
                case "Square centimeter": return number;
                case "Square inch": return number * .155;
                case "Square foot": return number * 0.001076;
                case "Square yard": return number * 0.00012;
                case "Square meter": return number * 0.0001;
                case "Acres": return number * 2.4711E-8;
                case "Hectares": return number * 1.0E-8;
                case "Square kilometer": return number * 1.0E-10;
                case "Square mile": return number * 3.861E-11;
                default: return 0;
            }
        }

        public double Squareinch(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 645.16;
                case "Square centimeter": return number * 6.4516;
                case "Square inch": return number;
                case "Square foot": return number * 0.006944;
                case "Square yard": return number * 0.000772;
                case "Square meter": return number * 0.000645;
                case "Acres": return number * 1.5942E-7;
                case "Hectares": return number * 6.4516E-8;
                case "Square kilometer": return number * 6.4516E-10;
                case "Square mile": return number * 2.491E-10;
                default: return 0;
            }
        }

        public double Squarefoot(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 92903.04;
                case "Square centimeter": return number * 929.0304;
                case "Square inch": return number * 144;
                case "Square foot": return number;
                case "Square yard": return number * 0.111111;
                case "Square meter": return number * 0.092903;
                case "Acres": return number * 2.2957E-5;
                case "Hectares": return number * 9.2903E-6;
                case "Square kilometer": return number * 9.2903E-8;
                case "Square mile": return number * 3.587E-8;
                default: return 0;
            }
        }

        public double Squareyard(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 836127.36;
                case "Square centimeter": return number * 8361.2736;
                case "Square inch": return number * 1296;
                case "Square foot": return number * 9;
                case "Square yard": return number;
                case "Square meter": return number * 0.836127;
                case "Acres": return number * 0.000207;
                case "Hectares": return number * 8.3613E-5;
                case "Square kilometer": return number * 8.3613E-7;
                case "Square mile": return number * 3.2283E-7;
                default: return 0;
            }
        }

        public double Squaremeter(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 1000000;
                case "Square centimeter": return number * 10000;
                case "Square inch": return number * 1550.0031;
                case "Square foot": return number * 10.76391;
                case "Square yard": return number * 1.19599;
                case "Square meter": return number;
                case "Acres": return number * 0.000247;
                case "Hectares": return number * 0.0001;
                case "Square kilometer": return number * 1.0E-6;
                case "Square mile": return number * 3.861E-7;
                default: return 0;
            }
        }

        public double Acres(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 4046856422.4;
                case "Square centimeter": return number * 40468564.224;
                case "Square inch": return number * 6272640;
                case "Square foot": return number * 43560;
                case "Square yard": return number * 4840;
                case "Square meter": return number * 4046.856422;
                case "Acres": return number;
                case "Hectares": return number * 0.404686;
                case "Square kilometer": return number * 0.004047;
                case "Square mile": return number * 0.001563;
                default: return 0;
            }
        }

        public double Hectares(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 10000000000;
                case "Square centimeter": return number * 100000000;
                case "Square inch": return number * 15500031.000062;
                case "Square foot": return number * 107639.104167;
                case "Square yard": return number * 107639.104167;
                case "Square meter": return number * 10000;
                case "Acres": return number * 2.471054;
                case "Hectares": return number;
                case "Square kilometer": return number * 0.01;
                case "Square mile": return number * 0.003861;
                default: return 0;
            }
        }

        public double Squarekilometer(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 1000000000000;
                case "Square centimeter": return number * 10000000000;
                case "Square inch": return number * 1550003100.0062;
                case "Square foot": return number * 10763910.41671;
                case "Square yard": return number * 1195990.046301;
                case "Square meter": return number * 1000000;
                case "Acres": return number * 247.105381;
                case "Hectares": return number * 100;
                case "Square kilometer": return number;
                case "Square mile": return number * 0.386102;
                default: return 0;
            }
        }

        public double Squaremile(string unit, double number)
        {
            switch (unit)
            {
                case "Square millimeter": return number * 2589988110336;
                case "Square centimeter": return number * 25899881103.36;
                case "Square inch": return number * 4014489600;
                case "Square foot": return number * 27878400;
                case "Square yard": return number * 3097600;
                case "Square meter": return number * 2589988.110336;
                case "Acres": return number * 640;
                case "Hectares": return number * 258.998811;
                case "Square kilometer": return number * 2.589988;
                case "Square mile": return number;
                default: return 0;
            }
        }

    }
}
