using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


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
            {"Area", new string[] {"Square millimeter", "Square centimeter", "Square inch", "Square foot", "Square yard", "Square meter", "Acre", "Hectare", "Square kilometer", "Square mile" } },
            {"Energy", new string[] {"Joule", "Kilojoule", "Calorie", "Kilocalorie", "Watt-hour", "Kilowatt-hour","Foot-pound", "British thermal unit (IT)", "Therm (EC)" } },
            {"Frequency", new string[] {"Hertz", "Kilohertz", "Megahertz", "Gigahertz"} },
            {"Length", new string[] {"Nanometer", "Micrometer", "Millimeter", "Centimeter", "Inch", "Foot", "Yard", "Meter", "Kilometer", "Mile", "Nautical mile"} },
            {"Mass", new string[] {"Microgram", "Milligram", "Gram", "Ounce", "Pound", "Kilogram", "Stone (UK)", "US ton", "Imperial ton", "Metric ton"} },
            {"Pressure" ,new string[] {"Bar", "Pascal", "Kilopascal", "Pound per square inch", "Kilopound per square inch", "Torr", "Standard atmosphere"} },
            {"Speed", new string[] {"Foot per second", "Meter per second", "Kilometer per hour", "Mile per hour", "Knot" } },
            {"Temperature", new string[] {"Celsius", "Fahrenheit", "Kelvin"} },
            {"Time", new string[] {"Nanosecond", "Microsecond", "Millisecond", "Second", "Minute", "Hour", "Day", "Week", "Month", "Calendar year", "Decade", "Century", "Millennium"} },
            {"Volume", new string[] {"US liquid gallon", "US liquid quart", "US liquid pint", "US cup", "US fluid ounce", "US tablespoon", "US teaspoon", "Cubic meter", "Liter", "Milliliter", "Imperial gallon", "Imperial quart", "Imperial pint", "Imperial cup", "Imperial fluid ounce", "Imperial tablespoon", "Imperial teaspoon", "Cubic foot", "Cubic inch"} }
        };

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            measurementComboBox.Items.AddRange(measurements); //adds all the physical quantities to the combobox
            measurementComboBox.SelectedItem = "Area"; //default physical quantity
            
            convertUnit.SelectedItem = "Square foot"; //default units of measurements
            resultUnit.SelectedItem = "Square meter";
            this.ActiveControl = unitToConvert;

            notesBox.GotFocus += RemoveText; //modifies the text displayed in the large textbox "Notes": https://stackoverflow.com/questions/11873378/adding-placeholder-text-to-textbox
            notesBox.LostFocus += AddText;

        }

        //for the custom exit, minimize, maximize, and moving/resizing the form: https://stackoverflow.com/questions/29024910/how-to-design-a-custom-close-minimize-and-maximize-button-in-windows-form-appli

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
        } //exit button

        private void button2_Click(object sender, EventArgs e) //maximize button
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

        private void button1_Click(object sender, EventArgs e) //minimize button
        {
            WindowState = FormWindowState.Minimized;
            

        }

        private void measurementComboBox_SelectedIndexChanged(object sender, EventArgs e) //changing the physical quantity (length, mass, speed, etc)
        {
            
            convertUnit.Items.Clear(); 
            resultUnit.Items.Clear();

            string selectedIdx = measurementComboBox.SelectedItem.ToString(); //find selected index of the physical quantity chosen. This index matches the dictionaries (measurementDict) index. 

            if (measurementDict.ContainsKey(selectedIdx)) //search dictionary using the selected index
            {
                //add the units of measurements to both the combo boxes, selecting an index aswell in each one
                convertUnit.Items.AddRange(measurementDict[selectedIdx]);  
                convertUnit.Text = measurementDict[selectedIdx][0]; //sets text as unit of measurement at index 0
                resultUnit.Items.AddRange(measurementDict[selectedIdx]);
                resultUnit.Text = measurementDict[selectedIdx][1];

            }
        }

        private void unitToConvert_TextChanged(object sender, EventArgs e) //runs when the text (number) is changed in the unit to convert textbox. 
        {
            
            if(unitToConvert.Text == string.Empty)
            {
                conversionResult.Text = "";
                return;
            }
            if (!double.TryParse(unitToConvert.Text, out double unitValue)) //try to convert string to double. if successful, create variable called unitValue that holds the double.
            {
                unitToConvert.ForeColor = Color.Red;
                return;
            }

            unitToConvert.ForeColor = Color.White;

            Type type = typeof(ConversionMethods); //get type of ConversionMethods(Class)
            
            string methodName = modifyString(convertUnit.SelectedItem.ToString()); //The text that is displayed in the combobox for the unit you want to convert (ex. "meter"). ModifyString is a method that removes any non-letter characters 

            MethodInfo methodInfo = type.GetMethod(methodName); //find the method that matches the name of the unit you want to convert, which is located in the ConversionMethods class
            
            Object[] parameters = { resultUnit.SelectedItem.ToString(), unitValue }; //object containing the arguments that will be passed into the selected method (see the methods in ConversionMethods class)

            if (methodInfo != null) //if it can find the method name to match.
            {
                object result = methodInfo.Invoke(conversionMethods, parameters); //call the function and pass in the object containing the argument for the method
                conversionResult.Text = Math.Round((double)result, 8).ToString();
            }
            else
            {
                MessageBox.Show("Error: Method not found");
            }

        }

        private void resultUnit_SelectedIndexChanged(object sender, EventArgs e) //same as above (unitToConvert_TextChanged), but triggers only if the selected unit in the "resultUnit" combobox is changed. If you convert meters to miles, changing the combobox containing miles would trigger this
        {
            
            if (!double.TryParse(unitToConvert.Text, out double unitValue))
            {
                return;
            }

            Type type = typeof(ConversionMethods);
            
            string methodName = modifyString(convertUnit.SelectedItem.ToString());

            MethodInfo methodInfo = type.GetMethod(methodName);
            Object[] parameters = { resultUnit.SelectedItem.ToString(), unitValue };

            if (methodInfo != null) //if it can find the method name to match
            {
                object result = methodInfo.Invoke(conversionMethods, parameters); 
                conversionResult.Text = Math.Round((double)result, 8).ToString();
            }
            
        }

        private string modifyString(string str) //changes the text from the comboboxes to perfectly match the method names in "ConversionMethods". modified from: https://stackoverflow.com/questions/7411438/remove-characters-from-c-sharp-string
        {
            //For example, the combobox may show "British thermal units (IT)". This needs to be modified to match the method name, which is "BritishthermalunitsIT".
            

            string fixedString = new string((from c in str
                              where char.IsLetter(c)
                              select c
                   ).ToArray());
            return fixedString;
        }

        private void switchUnits_Click(object sender, EventArgs e) //button that switches the selected text in the unit combo boxes (ex. "miles -> meters" changes to "meters -> miles")
        {
            string convertString = convertUnit.SelectedItem.ToString(); //save the text in each combobox
            string resultString = resultUnit.SelectedItem.ToString();
            convertUnit.Text = resultString; //set the new text in each combobox
            resultUnit.Text = convertString; 
        }
        public void RemoveText(object sender, EventArgs e) //removes the string in the text box if the string matches "Notes..."
        {
            if (notesBox.Text == "Notes...")
            {
                notesBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e) //displays a string in the textbox if empty
        {
            if (string.IsNullOrWhiteSpace(notesBox.Text))
                notesBox.Text = "Notes...";
        }

        private void convertUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(unitToConvert.Text, out double unitValue))
            {
                return;
            }

            Type type = typeof(ConversionMethods);

            string methodName = modifyString(convertUnit.SelectedItem.ToString());

            MethodInfo methodInfo = type.GetMethod(methodName);

            if (resultUnit.SelectedItem != null)
            {
                Object[] parameters = { resultUnit.SelectedItem.ToString(), unitValue };

                if (methodInfo != null) //if it can find the method name to match
                {
                    object result = methodInfo.Invoke(conversionMethods, parameters);
                    conversionResult.Text = Math.Round((double)result, 8).ToString();
                }
            }
        }
    }
}
