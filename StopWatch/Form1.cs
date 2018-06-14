using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime date;
        private void start_stop_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            timer1.Enabled = !timer1.Enabled;
            start_stop.Text = timer1.Enabled ? "Stop" : "Start";

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();

            stopWatch = stopWatch.AddTicks(tick);
            label_time.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }
    }
}
