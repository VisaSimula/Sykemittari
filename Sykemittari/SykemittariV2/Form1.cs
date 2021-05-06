using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SykemittariV2
{
    public partial class Form1 : Form
    {
        SerialPort Port;
        bool IsClosed = false;
        bool Session = false;
        int BPM = 0;
        int AVG = 0;
        int MAX = 0;
        int Counter = 0;

        private readonly Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.BackgroundImage = Image.FromFile(@"images\heart.png");

            Port = new SerialPort();
            Port.PortName = "COM5";
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;
            try
            {
                Port.Open();
            }
            catch { }
        }

        private void checkBoxON_OFF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxON_OFF.Checked == true)
            {
                buttonSession.Enabled = true;
                TurnOn();
                checkBoxON_OFF.Enabled = false;

            }
            else
            {
                buttonSession.Enabled = false;
                labelBPM.Text = "-";
                labelSessionAVG.Text = "-";
                labelSessionMAX.Text = "-";                
            }
        }

        private void TurnOn()
        {
            Thread Hilo = new Thread(ListenSerial);
            Hilo.Start();
        }
        private void ListenSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    //read to data from arduino
                    string AString = Port.ReadLine();
                    BPM = int.Parse(AString);
                    if(Session==true)
                    {
                        Counter++;
                        AVG = AVG + BPM;
                        if (BPM > MAX)
                            MAX = BPM;
                    }

                    //write the data in something textbox
                    labelBPM.Invoke(new MethodInvoker(
                        delegate
                        {
                            labelBPM.Text = AString;
                            if (Session == true)
                            {
                                labelSessionAVG.Text = "" + (AVG / Counter);
                                labelSessionMAX.Text = "" + MAX;
                            }
                            
                        }
                        ));
                }
                catch { }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            if (Port.IsOpen)
                Port.Close();
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {

            if (Session == true)
            {
                stopwatch.Stop();
                Session = false;
                buttonSession.Text = "Session Start!";
                panel1.BackgroundImage = null;
                panel2.BackgroundImage = null;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                labelSessionAVG.ForeColor = Color.White;
                labelSessionMAX.ForeColor = Color.White;

                
            }
            else
            {
                Counter = 0;
                AVG = 0;
                MAX = 0;
                Session = true;
                buttonSession.Text = "Session End!";

                stopwatch.Reset();
                stopwatch.Start();

                panel1.Visible = true;
                panel2.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"images\heart.png");
                panel2.BackgroundImage = Image.FromFile(@"images\heart.png");
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                labelSessionAVG.ForeColor = Color.Black;
                labelSessionMAX.ForeColor = Color.Black;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }

}
