using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Unit_Converter
{
    
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Console.WriteLine(squareMillimeters("Square Miles", 1));

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

        public double USTon(string unit, double number)
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

        public double ImperialTon(string unit, double number)
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

        public double MetricTon(string unit, double number)
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

        public double FeetPerSecond(string unit, double number)
        {
            switch (unit)
            {
                case "Feet per second": return number;
                case "Meters per second": return number * 0.3048;
                case "Kilometers per hour": return number * 1.09728;
                case "Miles per hour": return number * 0.6818181818;
                case "Knots": return number * 0.5924838013;
                default: return 0;
            }
        }

        public double MetersPerSecond(string unit, double number)
        {
            switch (unit)
            {
                case "Feet per second": return number * 3.280839895;
                case "Meters per second": return number;
                case "Kilometers per hour": return number * 3.6;
                case "Miles per hour": return number * 2.2369362921;
                case "Knots": return number * 1.9438444924;
                default: return 0;
            }
        }

        public double KilometersPerHour(string unit, double number)
        {
            switch (unit)
            {
                case "Feet per second": return number * 0.9113444153;
                case "Meters per second": return number * 0.2777777778;
                case "Kilometers per hour": return number;
                case "Miles per hour": return number * 0.6213711922;
                case "Knots": return number * 0.5399568035;
                default: return 0;
            }
        }

        public double MilesPerHour(string unit, double number)
        {
            switch (unit)
            {
                case "Feet per second": return number * 1.4666666667;
                case "Meters per second": return number * 0.44704;
                case "Kilometers per hour": return number * 1.609344;
                case "Miles per hour": return number;
                case "Knots": return number * 0.8689762419;
                default: return 0;
            }
        }

        public double Knots(string unit, double number)
        {
            switch (unit)
            {
                case "Feet per second": return number * 1.6878098571;
                case "Meters per second": return number * 0.5144444444;
                case "Kilometers per hour": return number * 1.852;
                case "Miles per hour": return number * 1.150779448;
                case "Knots": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Pressure
        /// 
        /// </summary>

        public double Bars(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number;
                case "Pascals": return number * 100000;
                case "Kilopascals": return number * 100;
                case "Pounds per square inch": return number * 14.503773773;
                case "Kilopounds per square inch": return number * 0.0145037738;
                case "Torr": return number * 750.0616827;
                case "Standard atmosphere": return number * 0.9869232667;
                default: return 0;
            }
        }

        public double Pascals(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 0.00001;
                case "Pascals": return number;
                case "Kilopascals": return number * 0.001;
                case "Pounds per square inch": return number * 0.0001450377;
                case "Kilopounds per square inch": return number * 1.450377377E-7;
                case "Torr": return number * 0.0075006168;
                case "Standard atmosphere": return number * 0.0000098692;
                default: return 0;
            }
        }

        public double Kilopascals(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 0.01;
                case "Pascals": return number * 1000;
                case "Kilopascals": return number;
                case "Pounds per square inch": return number * 0.1450377377;
                case "Kilopounds per square inch": return number * 0.0001450377;
                case "Torr": return number * 7.500616827;
                case "Standard atmosphere": return number * 0.0098692327;
                default: return 0;
            }
        }

        public double PoundsPerSquareInch(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 0.0689475729;
                case "Pascals": return number * 6894.7572932;
                case "Kilopascals": return number * 6.8947572932;
                case "Pounds per square inch": return number;
                case "Kilopounds per square inch": return number * 0.001;
                case "Torr": return number * 51.714932572;
                case "Standard atmosphere": return number * 0.0680459639;
                default: return 0;
            }
        }

        public double KilopoundsPerSquareInch(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 68.947572932;
                case "Pascals": return number * 6894757.2932;
                case "Kilopascals": return number * 6894.7572932;
                case "Pounds per square inch": return number * 1000;
                case "Kilopounds per square inch": return number;
                case "Torr": return number * 51714.932572;
                case "Standard atmosphere": return number * 68.04596391;
                default: return 0;
            }
        }

        public double Torr(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 0.0013332237;
                case "Pascals": return number * 133.32236842;
                case "Kilopascals": return number * 0.1333223684;
                case "Pounds per square inch": return number * 0.0193367747;
                case "Kilopounds per square inch": return number * 0.0000193368;
                case "Torr": return number;
                case "Standard atmosphere": return number * 0.0013157895;
                default: return 0;
            }
        }

        public double StandardAtmosphere(string unit, double number)
        {
            switch (unit)
            {
                case "Bars": return number * 1.01325;
                case "Pascals": return number * 101325;
                case "Kilopascals": return number * 101.325;
                case "Pounds per square inch": return number * 14.695948775;
                case "Kilopounds per square inch": return number * 0.0146959488;
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
                case "Watt-hours": return number * 0.0002777778;
                case "Kilowatt-hours": return number * 2.777777777E-7;
                case "Foot-pounds": return number * 0.7375621493;
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
                case "Watt-hours": return number * 0.2777777778;
                case "Kilowatt-hours": return number * 0.0002777778;
                case "Foot-pounds": return number * 737.5621493;
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
                case "Watt-hours": return number * 0.001163;
                case "Kilowatt-hours": return number * 0.000001163;
                case "Foot-pounds": return number * 3.0880252067;
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
                case "Watt-hours": return number * 1.163;
                case "Kilowatt-hours": return number * 0.001163;
                case "Foot-pounds": return number * 3088.0252067;
                case "British thermal units (IT)": return number * 3.9683207193;
                case "Therms (EC)": return number * 0.0000396832;
                default: return 0;
            }
        }

        public double WattHours(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 3600;
                case "Kilojoules": return number * 3.6;
                case "Calories": return number * 859.84522786;
                case "Kilocalories": return number * 0.8598452279;
                case "Watt-hours": return number;
                case "Kilowatt-hours": return number * 0.001;
                case "Foot-pounds": return number * 2655.2237375;
                case "British thermal units (IT)": return number * 3.4121416331;
                case "Therms (EC)": return number * 0.0000341214;
                default: return 0;
            }
        }

        public double KilowattHours(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 3600000;
                case "Kilojoules": return number * 3600;
                case "Calories": return number * 859845.22786;
                case "Kilocalories": return number * 859.84522786;
                case "Watt-hours": return number * 1000;
                case "Kilowatt-hours": return number;
                case "Foot-pounds": return number * 2655223.7375;
                case "British thermal units (IT)": return number * 3412.1416331;
                case "Therms (EC)": return number * 0.0341214116;
                default: return 0;
            }
        }

        public double FootPounds(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 1.3558179483;
                case "Kilojoules": return number * 0.0013558179;
                case "Calories": return number * 0.3238315535;
                case "Kilocalories": return number * 0.0003238316;
                case "Watt-hours": return number * 0.0003766161;
                case "Kilowatt-hours": return number * 3.766160967E-7;
                case "Foot-pounds": return number;
                case "British thermal units (IT)": return number * 0.0012850675;
                case "Therms (EC)": return number * 1.285067283E-8;
                default: return 0;
            }
        }

        public double BritishThermalUnitsIT(string unit, double number)
        {
            switch (unit)
            {
                case "Joules": return number * 1055.0558526;
                case "Kilojoules": return number * 1.0550558526;
                case "Calories": return number * 251.99576111;
                case "Kilocalories": return number * 0.2519957611;
                case "Watt-hours": return number * 0.2930710702;
                case "Kilowatt-hours": return number * 0.0002930711;
                case "Foot-pounds": return number * 778.16926229;
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
                case "Watt-hours": return number * 29307.111111;
                case "Kilowatt-hours": return number * 29.307111111;
                case "Foot-pounds": return number * 77816937.099;
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

        public double Nanoseconds(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number ;
                case "Microseconds": return number * 0.001;
                case "Milliseconds": return number * 0.000001;
                case "Seconds": return number * 1e-9;
                case "Minutes": return number * 1.6667e-11;
                case "Hours": return number * 2.77783333e-13;
                case "Days": return number * 1.1574305541667e-14;
                case "Weeks": return number * 1.6534722202381e-15;
                case "Months": return number * 3.8052469668526e-16;
                case "Years": return number * 3.1710426141553e-17;
                case "Decades": return number * 3.1710426141553e-18;
                case "Centuries": return number * 3.1710426141553e-19;
                case "Millennia": return number * 3.168808781e-20;
                default: return 0;
            }
        }

        public double Microseconds(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 1000;
                case "Microseconds": return number;
                case "Milliseconds": return number * 0.001;
                case "Seconds": return number * 1e-6;
                case "Minutes": return number * 1.666666666E-8;
                case "Hours": return number * 2.777777777E-10;
                case "Days": return number * 1.157407407E-11;
                case "Weeks": return number * 1.653439153E-12;
                case "Months": return number * 3.805175038E-13;
                case "Years": return number * 3.168808781E-14;
                case "Decades": return number * 3.168808781E-15;
                case "Centuries": return number * 3.168808781E-16;
                case "Millennia": return number * 3.168808781E-17;
                default: return 0;
            }
        }

        public double Milliseconds(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 1000000;
                case "Microseconds": return number * 1000;
                case "Milliseconds": return number;
                case "Seconds": return number * 0.001;
                case "Minutes": return number * 0.0000166667;
                case "Hours": return number * 2.777777777E-7;
                case "Days": return number * 1.157407407E-8;
                case "Weeks": return number * 1.653439153E-9;
                case "Months": return number * 3.805175038E-10;
                case "Years": return number * 3.168808781E-11;
                case "Decades": return number * 3.168808781E-12;
                case "Centuries": return number * 3.168808781E-13;
                case "Millennia": return number * 3.168808781E-14;
                default: return 0;
            }
        }

        public double Seconds(string unit, double number)
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
                case "Centuries": return number * 3.168808781E-10;
                case "Millennia": return number * 3.168808781E-11;
                default: return 0;
            }
        }

        public double Minutes(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 60000000000;
                case "Microseconds": return number * 60000000;
                case "Milliseconds": return number * 60000;
                case "Seconds": return number * 60;
                case "Minutes": return number;
                case "Hours": return number * 0.0166666667;
                case "Days": return number * 0.0006944444;
                case "Weeks": return number * 0.0000992063;
                case "Months": return number * 0.0000228311;
                case "Years": return number * 0.0000019013;
                case "Decades": return number * 1.901285268E-7;
                case "Centuries": return number * 1.901285268E-8;
                case "Millennia": return number * 1.901285268E-9;
                default: return 0;
            }
        }

        public double Hours(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 3600000000000;
                case "Microseconds": return number * 3600000000;
                case "Milliseconds": return number * 3600000;
                case "Seconds": return number * 3600;
                case "Minutes": return number * 60;
                case "Hours": return number;
                case "Days": return number * 0.0416666667;
                case "Weeks": return number * 0.005952381;
                case "Months": return number * 0.001369863;
                case "Years": return number * 0.0001140771;
                case "Decades": return number * 0.0000114077;
                case "Centuries": return number * 0.0000011408;
                case "Millennia": return number * 1.140771161E-7;
                default: return 0;
            }
        }

        public double Days(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 86400000000000;
                case "Microseconds": return number * 86400000000;
                case "Milliseconds": return number * 86400000;
                case "Seconds": return number * 86400;
                case "Minutes": return number * 1440;
                case "Hours": return number * 24;
                case "Days": return number;
                case "Weeks": return number * 0.1428571429;
                case "Months": return number * 0.0328767123;
                case "Years": return number * 0.0027378508;
                case "Decades": return number * 0.0002737851;
                case "Centuries": return number * 0.0000273785;
                case "Millennia": return number * 0.0000027379;
                default: return 0;
            }
        }

        public double Weeks(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 604800000000002;
                case "Microseconds": return number * 604800000000;
                case "Milliseconds": return number * 604800000;
                case "Seconds": return number * 604800;
                case "Minutes": return number * 10080;
                case "Hours": return number * 168;
                case "Days": return number * 7;
                case "Weeks": return number;
                case "Months": return number * 0.2301369863;
                case "Years": return number * 0.0191649555;
                case "Decades": return number * 0.0019164956;
                case "Centuries": return number * 0.0001916496;
                case "Millennia": return number * 0.000019165;
                default: return 0;
            }
        }

        public double Months(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 2628000000000000;
                case "Microseconds": return number * 2628000000000;
                case "Milliseconds": return number * 2628000000;
                case "Seconds": return number * 2628000;
                case "Minutes": return number * 43800;
                case "Hours": return number * 730;
                case "Days": return number * 30.416666667;
                case "Weeks": return number * 4.3452380952;
                case "Months": return number;
                case "Years": return number * 0.0832762948;
                case "Decades": return number * 0.0083276295;
                case "Centuries": return number * 0.0008327629;
                case "Millennia": return number * 0.0000832763;
                default: return 0;
            }
        }

        public double Years(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 31557599999999904;
                case "Microseconds": return number * 31557600000000;
                case "Milliseconds": return number * 31557600000;
                case "Seconds": return number * 31557600;
                case "Minutes": return number * 525960;
                case "Hours": return number * 8766;
                case "Days": return number * 365.25;
                case "Weeks": return number * 52.178571429;
                case "Months": return number * 12.008219178;
                case "Years": return number;
                case "Decades": return number * 0.1;
                case "Centuries": return number * 0.01;
                case "Millennia": return number * 0.001;
                default: return 0;
            }
        }
        public double Decades(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 315575999999999040;
                case "Microseconds": return number * 315575999999999;
                case "Milliseconds": return number * 315576000000;
                case "Seconds": return number * 315576000;
                case "Minutes": return number * 5259600;
                case "Hours": return number * 8766;
                case "Days": return number * 3652.5;
                case "Weeks": return number * 521.78571429;
                case "Months": return number * 120.08219178;
                case "Years": return number * 10;
                case "Decades": return number;
                case "Centuries": return number * 0.1;
                case "Millennia": return number * 0.01;
                default: return 0;
            }
        }

        public double Centuries(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 3155759999999990300;
                case "Microseconds": return number * 3155759999999991;
                case "Milliseconds": return number * 3155760000000;
                case "Seconds": return number * 3155760000;
                case "Minutes": return number * 52596000;
                case "Hours": return number * 876600;
                case "Days": return number * 36525;
                case "Weeks": return number * 5217.8571429;
                case "Months": return number * 1200.8219178;
                case "Years": return number * 100;
                case "Decades": return number * 10;
                case "Centuries": return number;
                case "Millennia": return number * 0.1;
                default: return 0;
            }
        }

        public double Millennia(string unit, double number)
        {
            switch (unit)
            {
                case "Nanoseconds": return number * 3.15575999999999e+19;
                case "Microseconds": return number * 31557599999999904;
                case "Milliseconds": return number * 31557600000000;
                case "Seconds": return number * 31557600000;
                case "Minutes": return number * 525960000;
                case "Hours": return number * 8766000;
                case "Days": return number * 365250;
                case "Weeks": return number * 52178.571429;
                case "Months": return number * 12008.219178;
                case "Years": return number * 1000;
                case "Decades": return number * 100;
                case "Centuries": return number * 10;
                case "Millennia": return number;
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

        public double Nanometers(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number;
                case "Micrometers": return number * 0.001;
                case "Millimeters": return number * 1.0E-6;
                case "Centimeters": return number * 1.0E-7;
                case "Inches": return number * 3.937E-8;
                case "Feet": return number * 3.2808E-9;
                case "Yards": return number * 1.0936E-9;
                case "Meters": return number * 1.0E-9;
                case "Kilometers": return number * 1.0E-12;
                case "Miles": return number * 6.2137E-13;
                case "Nautical Miles": return number * 5.3996e-13;
                default: return 0;
            }
        }

        public double Micrometers(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1000;
                case "Micrometers": return number;
                case "Millimeters": return number * 0.001;
                case "Centimeters": return number * 0.0001;
                case "Inches": return number * 3.937E-5;
                case "Feet": return number * 3.2808E-6;
                case "Yards": return number * 1.0936E-6;
                case "Meters": return number * 1.0E-6;
                case "Kilometers": return number * 1.0E-9;
                case "Miles": return number * 6.2137E-10;
                case "Nautical Miles": return number * 5.3996e-10;
                default: return 0;
            }
        }

        public double Millimeters(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1000000;
                case "Micrometers": return number * 1000;
                case "Millimeters": return number;
                case "Centimeters": return number * 0.1;
                case "Inches": return number * 0.0393701;
                case "Feet": return number * 0.00328084;
                case "Yards": return number * 0.00109361;
                case "Meters": return number * 0.001;
                case "Kilometers": return number * 1e-6;
                case "Miles": return number * 6.2137e-7;
                case "Nautical Miles": return number * 5.3996e-7;
                default: return 0;
            }
        }

        public double Centimeters(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 10000000;
                case "Micrometers": return number * 10000;
                case "Millimeters": return number * 10;
                case "Centimeters": return number;
                case "Inches": return number * 0.3937007874;
                case "Feet": return number * 0.0328084;
                case "Yards": return number * 0.010936133;
                case "Meters": return number * 0.01;
                case "Kilometers": return number * 0.00001;
                case "Miles": return number * 0.0000062137;
                case "Nautical Miles": return number * 0.0000053996;
                default: return 0;
            }
        }

        public double Inches(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 25400000;
                case "Micrometers": return number * 25400;
                case "Millimeters": return number * 25.4;
                case "Centimeters": return number * 2.54;
                case "Inches": return number;
                case "Feet": return number * 0.0833333333;
                case "Yards": return number * 0.0277777778;
                case "Meters": return number * 0.0254;
                case "Kilometers": return number * 0.0000254;
                case "Miles": return number * 0.0000157828;
                case "Nautical Miles": return number * 0.0000137149;
                default: return 0;
            }
        }

        public double Feet(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 304800000;
                case "Micrometers": return number * 304800;
                case "Millimeters": return number * 304.8;
                case "Centimeters": return number * 30.48;
                case "Inches": return number * 12;
                case "Feet": return number;
                case "Yards": return number * 0.3333333333;
                case "Meters": return number * 0.3048;
                case "Kilometers": return number * 0.0003048;
                case "Miles": return number * 0.0001893939;
                case "Nautical Miles": return number * 0.0001645788;
                default: return 0;
            }
        }

        public double Yards(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 914400000;
                case "Micrometers": return number * 914400;
                case "Millimeters": return number * 914.4;
                case "Centimeters": return number * 91.44;
                case "Inches": return number * 36;
                case "Feet": return number * 3;
                case "Yards": return number;
                case "Meters": return number * 0.9144;
                case "Kilometers": return number * 0.0009144;
                case "Miles": return number * 0.0005681818;
                case "Nautical Miles": return number * 0.0004937365;
                default: return 0;
            }
        }

        public double Meters(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1000000000;
                case "Micrometers": return number * 1000000;
                case "Millimeters": return number * 1000;
                case "Centimeters": return number * 100;
                case "Inches": return number * 39.37007874;
                case "Feet": return number * 3.280839895;
                case "Yards": return number * 1.0936132983;
                case "Meters": return number;
                case "Kilometers": return number * 0.001;
                case "Miles": return number * 0.0006213712;
                case "Nautical Miles": return number * 0.0005399568;
                default: return 0;
            }
        }

        public double Kilometers(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1000000000000;
                case "Micrometers": return number * 1000000000;
                case "Millimeters": return number * 1000000;
                case "Centimeters": return number * 100000;
                case "Inches": return number * 39370.07874;
                case "Feet": return number * 3280.839895;
                case "Yards": return number * 1093.6132983;
                case "Meters": return number * 1000;
                case "Kilometers": return number;
                case "Miles": return number * 0.6213711922;
                case "Nautical Miles": return number * 0.5399568035;
                default: return 0;
            }
        }

        public double Miles(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1609344000000;
                case "Micrometers": return number * 1609344000;
                case "Millimeters": return number * 1609344;
                case "Centimeters": return number * 160934.4;
                case "Inches": return number * 63360;
                case "Feet": return number * 5280;
                case "Yards": return number * 1760;
                case "Meters": return number * 1609.344;
                case "Kilometers": return number * 1.609344;
                case "Miles": return number;
                case "Nautical Miles": return number * 0.8689762419;
                default: return 0;
            }
        }

        public double NauticalMiles(string unit, double number)
        {
            switch (unit)
            {
                case "Nanometers": return number * 1852000000000;
                case "Micrometers": return number * 1852000000;
                case "Millimeters": return number * 1852000;
                case "Centimeters": return number * 185200;
                case "Inches": return number * 72913.385827;
                case "Feet": return number * 6076.1154856;
                case "Yards": return number * 2025.3718285;
                case "Meters": return number * 1852;
                case "Kilometers": return number * 1.852;
                case "Miles": return number * 1.150779448;
                case "Nautical Miles": return number;
                default: return 0;
            }
        }

        /// <summary>
        /// 
        /// Area
        /// 
        /// </summary>

        public double squareMillimeters(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters":return number;
                case "Square Centimeters": return number * 0.01;
                case "Square Inches": return number * .00155;
                case "Square Feet": return number * 1.0764E-5;
                case "Square Yards": return number * 1.196E-6;
                case "Square Meters": return number * 1.0E-6;
                case "Acres": return number * 2.4711E-10;
                case "Hectares": return number * 1.0E-10;
                case "Square Kilometers": return number * 1.0E-12;
                case "Square Miles": return number * 3.861E-13;
                default:  return 0;
            }
        }

        public double squareCentimeters(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 100;
                case "Square Centimeters": return number;
                case "Square Inches": return number * .155;
                case "Square Feet": return number * 0.001076;
                case "Square Yards": return number * 0.00012;
                case "Square Meters": return number * 0.0001;
                case "Acres": return number * 2.4711E-8;
                case "Hectares": return number * 1.0E-8;
                case "Square Kilometers": return number * 1.0E-10;
                case "Square Miles": return number * 3.861E-11;
                default: return 0;
            }
        }

        public double squareInches(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 645.16;
                case "Square Centimeters": return number * 6.4516;
                case "Square Inches": return number;
                case "Square Feet": return number * 0.006944;
                case "Square Yards": return number * 0.000772;
                case "Square Meters": return number * 0.000645;
                case "Acres": return number * 1.5942E-7;
                case "Hectares": return number * 6.4516E-8;
                case "Square Kilometers": return number * 6.4516E-10;
                case "Square Miles": return number * 2.491E-10;
                default: return 0;
            }
        }

        public double squareFeet(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 92903.04;
                case "Square Centimeters": return number * 929.0304;
                case "Square Inches": return number * 144;
                case "Square Feet": return number;
                case "Square Yards": return number * 0.111111;
                case "Square Meters": return number * 0.092903;
                case "Acres": return number * 2.2957E-5;
                case "Hectares": return number * 9.2903E-6;
                case "Square Kilometers": return number * 9.2903E-8;
                case "Square Miles": return number * 3.587E-8;
                default: return 0;
            }
        }

        public double squareYards(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 836127.36;
                case "Square Centimeters": return number * 8361.2736;
                case "Square Inches": return number * 1296;
                case "Square Feet": return number * 9;
                case "Square Yards": return number;
                case "Square Meters": return number * 0.836127;
                case "Acres": return number * 0.000207;
                case "Hectares": return number * 8.3613E-5;
                case "Square Kilometers": return number * 8.3613E-7;
                case "Square Miles": return number * 3.2283E-7;
                default: return 0;
            }
        }

        public double squareMeters(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 1000000;
                case "Square Centimeters": return number * 10000;
                case "Square Inches": return number * 1550.0031;
                case "Square Feet": return number * 10.76391;
                case "Square Yards": return number * 1.19599;
                case "Square Meters": return number;
                case "Acres": return number * 0.000247;
                case "Hectares": return number * 0.0001;
                case "Square Kilometers": return number * 1.0E-6;
                case "Square Miles": return number * 3.861E-7;
                default: return 0;
            }
        }

        public double acres(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 4046856422.4;
                case "Square Centimeters": return number * 40468564.224;
                case "Square Inches": return number * 6272640;
                case "Square Feet": return number * 43560;
                case "Square Yards": return number * 4840;
                case "Square Meters": return number * 4046.856422;
                case "Acres": return number;
                case "Hectares": return number * 0.404686;
                case "Square Kilometers": return number * 0.004047;
                case "Square Miles": return number * 0.001563;
                default: return 0;
            }
        }

        public double hectares(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 10000000000;
                case "Square Centimeters": return number * 100000000;
                case "Square Inches": return number * 15500031.000062;
                case "Square Feet": return number * 107639.104167;
                case "Square Yards": return number * 107639.104167;
                case "Square Meters": return number * 10000;
                case "Acres": return number * 2.471054;
                case "Hectares": return number;
                case "Square Kilometers": return number * 0.01;
                case "Square Miles": return number * 0.003861;
                default: return 0;
            }
        }

        public double squareKilometers(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 1000000000000;
                case "Square Centimeters": return number * 10000000000;
                case "Square Inches": return number * 1550003100.0062;
                case "Square Feet": return number * 10763910.41671;
                case "Square Yards": return number * 1195990.046301;
                case "Square Meters": return number * 1000000;
                case "Acres": return number * 247.105381;
                case "Hectares": return number * 100;
                case "Square Kilometers": return number;
                case "Square Miles": return number * 0.386102;
                default: return 0;
            }
        }

        public double squareMiles(string unit, double number)
        {
            switch (unit)
            {
                case "Square Millimeters": return number * 2589988110336;
                case "Square Centimeters": return number * 25899881103.36;
                case "Square Inches": return number * 4014489600;
                case "Square Feet": return number * 27878400;
                case "Square Yards": return number * 3097600;
                case "Square Meters": return number * 2589988.110336;
                case "Acres": return number * 640;
                case "Hectares": return number * 258.998811;
                case "Square Kilometers": return number * 2.589988;
                case "Square Miles": return number;
                default: return 0;
            }
        }
    }
}
