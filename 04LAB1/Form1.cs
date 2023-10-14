using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreading
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            Thread thread1 = new Thread(MyThreadClass.Thread1);
            thread1.Name = "Thread A: ";

            Thread thread2 = new Thread(MyThreadClass.Thread2);
            thread2.Name = "Thread B: ";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            lblThread.Text = "Thread finished";
        }
    }
}
