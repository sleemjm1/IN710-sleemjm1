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
            this.btnMakeCharacter = new System.Windows.Forms.Button();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbTorso = new System.Windows.Forms.ComboBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(39, 40);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(300, 200);
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // pbTorso
            // 
            this.pbTorso.Location = new System.Drawing.Point(39, 239);
            this.pbTorso.Name = "pbTorso";
            this.pbTorso.Size = new System.Drawing.Size(300, 200);
            this.pbTorso.TabIndex = 1;
            this.pbTorso.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(40, 438);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(300, 200);
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            // 
            // btnMakeCharacter
            // 
            this.btnMakeCharacter.Location = new System.Drawing.Point(423, 217);
            this.btnMakeCharacter.Name = "btnMakeCharacter";
            this.btnMakeCharacter.Size = new System.Drawing.Size(187, 23);
            this.btnMakeCharacter.TabIndex = 3;
            this.btnMakeCharacter.Text = "Make Character";
            this.btnMakeCharacter.UseVisualStyleBackColor = true;
            this.btnMakeCharacter.Click += new System.EventHandler(this.btnMakeCharacter_Click);
            // 
            // cbHead
            // 
            this.cbHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(457, 40);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(153, 21);
            this.cbHead.TabIndex = 4;
            // 
            // cbTorso
            // 
            this.cbTorso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTorso.FormattingEnabled = true;
            this.cbTorso.Location = new System.Drawing.Point(457, 83);
            this.cbTorso.Name = "cbTorso";
            this.cbTorso.Size = new System.Drawing.Size(153, 21);
            this.cbTorso.TabIndex = 5;
            // 
            // cbLegs
            // 
            this.cbLegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Location = new System.Drawing.Point(457, 128);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(153, 21);
            this.cbLegs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Head:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Legs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Torso:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 742);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLegs);
            this.Controls.Add(this.cbTorso);
            this.Controls.Add(this.cbHead);
            this.Controls.Add(this.btnMakeCharacter);
            this.Controls.Add(this.pbLegs);
            this.Controls.Add(this.pbTorso);
            this.Controls.Add(this.pbHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbTorso;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.Button btnMakeCharacter;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbTorso;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

