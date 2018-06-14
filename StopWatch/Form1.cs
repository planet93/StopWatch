//Секундомер
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Объект хранящий наш показатель времени
        Stopwatch stopWatch = Stopwatch.StartNew();

        //Кнопка пуск/пауза
        private void start_stop_Click(object sender, EventArgs e)
        {

            timer1.Interval = 10;

            if(timer1.Enabled)
            {
                start_stop.Text = "Пуск";
                stopWatch.Stop();
                timer1.Stop();
            }
            else
            {
                start_stop.Text = "Пауза";
                stopWatch.Start();
                timer1.Start();
                
            }
        
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            label_time.Text = string.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        //Круг
        private void button_circle_Click(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            listBox1.Items.Add(string.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds));
        }

        //Сброс
        private void button_reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (timer1.Enabled == true)
            {
                stopWatch = Stopwatch.StartNew();
            }
            else
            {
                stopWatch = new Stopwatch();
            }
            TimeSpan ts = stopWatch.Elapsed;
            label_time.Text = string.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}
