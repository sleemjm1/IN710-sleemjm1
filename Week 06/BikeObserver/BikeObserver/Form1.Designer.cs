namespace BikeObserver
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblCaloriesPerHour = new System.Windows.Forms.Label();
            this.lblKMPerHour = new System.Windows.Forms.Label();
            this.tbChangeSpeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRPM);
            this.groupBox1.Location = new System.Drawing.Point(13, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCaloriesPerHour);
            this.groupBox2.Location = new System.Drawing.Point(13, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calories Per Hour";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKMPerHour);
            this.groupBox3.Location = new System.Drawing.Point(21, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KMs per hour";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(166, 32);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(91, 55);
            this.lblRPM.TabIndex = 0;
            this.lblRPM.Text = "0.0";
            // 
            // lblCaloriesPerHour
            // 
            this.lblCaloriesPerHour.AutoSize = true;
            this.lblCaloriesPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesPerHour.Location = new System.Drawing.Point(166, 35);
            this.lblCaloriesPerHour.Name = "lblCaloriesPerHour";
            this.lblCaloriesPerHour.Size = new System.Drawing.Size(91, 55);
            this.lblCaloriesPerHour.TabIndex = 1;
            this.lblCaloriesPerHour.Text = "0.0";
            // 
            // lblKMPerHour
            // 
            this.lblKMPerHour.AutoSize = true;
            this.lblKMPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKMPerHour.Location = new System.Drawing.Point(158, 36);
            this.lblKMPerHour.Name = "lblKMPerHour";
            this.lblKMPerHour.Size = new System.Drawing.Size(91, 55);
            this.lblKMPerHour.TabIndex = 2;
            this.lblKMPerHour.Text = "0.0";
            // 
            // tbChangeSpeed
            // 
            this.tbChangeSpeed.Location = new System.Drawing.Point(189, 13);
            this.tbChangeSpeed.Name = "tbChangeSpeed";
            this.tbChangeSpeed.Size = new System.Drawing.Size(284, 20);
            this.tbChangeSpeed.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 543);
            this.Controls.Add(this.tbChangeSpeed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblCaloriesPerHour;
        private System.Windows.Forms.Label lblKMPerHour;
        private System.Windows.Forms.TextBox tbChangeSpeed;
    }
}

