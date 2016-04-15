namespace PredicateDelegate2016
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
            this.btnSelectLessThan = new System.Windows.Forms.Button();
            this.lstGenerate = new System.Windows.Forms.ListBox();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(66, 66);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(223, 34);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Randoms";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(364, 66);
            this.btnEven.Margin = new System.Windows.Forms.Padding(4);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(223, 34);
            this.btnEven.TabIndex = 1;
            this.btnEven.Text = "Select Even Numbers";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnSelectLessThan
            // 
            this.btnSelectLessThan.Location = new System.Drawing.Point(364, 134);
            this.btnSelectLessThan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectLessThan.Name = "btnSelectLessThan";
            this.btnSelectLessThan.Size = new System.Drawing.Size(223, 34);
            this.btnSelectLessThan.TabIndex = 2;
            this.btnSelectLessThan.Text = "Select Numbers < 10";
            this.btnSelectLessThan.UseVisualStyleBackColor = true;
            this.btnSelectLessThan.Click += new System.EventHandler(this.btnSelectLessThan_Click);
            // 
            // lstGenerate
            // 
            this.lstGenerate.FormattingEnabled = true;
            this.lstGenerate.ItemHeight = 24;
            this.lstGenerate.Location = new System.Drawing.Point(66, 206);
            this.lstGenerate.Name = "lstGenerate";
            this.lstGenerate.Size = new System.Drawing.Size(223, 508);
            this.lstGenerate.TabIndex = 3;
            // 
            // lstFilter
            // 
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.ItemHeight = 24;
            this.lstFilter.Location = new System.Drawing.Point(364, 206);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.Size = new System.Drawing.Size(223, 508);
            this.lstFilter.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 756);
            this.Controls.Add(this.lstFilter);
            this.Controls.Add(this.lstGenerate);
            this.Controls.Add(this.btnSelectLessThan);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnSelectLessThan;
        private System.Windows.Forms.ListBox lstGenerate;
        private System.Windows.Forms.ListBox lstFilter;
    }
}

