﻿namespace AnimalFactory
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
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.btnNorthAmerica = new System.Windows.Forms.Button();
            this.btnAustralia = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnNewZealand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDisplay
            // 
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.Location = new System.Drawing.Point(244, 12);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(346, 420);
            this.listDisplay.TabIndex = 0;
            // 
            // btnNorthAmerica
            // 
            this.btnNorthAmerica.Location = new System.Drawing.Point(244, 457);
            this.btnNorthAmerica.Name = "btnNorthAmerica";
            this.btnNorthAmerica.Size = new System.Drawing.Size(93, 23);
            this.btnNorthAmerica.TabIndex = 1;
            this.btnNorthAmerica.Text = "North America";
            this.btnNorthAmerica.UseVisualStyleBackColor = true;
            this.btnNorthAmerica.Click += new System.EventHandler(this.btnNorthAmerica_Click);
            // 
            // btnAustralia
            // 
            this.btnAustralia.Location = new System.Drawing.Point(367, 457);
            this.btnAustralia.Name = "btnAustralia";
            this.btnAustralia.Size = new System.Drawing.Size(93, 23);
            this.btnAustralia.TabIndex = 2;
            this.btnAustralia.Text = "Australia";
            this.btnAustralia.UseVisualStyleBackColor = true;
            this.btnAustralia.Click += new System.EventHandler(this.btnAustralia_Click);
            // 
            // btnNewZealand
            // 
            this.btnNewZealand.Location = new System.Drawing.Point(497, 457);
            this.btnNewZealand.Name = "btnNewZealand";
            this.btnNewZealand.Size = new System.Drawing.Size(93, 23);
            this.btnNewZealand.TabIndex = 3;
            this.btnNewZealand.Text = "New Zealand";
            this.btnNewZealand.UseVisualStyleBackColor = true;
            this.btnNewZealand.Click += new System.EventHandler(this.btnNewZealand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 524);
            this.Controls.Add(this.btnNewZealand);
            this.Controls.Add(this.btnAustralia);
            this.Controls.Add(this.btnNorthAmerica);
            this.Controls.Add(this.listDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button btnNorthAmerica;
        private System.Windows.Forms.Button btnAustralia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnNewZealand;
    }
}

