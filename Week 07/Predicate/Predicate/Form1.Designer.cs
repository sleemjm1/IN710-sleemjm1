namespace Predicate
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnLessThanTen = new System.Windows.Forms.Button();
            this.listGeneratedNumbers = new System.Windows.Forms.ListBox();
            this.listSelectedNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(49, 45);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(178, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Randoms";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(273, 45);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(178, 23);
            this.btnEven.TabIndex = 1;
            this.btnEven.Text = "Select Even Numbers";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnLessThanTen
            // 
            this.btnLessThanTen.Location = new System.Drawing.Point(273, 90);
            this.btnLessThanTen.Name = "btnLessThanTen";
            this.btnLessThanTen.Size = new System.Drawing.Size(178, 23);
            this.btnLessThanTen.TabIndex = 2;
            this.btnLessThanTen.Text = "Select Numbers < 10";
            this.btnLessThanTen.UseVisualStyleBackColor = true;
            this.btnLessThanTen.Click += new System.EventHandler(this.btnLessThanTen_Click);
            // 
            // listGeneratedNumbers
            // 
            this.listGeneratedNumbers.FormattingEnabled = true;
            this.listGeneratedNumbers.Location = new System.Drawing.Point(49, 138);
            this.listGeneratedNumbers.Name = "listGeneratedNumbers";
            this.listGeneratedNumbers.Size = new System.Drawing.Size(178, 459);
            this.listGeneratedNumbers.TabIndex = 3;
            // 
            // listSelectedNumbers
            // 
            this.listSelectedNumbers.FormattingEnabled = true;
            this.listSelectedNumbers.Location = new System.Drawing.Point(273, 138);
            this.listSelectedNumbers.Name = "listSelectedNumbers";
            this.listSelectedNumbers.Size = new System.Drawing.Size(178, 459);
            this.listSelectedNumbers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 637);
            this.Controls.Add(this.listSelectedNumbers);
            this.Controls.Add(this.listGeneratedNumbers);
            this.Controls.Add(this.btnLessThanTen);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Predicate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnLessThanTen;
        private System.Windows.Forms.ListBox listGeneratedNumbers;
        private System.Windows.Forms.ListBox listSelectedNumbers;
    }
}

