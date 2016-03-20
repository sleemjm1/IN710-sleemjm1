namespace ComputerMaker
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
            this.btnPrintSpec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultimedia = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbGaming = new System.Windows.Forms.RadioButton();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.rbLaptop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintSpec
            // 
            this.btnPrintSpec.Location = new System.Drawing.Point(27, 24);
            this.btnPrintSpec.Name = "btnPrintSpec";
            this.btnPrintSpec.Size = new System.Drawing.Size(119, 23);
            this.btnPrintSpec.TabIndex = 0;
            this.btnPrintSpec.Text = "Print Spec";
            this.btnPrintSpec.UseVisualStyleBackColor = true;
            this.btnPrintSpec.Click += new System.EventHandler(this.btnPrintSpec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLaptop);
            this.groupBox1.Controls.Add(this.rbMultimedia);
            this.groupBox1.Controls.Add(this.rbBusiness);
            this.groupBox1.Controls.Add(this.rbGaming);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Type";
            // 
            // rbMultimedia
            // 
            this.rbMultimedia.AutoSize = true;
            this.rbMultimedia.Location = new System.Drawing.Point(18, 106);
            this.rbMultimedia.Name = "rbMultimedia";
            this.rbMultimedia.Size = new System.Drawing.Size(75, 17);
            this.rbMultimedia.TabIndex = 2;
            this.rbMultimedia.TabStop = true;
            this.rbMultimedia.Text = "Multimedia";
            this.rbMultimedia.UseVisualStyleBackColor = true;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Location = new System.Drawing.Point(18, 70);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbBusiness.TabIndex = 1;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbGaming
            // 
            this.rbGaming.AutoSize = true;
            this.rbGaming.Location = new System.Drawing.Point(18, 33);
            this.rbGaming.Name = "rbGaming";
            this.rbGaming.Size = new System.Drawing.Size(61, 17);
            this.rbGaming.TabIndex = 0;
            this.rbGaming.TabStop = true;
            this.rbGaming.Text = "Gaming";
            this.rbGaming.UseVisualStyleBackColor = true;
            // 
            // listDisplay
            // 
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 24;
            this.listDisplay.Location = new System.Drawing.Point(177, 24);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(518, 244);
            this.listDisplay.TabIndex = 2;
            // 
            // rbLaptop
            // 
            this.rbLaptop.AutoSize = true;
            this.rbLaptop.Location = new System.Drawing.Point(18, 144);
            this.rbLaptop.Name = "rbLaptop";
            this.rbLaptop.Size = new System.Drawing.Size(58, 17);
            this.rbLaptop.TabIndex = 3;
            this.rbLaptop.TabStop = true;
            this.rbLaptop.Text = "Laptop";
            this.rbLaptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 320);
            this.Controls.Add(this.listDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintSpec);
            this.Name = "Form1";
            this.Text = "Computer Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintSpec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultimedia;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbGaming;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.RadioButton rbLaptop;
    }
}

