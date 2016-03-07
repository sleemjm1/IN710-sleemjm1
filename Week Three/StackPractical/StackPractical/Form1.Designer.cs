namespace StackPractical
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
            this.txtPush = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtPeek = new System.Windows.Forms.TextBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnIsEmpty = new System.Windows.Forms.Button();
            this.txtIsEmpty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPush
            // 
            this.txtPush.Location = new System.Drawing.Point(200, 35);
            this.txtPush.Name = "txtPush";
            this.txtPush.Size = new System.Drawing.Size(224, 22);
            this.txtPush.TabIndex = 1;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(455, 33);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(455, 77);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 3;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(200, 77);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(224, 22);
            this.txtPop.TabIndex = 4;
            // 
            // txtPeek
            // 
            this.txtPeek.Location = new System.Drawing.Point(200, 118);
            this.txtPeek.Name = "txtPeek";
            this.txtPeek.Size = new System.Drawing.Size(224, 22);
            this.txtPeek.TabIndex = 5;
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(455, 117);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 23);
            this.btnPeek.TabIndex = 6;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(455, 158);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(200, 159);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(224, 22);
            this.txtCount.TabIndex = 8;
            // 
            // btnIsEmpty
            // 
            this.btnIsEmpty.Location = new System.Drawing.Point(455, 199);
            this.btnIsEmpty.Name = "btnIsEmpty";
            this.btnIsEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnIsEmpty.TabIndex = 9;
            this.btnIsEmpty.Text = "IsEmpty";
            this.btnIsEmpty.UseVisualStyleBackColor = true;
            this.btnIsEmpty.Click += new System.EventHandler(this.btnIsEmpty_Click);
            // 
            // txtIsEmpty
            // 
            this.txtIsEmpty.Location = new System.Drawing.Point(200, 200);
            this.txtIsEmpty.Name = "txtIsEmpty";
            this.txtIsEmpty.Size = new System.Drawing.Size(224, 22);
            this.txtIsEmpty.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.Controls.Add(this.txtIsEmpty);
            this.Controls.Add(this.btnIsEmpty);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.txtPeek);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtPush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPush;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtPeek;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnIsEmpty;
        private System.Windows.Forms.TextBox txtIsEmpty;
    }
}

