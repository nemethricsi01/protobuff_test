using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace protobuff_test
{
    
    public partial class Form1 : Form
    {
        SensorToIface sensorToIface = new SensorToIface
        {
            Sensorstype = SensorsTypeEnum.SensorMessageSensorData
        };
        SensorData sensorData = new SensorData
        {
            O2 = 0,
            Co = 0,
            Co2 = 0,
            Flow = 0,
            Humidity = 0,
            Pid = 0,
            PressureIn = 0,
            PressureOut = 0,
            Temperature = 0
        };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lowPressCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(lowPressCheckbox.Checked == true)
            {
                lowPressCheckbox.BackColor = Color.Red;
            }
            else
            {
                lowPressCheckbox.BackColor = Color.Silver;
            }
        }

        private void trackBarO2_ValueChanged(object sender, EventArgs e)
        {
            labelO2.Text = trackBarO2.Value.ToString();
            sensorData.O2 = (uint)trackBarO2.Value;
            // Serialize the message to a byte array
            label7.Text = sensorToIface.ToString();

        }

        private void trackBarCO_ValueChanged(object sender, EventArgs e)
        {
            labelCO.Text = trackBarCO.Value.ToString() + " ppm";
            sensorData.Co = (uint)trackBarCO.Value;
        }

        private void trackBarCO2_ValueChanged(object sender, EventArgs e)
        {
            labelCO2.Text = trackBarCO2.Value.ToString() + " ppm";
            sensorData.Co2 = (uint)trackBarCO2.Value;
        }

        private void trackBarDEW_ValueChanged(object sender, EventArgs e)
        {
            labelDEW.Text = trackBarDEW.Value.ToString() + " °F";
            sensorData.Pid = (uint)trackBarDEW.Value;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            comboBox1.Items.Clear();

            comboBox1.Items.AddRange(portNames);
            if (portNames.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxError.Visible = false;
            serialPort1.PortName = comboBox1.Text.ToString();
            string baud = comboBox2.Text.ToString();
            int baudRate;
            if (int.TryParse(baud, out baudRate))
            {
                // Set the SerialPort's baud rate to the selected value
                serialPort1.BaudRate = baudRate;
            }
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                textBoxError.Visible=true;
                textBoxError.Text=ex.Message;
            };
            
        }
    }
}
