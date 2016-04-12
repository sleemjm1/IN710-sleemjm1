namespace LambdaPredicate
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
            this.listGeneratedNumbers = new System.Windows.Forms.ListBox();
            this.listSortedNumbers = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnLessThanTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGeneratedNumbers
            // 
            this.listGeneratedNumbers.FormattingEnabled = true;
            this.listGeneratedNumbers.Location = new System.Drawing.Point(25, 98);
            this.listGeneratedNumbers.Name = "listGeneratedNumbers";
            this.listGeneratedNumbers.Size = new System.Drawing.Size(178, 459);
            this.listGeneratedNumbers.TabIndex = 4;
            // 
            // listSortedNumbers
            // 
            this.listSortedNumbers.FormattingEnabled = true;
            this.listSortedNumbers.Location = new System.Drawing.Point(228, 98);
            this.listSortedNumbers.Name = "listSortedNumbers";
            this.listSortedNumbers.Size = new System.Drawing.Size(178, 459);
            this.listSortedNumbers.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(25, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(178, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Randoms";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(228, 12);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(178, 23);
            this.btnEven.TabIndex = 7;
            this.btnEven.Text = "Select Even Numbers";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnLessThanTen
            // 
            this.btnLessThanTen.Location = new System.Drawing.Point(228, 57);
            this.btnLessThanTen.Name = "btnLessThanTen";
            this.btnLessThanTen.Size = new System.Drawing.Size(178, 23);
            this.btnLessThanTen.TabIndex = 8;
            this.btnLessThanTen.Text = "Select Numbers < 10";
            this.btnLessThanTen.UseVisualStyleBackColor = true;
            this.btnLessThanTen.Click += new System.EventHandler(this.btnLessThanTen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 588);
            this.Controls.Add(this.btnLessThanTen);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.listSortedNumbers);
            this.Controls.Add(this.listGeneratedNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listGeneratedNumbers;
        private System.Windows.Forms.ListBox listSortedNumbers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnLessThanTen;

    }
}

