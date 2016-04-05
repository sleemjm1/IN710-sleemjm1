namespace FireAlarm
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
            this.rbMinor = new System.Windows.Forms.RadioButton();
            this.rbSerious = new System.Windows.Forms.RadioButton();
            this.rbInferno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fire Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInferno);
            this.groupBox1.Controls.Add(this.rbSerious);
            this.groupBox1.Controls.Add(this.rbMinor);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // rbMinor
            // 
            this.rbMinor.AutoSize = true;
            this.rbMinor.Location = new System.Drawing.Point(18, 39);
            this.rbMinor.Name = "rbMinor";
            this.rbMinor.Size = new System.Drawing.Size(51, 17);
            this.rbMinor.TabIndex = 0;
            this.rbMinor.TabStop = true;
            this.rbMinor.Text = "Minor";
            this.rbMinor.UseVisualStyleBackColor = true;
            // 
            // rbSerious
            // 
            this.rbSerious.AutoSize = true;
            this.rbSerious.Location = new System.Drawing.Point(18, 88);
            this.rbSerious.Name = "rbSerious";
            this.rbSerious.Size = new System.Drawing.Size(60, 17);
            this.rbSerious.TabIndex = 1;
            this.rbSerious.TabStop = true;
            this.rbSerious.Text = "Serious";
            this.rbSerious.UseVisualStyleBackColor = true;
            // 
            // rbInferno
            // 
            this.rbInferno.AutoSize = true;
            this.rbInferno.Location = new System.Drawing.Point(18, 140);
            this.rbInferno.Name = "rbInferno";
            this.rbInferno.Size = new System.Drawing.Size(58, 17);
            this.rbInferno.TabIndex = 2;
            this.rbInferno.TabStop = true;
            this.rbInferno.Text = "Inferno";
            this.rbInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fire Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInferno;
        private System.Windows.Forms.RadioButton rbSerious;
        private System.Windows.Forms.RadioButton rbMinor;
    }
}

