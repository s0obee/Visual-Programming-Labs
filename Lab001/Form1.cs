using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblRemainingTime2.Text = counter.ToString();
            progressBarTimer.Step = 1;
            progressBarTimer.Maximum = counter;
            progressBarTimer.Minimum = 0;
            progressBarTimer.Value = 0;
            timer2.Interval = 1000;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Stop();
                if(counter > 0)
                {
                    MessageBox.Show("Oyunu Kazandınız ..: ");
                }
            }
            else
            {
                timer1.Start();
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rmd = new Random();
            btnClick.Location = new Point(rmd.Next(0,Size.Width), rmd.Next(0,Size.Height));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            lblRemainingTime2.Text = counter.ToString();
            progressBarTimer.PerformStep();
            if (counter <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Oyun Bitti. Kaybettiniz ..: ");
            }
        }
    }
}
