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

namespace IOTProjectFinalUI
{
    public partial class Form1 : Form
    {
        private SerialPort myPort;

        public Form1()
        {
            InitializeComponent();
            serialInitialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onButtonClick(object sender, EventArgs e)
        {
            myPort.WriteLine("on");

            onButton.Enabled = false;
            offButton.Enabled = true;
        }

        private void offButtonClick(object sender, EventArgs e)
        {
            myPort.WriteLine("off");

            onButton.Enabled = true;
            offButton.Enabled = false;
        }

        private void serialInitialize()
        {
            try
            {
                myPort = new SerialPort();
                myPort.PortName = "COM3";
                myPort.BaudRate = 9600;
                myPort.Open();
                MessageBox.Show("Arduino Connected");
            }

            catch (Exception)
            {
                MessageBox.Show("Error: Cannot Find Arduino");
            }

            onButton.Enabled = true;
            offButton.Enabled = true;
        }
    }
}
