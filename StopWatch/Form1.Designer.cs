namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_stop = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_circle = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // start_stop
            // 
            this.start_stop.Location = new System.Drawing.Point(12, 12);
            this.start_stop.Name = "start_stop";
            this.start_stop.Size = new System.Drawing.Size(124, 52);
            this.start_stop.TabIndex = 0;
            this.start_stop.Text = "Старт";
            this.start_stop.UseVisualStyleBackColor = true;
            this.start_stop.Click += new System.EventHandler(this.start_stop_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(144, 28);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(108, 25);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "00:00.000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_circle
            // 
            this.button_circle.Location = new System.Drawing.Point(12, 70);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(123, 51);
            this.button_circle.TabIndex = 2;
            this.button_circle.Text = "Круг";
            this.button_circle.UseVisualStyleBackColor = true;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(13, 127);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(123, 50);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(149, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 108);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 193);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_circle);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.start_stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_stop;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox listBox1;
    }
}

