namespace Unit_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.unitToConvert = new System.Windows.Forms.TextBox();
            this.conversionResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertUnit = new System.Windows.Forms.ComboBox();
            this.resultUnit = new System.Windows.Forms.ComboBox();
            this.measurementComboBox = new System.Windows.Forms.ComboBox();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.panel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(462, 32);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Converter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.maxButton);
            this.panel1.Controls.Add(this.minButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(322, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 32);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(98, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // maxButton
            // 
            this.maxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxButton.FlatAppearance.BorderSize = 0;
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxButton.Location = new System.Drawing.Point(59, 3);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(25, 25);
            this.maxButton.TabIndex = 1;
            this.maxButton.Text = "🗖";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // minButton
            // 
            this.minButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minButton.Location = new System.Drawing.Point(17, 3);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(25, 25);
            this.minButton.TabIndex = 0;
            this.minButton.Text = "⎯";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // unitToConvert
            // 
            this.unitToConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.unitToConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitToConvert.ForeColor = System.Drawing.SystemColors.Window;
            this.unitToConvert.Location = new System.Drawing.Point(15, 120);
            this.unitToConvert.Name = "unitToConvert";
            this.unitToConvert.Size = new System.Drawing.Size(194, 38);
            this.unitToConvert.TabIndex = 1;
            // 
            // conversionResult
            // 
            this.conversionResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.conversionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conversionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionResult.ForeColor = System.Drawing.SystemColors.Window;
            this.conversionResult.Location = new System.Drawing.Point(251, 120);
            this.conversionResult.Name = "conversionResult";
            this.conversionResult.Size = new System.Drawing.Size(194, 38);
            this.conversionResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // convertUnit
            // 
            this.convertUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.convertUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertUnit.ForeColor = System.Drawing.Color.White;
            this.convertUnit.FormattingEnabled = true;
            this.convertUnit.Location = new System.Drawing.Point(15, 164);
            this.convertUnit.Name = "convertUnit";
            this.convertUnit.Size = new System.Drawing.Size(194, 24);
            this.convertUnit.TabIndex = 4;
            // 
            // resultUnit
            // 
            this.resultUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.resultUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultUnit.ForeColor = System.Drawing.Color.White;
            this.resultUnit.FormattingEnabled = true;
            this.resultUnit.Location = new System.Drawing.Point(251, 164);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(194, 24);
            this.resultUnit.TabIndex = 5;
            // 
            // measurementComboBox
            // 
            this.measurementComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.measurementComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.measurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.measurementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementComboBox.ForeColor = System.Drawing.Color.White;
            this.measurementComboBox.FormattingEnabled = true;
            this.measurementComboBox.Items.AddRange(new object[] {
            "Area",
            "Digital Storage",
            "Energy",
            "Frequency",
            "Length",
            "Mass",
            "Pressure",
            "Speed",
            "Temperature",
            "Time",
            "Volume"});
            this.measurementComboBox.Location = new System.Drawing.Point(15, 58);
            this.measurementComboBox.Name = "measurementComboBox";
            this.measurementComboBox.Size = new System.Drawing.Size(430, 24);
            this.measurementComboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.measurementComboBox);
            this.Controls.Add(this.resultUnit);
            this.Controls.Add(this.convertUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conversionResult);
            this.Controls.Add(this.unitToConvert);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unitToConvert;
        private System.Windows.Forms.TextBox conversionResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox convertUnit;
        private System.Windows.Forms.ComboBox resultUnit;
        private System.Windows.Forms.ComboBox measurementComboBox;
    }
}

