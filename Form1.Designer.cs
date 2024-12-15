using System.Windows.Forms;

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
            this.switchUnits = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.panel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 26);
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
            this.maxButton.Location = new System.Drawing.Point(60, 2);
            this.maxButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(24, 26);
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
            this.minButton.Location = new System.Drawing.Point(16, 2);
            this.minButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(24, 26);
            this.minButton.TabIndex = 0;
            this.minButton.Text = "⎯";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // unitToConvert
            // 
            this.unitToConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unitToConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.unitToConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitToConvert.ForeColor = System.Drawing.SystemColors.Window;
            this.unitToConvert.Location = new System.Drawing.Point(15, 64);
            this.unitToConvert.Margin = new System.Windows.Forms.Padding(15, 10, 4, 2);
            this.unitToConvert.Name = "unitToConvert";
            this.unitToConvert.Size = new System.Drawing.Size(188, 38);
            this.unitToConvert.TabIndex = 1;
            this.unitToConvert.TextChanged += new System.EventHandler(this.unitToConvert_TextChanged);
            // 
            // conversionResult
            // 
            this.conversionResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conversionResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.conversionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conversionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionResult.ForeColor = System.Drawing.SystemColors.Window;
            this.conversionResult.Location = new System.Drawing.Point(257, 64);
            this.conversionResult.Margin = new System.Windows.Forms.Padding(4, 10, 15, 2);
            this.conversionResult.Name = "conversionResult";
            this.conversionResult.ReadOnly = true;
            this.conversionResult.Size = new System.Drawing.Size(190, 38);
            this.conversionResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertUnit
            // 
            this.convertUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.convertUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertUnit.ForeColor = System.Drawing.Color.White;
            this.convertUnit.FormattingEnabled = true;
            this.convertUnit.IntegralHeight = false;
            this.convertUnit.ItemHeight = 18;
            this.convertUnit.Location = new System.Drawing.Point(15, 115);
            this.convertUnit.Margin = new System.Windows.Forms.Padding(15, 10, 4, 2);
            this.convertUnit.Name = "convertUnit";
            this.convertUnit.Size = new System.Drawing.Size(188, 26);
            this.convertUnit.TabIndex = 4;
            // 
            // resultUnit
            // 
            this.resultUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.resultUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultUnit.ForeColor = System.Drawing.Color.White;
            this.resultUnit.FormattingEnabled = true;
            this.resultUnit.IntegralHeight = false;
            this.resultUnit.ItemHeight = 18;
            this.resultUnit.Location = new System.Drawing.Point(257, 115);
            this.resultUnit.Margin = new System.Windows.Forms.Padding(4, 10, 15, 2);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(190, 26);
            this.resultUnit.TabIndex = 5;
            this.resultUnit.SelectedIndexChanged += new System.EventHandler(this.resultUnit_SelectedIndexChanged);
            // 
            // measurementComboBox
            // 
            this.measurementComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.measurementComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel1.SetColumnSpan(this.measurementComboBox, 3);
            this.measurementComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.measurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.measurementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementComboBox.ForeColor = System.Drawing.Color.White;
            this.measurementComboBox.FormattingEnabled = true;
            this.measurementComboBox.Location = new System.Drawing.Point(15, 10);
            this.measurementComboBox.Margin = new System.Windows.Forms.Padding(15, 10, 15, 2);
            this.measurementComboBox.Name = "measurementComboBox";
            this.measurementComboBox.Size = new System.Drawing.Size(432, 26);
            this.measurementComboBox.TabIndex = 6;
            this.measurementComboBox.SelectedIndexChanged += new System.EventHandler(this.measurementComboBox_SelectedIndexChanged);
            // 
            // switchUnits
            // 
            this.switchUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.switchUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.switchUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchUnits.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.switchUnits.Image = ((System.Drawing.Image)(resources.GetObject("switchUnits.Image")));
            this.switchUnits.Location = new System.Drawing.Point(210, 117);
            this.switchUnits.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.switchUnits.Name = "switchUnits";
            this.switchUnits.Size = new System.Drawing.Size(40, 22);
            this.switchUnits.TabIndex = 8;
            this.switchUnits.UseVisualStyleBackColor = false;
            this.switchUnits.Click += new System.EventHandler(this.switchUnits_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.measurementComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultUnit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.switchUnits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.convertUnit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.conversionResult, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.unitToConvert, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 155);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // notesBox
            // 
            this.notesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.ForeColor = System.Drawing.Color.White;
            this.notesBox.Location = new System.Drawing.Point(15, 210);
            this.notesBox.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesBox.Size = new System.Drawing.Size(433, 122);
            this.notesBox.TabIndex = 0;
            this.notesBox.Text = "Notes...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button switchUnits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox notesBox;
    }
}

