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
                default:  return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
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
                default: return number;
            }
        }
    }
}
