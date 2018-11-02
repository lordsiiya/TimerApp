namespace Timer101
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.Messagelabel1 = new System.Windows.Forms.Label();
            this.TimeTextBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timerMins = new System.Windows.Forms.TextBox();
            this.TimerTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CounterHoursTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CounterTimetextBox = new System.Windows.Forms.TextBox();
            this.buttonCounter = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Messagelabel2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMinutesLeft = new System.Windows.Forms.RichTextBox();
            this.LabelMinutesLeft = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(3, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 105);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START COUNTDOWN";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Messagelabel1
            // 
            this.Messagelabel1.AutoSize = true;
            this.Messagelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel1.ForeColor = System.Drawing.Color.Red;
            this.Messagelabel1.Location = new System.Drawing.Point(5, 263);
            this.Messagelabel1.Name = "Messagelabel1";
            this.Messagelabel1.Size = new System.Drawing.Size(23, 31);
            this.Messagelabel1.TabIndex = 1;
            this.Messagelabel1.Text = ".";
            // 
            // TimeTextBox1
            // 
            this.TimeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTextBox1.Location = new System.Drawing.Point(176, 16);
            this.TimeTextBox1.Name = "TimeTextBox1";
            this.TimeTextBox1.Size = new System.Drawing.Size(100, 24);
            this.TimeTextBox1.TabIndex = 2;
            this.TimeTextBox1.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time in Seconds";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSTOP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.timerMins);
            this.panel1.Controls.Add(this.TimerTextBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TimeTextBox1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(21, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 121);
            this.panel1.TabIndex = 4;
            // 
            // btnSTOP
            // 
            this.btnSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSTOP.Location = new System.Drawing.Point(-18, 6);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(79, 112);
            this.btnSTOP.TabIndex = 9;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time in Mins";
            // 
            // timerMins
            // 
            this.timerMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerMins.Location = new System.Drawing.Point(179, 55);
            this.timerMins.Name = "timerMins";
            this.timerMins.Size = new System.Drawing.Size(100, 24);
            this.timerMins.TabIndex = 7;
            this.timerMins.Text = "00";
            // 
            // TimerTextBox2
            // 
            this.TimerTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTextBox2.Location = new System.Drawing.Point(176, 95);
            this.TimerTextBox2.Name = "TimerTextBox2";
            this.TimerTextBox2.Size = new System.Drawing.Size(100, 24);
            this.TimerTextBox2.TabIndex = 6;
            this.TimerTextBox2.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time in Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time in Seconds";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CounterHoursTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CounterTimetextBox);
            this.panel2.Controls.Add(this.buttonCounter);
            this.panel2.Location = new System.Drawing.Point(16, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 112);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "STOP COUNTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mins";
            // 
            // CounterHoursTextBox
            // 
            this.CounterHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterHoursTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CounterHoursTextBox.Location = new System.Drawing.Point(131, 61);
            this.CounterHoursTextBox.Name = "CounterHoursTextBox";
            this.CounterHoursTextBox.ReadOnly = true;
            this.CounterHoursTextBox.Size = new System.Drawing.Size(63, 31);
            this.CounterHoursTextBox.TabIndex = 5;
            this.CounterHoursTextBox.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Elapsed ";
            // 
            // CounterTimetextBox
            // 
            this.CounterTimetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterTimetextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CounterTimetextBox.Location = new System.Drawing.Point(216, 61);
            this.CounterTimetextBox.Name = "CounterTimetextBox";
            this.CounterTimetextBox.ReadOnly = true;
            this.CounterTimetextBox.Size = new System.Drawing.Size(60, 31);
            this.CounterTimetextBox.TabIndex = 3;
            this.CounterTimetextBox.Text = "00";
            // 
            // buttonCounter
            // 
            this.buttonCounter.BackColor = System.Drawing.Color.Lime;
            this.buttonCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCounter.Location = new System.Drawing.Point(3, 3);
            this.buttonCounter.Name = "buttonCounter";
            this.buttonCounter.Size = new System.Drawing.Size(108, 52);
            this.buttonCounter.TabIndex = 0;
            this.buttonCounter.Text = "START COUNTER";
            this.buttonCounter.UseVisualStyleBackColor = false;
            this.buttonCounter.Click += new System.EventHandler(this.buttonCounter_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Messagelabel2
            // 
            this.Messagelabel2.AutoSize = true;
            this.Messagelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelabel2.ForeColor = System.Drawing.Color.LawnGreen;
            this.Messagelabel2.Location = new System.Drawing.Point(-3, 295);
            this.Messagelabel2.Name = "Messagelabel2";
            this.Messagelabel2.Size = new System.Drawing.Size(27, 37);
            this.Messagelabel2.TabIndex = 6;
            this.Messagelabel2.Text = ".";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Controls.Add(this.txtMinutesLeft);
            this.panel3.Controls.Add(this.LabelMinutesLeft);
            this.panel3.Location = new System.Drawing.Point(349, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 207);
            this.panel3.TabIndex = 7;
            // 
            // txtMinutesLeft
            // 
            this.txtMinutesLeft.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtMinutesLeft.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutesLeft.ForeColor = System.Drawing.Color.White;
            this.txtMinutesLeft.Location = new System.Drawing.Point(7, 60);
            this.txtMinutesLeft.Name = "txtMinutesLeft";
            this.txtMinutesLeft.ReadOnly = true;
            this.txtMinutesLeft.Size = new System.Drawing.Size(182, 143);
            this.txtMinutesLeft.TabIndex = 1;
            this.txtMinutesLeft.Text = "";
            // 
            // LabelMinutesLeft
            // 
            this.LabelMinutesLeft.AutoSize = true;
            this.LabelMinutesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinutesLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelMinutesLeft.Location = new System.Drawing.Point(6, 36);
            this.LabelMinutesLeft.Name = "LabelMinutesLeft";
            this.LabelMinutesLeft.Size = new System.Drawing.Size(20, 16);
            this.LabelMinutesLeft.TabIndex = 0;
            this.LabelMinutesLeft.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(348, 342);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Messagelabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Messagelabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Messagelabel1;
        private System.Windows.Forms.TextBox TimeTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CounterTimetextBox;
        private System.Windows.Forms.Button buttonCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CounterHoursTextBox;
        private System.Windows.Forms.Label Messagelabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TimerTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelMinutesLeft;
        private System.Windows.Forms.RichTextBox txtMinutesLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox timerMins;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSTOP;
    }
}

