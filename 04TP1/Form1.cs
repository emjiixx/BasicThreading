using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A ";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B ";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C ";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D ";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblThread.Text = "End of Thread";
        }
    }
}
