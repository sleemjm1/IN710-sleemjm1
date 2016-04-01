namespace ProgressIndicator
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rbNumericSpin = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrackBar);
            this.groupBox1.Controls.Add(this.rbProgressBar);
            this.groupBox1.Controls.Add(this.rbNumericSpin);
            this.groupBox1.Location = new System.Drawing.Point(288, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress Type";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 137);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 223);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(454, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // rbNumericSpin
            // 
            this.rbNumericSpin.AutoSize = true;
            this.rbNumericSpin.Location = new System.Drawing.Point(17, 34);
            this.rbNumericSpin.Name = "rbNumericSpin";
            this.rbNumericSpin.Size = new System.Drawing.Size(88, 17);
            this.rbNumericSpin.TabIndex = 0;
            this.rbNumericSpin.TabStop = true;
            this.rbNumericSpin.Text = "Numeric Spin";
            this.rbNumericSpin.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Location = new System.Drawing.Point(17, 70);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rbProgressBar.TabIndex = 1;
            this.rbProgressBar.TabStop = true;
            this.rbProgressBar.Text = "Progress Bar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Location = new System.Drawing.Point(17, 107);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rbTrackBar.TabIndex = 2;
            this.rbTrackBar.TabStop = true;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 278);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbNumericSpin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

