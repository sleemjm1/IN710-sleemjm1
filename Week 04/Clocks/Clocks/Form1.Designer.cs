﻿namespace Clocks
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAnalogue = new System.Windows.Forms.RadioButton();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.lblDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 57);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(45, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(194, 57);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnalogue);
            this.groupBox1.Controls.Add(this.rbDigital);
            this.groupBox1.Location = new System.Drawing.Point(289, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbAnalogue
            // 
            this.rbAnalogue.AutoSize = true;
            this.rbAnalogue.Location = new System.Drawing.Point(22, 76);
            this.rbAnalogue.Name = "rbAnalogue";
            this.rbAnalogue.Size = new System.Drawing.Size(70, 17);
            this.rbAnalogue.TabIndex = 1;
            this.rbAnalogue.TabStop = true;
            this.rbAnalogue.Text = "Analogue";
            this.rbAnalogue.UseVisualStyleBackColor = true;
            this.rbAnalogue.CheckedChanged += new System.EventHandler(this.rbAnalogue_CheckedChanged);
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(22, 39);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(54, 17);
            this.rbDigital.TabIndex = 0;
            this.rbDigital.TabStop = true;
            this.rbDigital.Text = "Digital";
            this.rbDigital.UseVisualStyleBackColor = true;
            this.rbDigital.CheckedChanged += new System.EventHandler(this.rbDigital_CheckedChanged);
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(92, 203);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(273, 273);
            this.analogClock1.TabIndex = 3;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigital.Location = new System.Drawing.Point(94, 296);
            this.lblDigital.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDigital.Size = new System.Drawing.Size(284, 73);
            this.lblDigital.TabIndex = 4;
            this.lblDigital.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 604);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Clocks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAnalogue;
        private System.Windows.Forms.RadioButton rbDigital;
        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Timer timer1;
    }
}

