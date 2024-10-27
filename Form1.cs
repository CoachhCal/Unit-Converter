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
