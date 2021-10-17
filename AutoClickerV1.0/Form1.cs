using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Threading;

namespace AutoClickerV1._0
{
    
    public partial class Form1 : Form
    {
        string LeftOrRight;
        bool showPosition;
        int AllRepeatCount = 0;
        int ClicksCount = 0;
        int sayac = 0;
        int tickSayac = 0;
        public static int PositionsCount;
        Thread thread;


        int[] RepeatCounts = new int[100];

        int[] TickSpeed = new int[100];

        int[,] PositionsArray = new int[100, 2];
        //int[,] PositionsArray;
        //KeyEventArgs ke = e as KeyEventArgs;
        AutoX3 Auto = new AutoX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            RadioLeft.Checked = true;
             thread = new Thread(Tracker);
            thread.Start();
            checkBox1.Checked = true;
            
            //dizi2 = new int[,] { { 117, 200 } };
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
          
            if (RadioLeft.Checked)
            {
                LeftOrRight = "LEFT";
            }
            else
                LeftOrRight = "RIGHT";

            //set appropriate timer interval - if user selected seconds or milliseconds

            if (sayac==0)
            {
                MessageBox.Show("Lütfen Değer Giriniz.", "HATA.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
            else
            {
                if (!timer.Enabled)
                {
                    timer.Start();
                    this.Text = "AutoClick Started.";
                    StartStop.Text = "STOP";

                }
                else
                {
                    timer.Stop();
                    this.Text = "AutoClick Stopped.";
                    StartStop.Text = "START";

                }
            }

            
        }
        private void Tracker()
        {
            while (true)
            {
                if (showPosition)
                {
                    int x = MousePosition.X;
                    int y = MousePosition.Y;
                    xPosition.Text = "Mouse Position X: " + x.ToString();
                    yPosition.Text = "Mouse Position Y: " + y.ToString();
                }
                
                
            }
            
        }

        private void listBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                RepeatCounts[sayac] = (int)numericUpDown2.Value;
                TickSpeed[sayac] = (int)numericUpDown1.Value;
                if (TickSpeed[sayac] <= 0)
                {
                    MessageBox.Show("Lütfen 0'dan Yüksek Değer Giriniz. (Second)", "HATA.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    if (sayac <= 0)
                        timer.Interval = TickSpeed[sayac] * 1000;
                    PositionsArray[sayac, 0] = MousePosition.X;
                    PositionsArray[sayac, 1] = MousePosition.Y;
                    listBox1.Items.Add("X: " + PositionsArray[sayac, 0].ToString() + "    " + "Y: " + PositionsArray[sayac, 1].ToString() + "  Second: "
                        + TickSpeed[sayac].ToString() + "    " + "RepeatCount: " + RepeatCounts[sayac]);

                    sayac++;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

                Auto.Click(LeftOrRight, PositionsArray[tickSayac, 0], PositionsArray[tickSayac, 1], RepeatCounts[tickSayac], 1);
                tickSayac++;
            ClicksCount++;
                if (TickSpeed[tickSayac] != 0)
                    timer.Interval = TickSpeed[tickSayac] * 1000;

                else
                {
                    tickSayac = 0;
                AllRepeatCount++;
                AllRepeat.Text = "All Repeat Count: " + AllRepeatCount.ToString();
                }
            clickCount.Text = "Click Count: " + ClicksCount.ToString();  
           
        }

        private void StartStopLabel_Click(object sender, EventArgs e)
        {
        }

        private void Clear_Click(object sender, EventArgs e)
        {
 Clear();
        }
        void Clear()
        {
            timer.Stop();
            listBox1.Items.Clear();
            tickSayac = 0;
            sayac = 0;
            this.Text = "AutoClick Stopped.";
            AllRepeatCount = 0;
            ClicksCount = 0;
            AllRepeat.Text = "All Repeat Count: " + AllRepeatCount.ToString();
            clickCount.Text = "Click Count: " + ClicksCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tickSayac = 0;
            this.Text = "AutoClick Stopped.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                showPosition = true;
                
            }

            else
            {
               
                showPosition = false;
            }
                
        }
    }
}
