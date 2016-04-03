namespace ScorerDelegate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.rbChildren = new System.Windows.Forms.RadioButton();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.txtIncorrect = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChildren);
            this.groupBox1.Controls.Add(this.rbAdult);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Type";
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(19, 41);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(49, 17);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // rbChildren
            // 
            this.rbChildren.AutoSize = true;
            this.rbChildren.Location = new System.Drawing.Point(19, 90);
            this.rbChildren.Name = "rbChildren";
            this.rbChildren.Size = new System.Drawing.Size(63, 17);
            this.rbChildren.TabIndex = 1;
            this.rbChildren.TabStop = true;
            this.rbChildren.Text = "Children";
            this.rbChildren.UseVisualStyleBackColor = true;
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(227, 41);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtCorrect.TabIndex = 1;
            // 
            // txtIncorrect
            // 
            this.txtIncorrect.Location = new System.Drawing.Point(227, 78);
            this.txtIncorrect.Name = "txtIncorrect";
            this.txtIncorrect.Size = new System.Drawing.Size(100, 20);
            this.txtIncorrect.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(149, 192);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 33);
            this.lblScore.TabIndex = 3;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(202, 147);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(125, 23);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute Score";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incorrect:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtIncorrect);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Scorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChildren;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.TextBox txtIncorrect;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

