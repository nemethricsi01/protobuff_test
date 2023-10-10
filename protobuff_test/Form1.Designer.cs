namespace protobuff_test
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
            this.lowPressCheckbox = new System.Windows.Forms.CheckBox();
            this.trackBarO2 = new System.Windows.Forms.TrackBar();
            this.trackBarCO = new System.Windows.Forms.TrackBar();
            this.trackBarCO2 = new System.Windows.Forms.TrackBar();
            this.trackBarDEW = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelO2 = new System.Windows.Forms.Label();
            this.labelCO = new System.Windows.Forms.Label();
            this.labelCO2 = new System.Windows.Forms.Label();
            this.labelDEW = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDEW)).BeginInit();
            this.SuspendLayout();
            // 
            // lowPressCheckbox
            // 
            this.lowPressCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.lowPressCheckbox.AutoSize = true;
            this.lowPressCheckbox.BackColor = System.Drawing.Color.Silver;
            this.lowPressCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowPressCheckbox.Location = new System.Drawing.Point(155, 12);
            this.lowPressCheckbox.Name = "lowPressCheckbox";
            this.lowPressCheckbox.Size = new System.Drawing.Size(153, 35);
            this.lowPressCheckbox.TabIndex = 0;
            this.lowPressCheckbox.Text = "Low Pressure";
            this.lowPressCheckbox.UseVisualStyleBackColor = false;
            this.lowPressCheckbox.CheckedChanged += new System.EventHandler(this.lowPressCheckbox_CheckedChanged);
            // 
            // trackBarO2
            // 
            this.trackBarO2.Location = new System.Drawing.Point(155, 104);
            this.trackBarO2.Maximum = 100;
            this.trackBarO2.Name = "trackBarO2";
            this.trackBarO2.Size = new System.Drawing.Size(104, 45);
            this.trackBarO2.TabIndex = 1;
            this.trackBarO2.ValueChanged += new System.EventHandler(this.trackBarO2_ValueChanged);
            // 
            // trackBarCO
            // 
            this.trackBarCO.Location = new System.Drawing.Point(155, 171);
            this.trackBarCO.Maximum = 100;
            this.trackBarCO.Name = "trackBarCO";
            this.trackBarCO.Size = new System.Drawing.Size(104, 45);
            this.trackBarCO.TabIndex = 2;
            this.trackBarCO.ValueChanged += new System.EventHandler(this.trackBarCO_ValueChanged);
            // 
            // trackBarCO2
            // 
            this.trackBarCO2.Location = new System.Drawing.Point(155, 238);
            this.trackBarCO2.Maximum = 1000;
            this.trackBarCO2.Name = "trackBarCO2";
            this.trackBarCO2.Size = new System.Drawing.Size(104, 45);
            this.trackBarCO2.SmallChange = 10;
            this.trackBarCO2.TabIndex = 3;
            this.trackBarCO2.ValueChanged += new System.EventHandler(this.trackBarCO2_ValueChanged);
            // 
            // trackBarDEW
            // 
            this.trackBarDEW.Location = new System.Drawing.Point(155, 305);
            this.trackBarDEW.Maximum = 100;
            this.trackBarDEW.Name = "trackBarDEW";
            this.trackBarDEW.Size = new System.Drawing.Size(104, 45);
            this.trackBarDEW.TabIndex = 4;
            this.trackBarDEW.ValueChanged += new System.EventHandler(this.trackBarDEW_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "O2 level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CO level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CO2 level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dewpoint";
            // 
            // labelO2
            // 
            this.labelO2.AutoSize = true;
            this.labelO2.Location = new System.Drawing.Point(279, 104);
            this.labelO2.Name = "labelO2";
            this.labelO2.Size = new System.Drawing.Size(13, 13);
            this.labelO2.TabIndex = 9;
            this.labelO2.Text = "0";
            // 
            // labelCO
            // 
            this.labelCO.AutoSize = true;
            this.labelCO.Location = new System.Drawing.Point(279, 171);
            this.labelCO.Name = "labelCO";
            this.labelCO.Size = new System.Drawing.Size(13, 13);
            this.labelCO.TabIndex = 10;
            this.labelCO.Text = "0";
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Location = new System.Drawing.Point(279, 238);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(13, 13);
            this.labelCO2.TabIndex = 11;
            this.labelCO2.Text = "0";
            // 
            // labelDEW
            // 
            this.labelDEW.AutoSize = true;
            this.labelDEW.Location = new System.Drawing.Point(279, 305);
            this.labelDEW.Name = "labelDEW";
            this.labelDEW.Size = new System.Drawing.Size(13, 13);
            this.labelDEW.TabIndex = 12;
            this.labelDEW.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(588, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "COM1";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serial port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Serial speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(588, 128);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "115200";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(603, 196);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(100, 100);
            this.textBoxError.TabIndex = 19;
            this.textBoxError.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDEW);
            this.Controls.Add(this.labelCO2);
            this.Controls.Add(this.labelCO);
            this.Controls.Add(this.labelO2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarDEW);
            this.Controls.Add(this.trackBarCO2);
            this.Controls.Add(this.trackBarCO);
            this.Controls.Add(this.trackBarO2);
            this.Controls.Add(this.lowPressCheckbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lowPressCheckbox;
        private System.Windows.Forms.TrackBar trackBarO2;
        private System.Windows.Forms.TrackBar trackBarCO;
        private System.Windows.Forms.TrackBar trackBarCO2;
        private System.Windows.Forms.TrackBar trackBarDEW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelO2;
        private System.Windows.Forms.Label labelCO;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Label labelDEW;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

