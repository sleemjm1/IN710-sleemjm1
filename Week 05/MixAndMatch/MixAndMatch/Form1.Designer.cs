namespace MixAndMatch
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
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbTorso = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbTorso = new System.Windows.Forms.ComboBox();
            this.tbLegs = new System.Windows.Forms.ComboBox();
            this.btnMakeCharacter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(32, 32);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(270, 200);
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // pbTorso
            // 
            this.pbTorso.Location = new System.Drawing.Point(32, 232);
            this.pbTorso.Name = "pbTorso";
            this.pbTorso.Size = new System.Drawing.Size(270, 200);
            this.pbTorso.TabIndex = 1;
            this.pbTorso.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(32, 432);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(270, 200);
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            // 
            // cbHead
            // 
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(419, 32);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(205, 24);
            this.cbHead.TabIndex = 3;
            // 
            // cbTorso
            // 
            this.cbTorso.FormattingEnabled = true;
            this.cbTorso.Location = new System.Drawing.Point(419, 86);
            this.cbTorso.Name = "cbTorso";
            this.cbTorso.Size = new System.Drawing.Size(205, 24);
            this.cbTorso.TabIndex = 4;
            // 
            // tbLegs
            // 
            this.tbLegs.FormattingEnabled = true;
            this.tbLegs.Location = new System.Drawing.Point(419, 139);
            this.tbLegs.Name = "tbLegs";
            this.tbLegs.Size = new System.Drawing.Size(205, 24);
            this.tbLegs.TabIndex = 5;
            // 
            // btnMakeCharacter
            // 
            this.btnMakeCharacter.Location = new System.Drawing.Point(419, 195);
            this.btnMakeCharacter.Name = "btnMakeCharacter";
            this.btnMakeCharacter.Size = new System.Drawing.Size(205, 23);
            this.btnMakeCharacter.TabIndex = 6;
            this.btnMakeCharacter.Text = "Make Character";
            this.btnMakeCharacter.UseVisualStyleBackColor = true;
            this.btnMakeCharacter.Click += new System.EventHandler(this.btnMakeCharacter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 705);
            this.Controls.Add(this.btnMakeCharacter);
            this.Controls.Add(this.tbLegs);
            this.Controls.Add(this.cbTorso);
            this.Controls.Add(this.cbHead);
            this.Controls.Add(this.pbLegs);
            this.Controls.Add(this.pbTorso);
            this.Controls.Add(this.pbHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbTorso;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbTorso;
        private System.Windows.Forms.ComboBox tbLegs;
        private System.Windows.Forms.Button btnMakeCharacter;
    }
}

