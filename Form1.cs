using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Unit_Converter
{
    
    public partial class Form1 : Form
    {
        private ConversionMethods conversionMethods = new ConversionMethods();
        public Point mouseLocation;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        private string [] measurements = {"Area","Energy","Frequency","Length","Mass","Pressure","Speed","Temperature","Time","Volume"};
        
        private Dictionary<string, string[]> measurementDict = new Dictionary<string, string[]>
        {
            {"Area", new string[] {"Square millimeter", "Square centimeter", "Square inch", "Square foot", "Square yard", "Square meter", "Acre", "Hectare", "Square Kilometer", "Square mile" } },
            {"Energy", new string[] {"Joule", "Kilojoule", "Calorie", "Kilocalorie", "Watt-hour", "Kilowatt-hour","Foot-pound", "British thermal unit (IT)", "Therms (EC)" } },
            {"Frequency", new string[] {"Hertz", "Kilohertz", "Megahertz", "Gigahertz"} },
            {"Length", new string[] {"Nanometer", "Micrometer", "Millimeter", "Centimeter", "Inch", "Foot", "Yard", "Meter", "Kilometer", "Mile", "Nautical mile"} },
            {"Mass", new string[] {"Microgram", "Milligram", "Gram", "Ounce", "Pound", "Kilogram", "Stone (UK)", "US ton", "Imperial ton", "Metric ton"} },
            {"Pressure" ,new string[] {"Bar", "Pascal", "Kilopascal", "Pound per square inch", "Kilopound per square inch", "Torr", "Standard atmosphere"} },
            {"Speed", new string[] {"Foot per second", "Meter per second", "Kilometer per hour", "Mile per hour", "Knot" } },
            {"Temperature", new string[] {"Celsius", "Fahrenheit", "Kelvin"} },
            {"Time", new string[] {"Nanosecond", "Microsecond", "Millisecond", "Second", "Minute", "Hour", "Day", "Week", "Month", "Year", "Decade", "Century", "Millennium"} },
            {"Volume", new string[] {"US liquid gallon", "US liquid quart", "US liquid pint", "US cup", "US fluid ounce", "US tablespoon", "US teaspoon", "Cubic meter", "Liter", "Milliliter", "Imperial gallon", "Imperial quart", "Imperial pint", "Imperial cup", "Imperial fluid ounce", "Imperial tablespoon", "Imperial teaspoon", "Cubic Foot", "Cubic Inch"} }
        };

        string[] area = { "Square millimeter", "Square centimeter", "Square inch", "Square foot", "Square yard", "Square meter", "Acre", "Hectare", "Square Kilometer", "Square mile" };
        string[] energy = { "g" };

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            measurementComboBox.Items.AddRange(measurements);
            measurementComboBox.SelectedItem = "Area";
            resultUnit.Items.AddRange(area);
            convertUnit.Items.AddRange(area);
            convertUnit.SelectedItem = "Square foot";
            resultUnit.SelectedItem = "Square meter";
            this.ActiveControl = unitToConvert;

            notesBox.GotFocus += RemoveText; //https://stackoverflow.com/questions/11873378/adding-placeholder-text-to-textbox
            notesBox.LostFocus += AddText;

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
            

        }

        private void measurementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertUnit.Items.Clear();
            resultUnit.Items.Clear();

            string selectedIdx = measurementComboBox.SelectedItem.ToString();

            if (measurementDict.ContainsKey(selectedIdx))
            {
                convertUnit.Items.AddRange(measurementDict[selectedIdx]);
                convertUnit.Text = measurementDict[selectedIdx][0];
                resultUnit.Items.AddRange(measurementDict[selectedIdx]);
                resultUnit.Text = measurementDict[selectedIdx][1];

            }
        }

        

        private void unitToConvert_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("result unit: " + resultUnit.SelectedItem.ToString());
            if(unitToConvert.Text == string.Empty)
            {
                conversionResult.Text = "";
                return;
            }
            if (!double.TryParse(unitToConvert.Text, out double unitValue)) //try to convert string to double. if successful, create variable called unitValue that holds the double.
            {
                MessageBox.Show("not a double ");
                return;
            }


            Console.WriteLine("number: " + unitValue.GetType());
            Type type = typeof(ConversionMethods);
            //Console.WriteLine("type of conversionMethods: " + type);
            string methodName = modifyString(convertUnit.SelectedItem.ToString());
            //Console.WriteLine("name of method:  " + methodName);


            MethodInfo methodInfo = type.GetMethod(methodName);
            //Console.WriteLine("method info: "  + methodInfo);
            Object[] parameters = { resultUnit.SelectedItem.ToString(), unitValue };

            if (methodInfo != null) //if it can find the function name to match
            {
                object result = methodInfo.Invoke(conversionMethods, parameters); //call the function and apss in the parameters to it
                conversionResult.Text = Math.Round((double)result, 8).ToString();
            }
            else
            {
                MessageBox.Show("Method not found");
            }

        }

        private void resultUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("result unit: " + resultUnit.SelectedItem.ToString());
            if (!double.TryParse(unitToConvert.Text, out double unitValue)) //try to convert string to double. if successful, create variable called unitValue that holds the double.
            {
                //MessageBox.Show("not a double");
                return;
            }


            //Console.WriteLine("number: " + unitValue.GetType());
            Type type = typeof(ConversionMethods);
            //Console.WriteLine("type of conversionMethods: " + type);
            string methodName = modifyString(convertUnit.SelectedItem.ToString());

            MethodInfo methodInfo = type.GetMethod(methodName);
            Object[] parameters = { resultUnit.SelectedItem.ToString(), unitValue };

            if (methodInfo != null) //if it can find the function name to match
            {
                object result = methodInfo.Invoke(conversionMethods, parameters); //call the function and apss in the parameters to it
                conversionResult.Text = Math.Round((double)result, 8).ToString();
            }
            else
            {
                //MessageBox.Show("Method not found");
            }
        }

        private string modifyString(string str) //modified from: https://stackoverflow.com/questions/7411438/remove-characters-from-c-sharp-string
        {
            
            string fixedString = new string((from c in str
                              where char.IsLetter(c)
                              select c
                   ).ToArray());
            return fixedString;
        }

        private void switchUnits_Click(object sender, EventArgs e)
        {

        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (notesBox.Text == "Notes...")
            {
                notesBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(notesBox.Text))
                notesBox.Text = "Notes...";
        }
    }
}
