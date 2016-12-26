using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offline_Time_Clock
{
    public partial class Form1 : Form
    {
        const int MINUTES = 60;
        int clockInHours = 0;
        int clockInMin = 0;
        int clockOutHours = 0;
        int clockOutMin = 0;
        int totalTime = 0;
        int totalTimeHours = 0;
        int totalTimeMin = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddTime_Click(object sender, EventArgs e)
        {
            clockInHours = Convert.ToInt16(TxtClockInHours.Text);
            clockInMin = Convert.ToInt16(TxtClockInMin.Text);
            clockOutHours = Convert.ToInt16(TxtClockOutHours.Text);
            clockOutMin = Convert.ToInt16(TxtClockOutMin.Text);
            totalTime = calculate(clockInHours, clockInMin, clockOutHours, clockOutMin);
            StreamWriter myStream = new StreamWriter("C:\\Users\\travis.kingery\\Documents\\Fraud\\TimeClock.txt",true);
            myStream.Write(totalTime + Environment.NewLine);
            //myStream.Write("\n");
            myStream.Close();
            TxtClockInHours.Clear();
            TxtClockInMin.Clear();
            TxtClockOutHours.Clear();
            TxtClockOutMin.Clear();
            MessageBox.Show("Time Added");
        }
        int calculate(int _inHours, int _inMin, int _outHours, int _outMin)
        {
            if (_inHours != _outHours)
                return (MINUTES - _inMin) + _outMin;
            else
            {
                return _outMin - _inMin;
            }
        }

        private void BtnTotalTime_Click(object sender, EventArgs e)
        {
            StreamReader myStream = new StreamReader("C:\\Users\\travis.kingery\\Documents\\Fraud\\TimeClock.txt");
            totalTime = 0;
            try
            {
                while(true)
                {
                    string sTemp = myStream.ReadLine();
                    int temp = totalTime;
                    totalTime = temp + Convert.ToInt16(sTemp);
                    if (sTemp == null)
                        break;
                }
                TxtTotalTimeMin.Text = Convert.ToString(totalTime);
                hoursMinConvert(totalTime);
            }
            catch
            {
                MessageBox.Show("File is empty or problem with reading file");
            }
            finally
            {
                myStream.Close();
            }
        }
        void hoursMinConvert(int totalTime)
        {
            totalTimeHours = totalTime / MINUTES;
            totalTimeMin = totalTime - (totalTimeHours * MINUTES);
            TxtTotalTimeBroken.Text = $"{totalTimeHours} H. {totalTimeMin} M.";
        }
    }
}