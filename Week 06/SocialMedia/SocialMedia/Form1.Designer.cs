﻿namespace SocialMedia
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tabFriend1 = new System.Windows.Forms.TabPage();
            this.tabFriend2 = new System.Windows.Forms.TabPage();
            this.tabFriend3 = new System.Windows.Forms.TabPage();
            this.tabFriend4 = new System.Windows.Forms.TabPage();
            this.listMainPage = new System.Windows.Forms.ListBox();
            this.tbStatusUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.listFriend1 = new System.Windows.Forms.ListBox();
            this.listFriend2 = new System.Windows.Forms.ListBox();
            this.listFriend3 = new System.Windows.Forms.ListBox();
            this.listFriend4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tabFriend1.SuspendLayout();
            this.tabFriend2.SuspendLayout();
            this.tabFriend3.SuspendLayout();
            this.tabFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabFriend1);
            this.tabControl1.Controls.Add(this.tabFriend2);
            this.tabControl1.Controls.Add(this.tabFriend3);
            this.tabControl1.Controls.Add(this.tabFriend4);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabMainPage.Controls.Add(this.btnUpdateStatus);
            this.tabMainPage.Controls.Add(this.tbStatusUpdate);
            this.tabMainPage.Controls.Add(this.listMainPage);
            this.tabMainPage.Location = new System.Drawing.Point(4, 31);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(728, 526);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            // 
            // tabFriend1
            // 
            this.tabFriend1.BackColor = System.Drawing.SystemColors.Control;
            this.tabFriend1.Controls.Add(this.listFriend1);
            this.tabFriend1.Location = new System.Drawing.Point(4, 31);
            this.tabFriend1.Name = "tabFriend1";
            this.tabFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriend1.Size = new System.Drawing.Size(728, 526);
            this.tabFriend1.TabIndex = 1;
            this.tabFriend1.Text = "Friend 1";
            // 
            // tabFriend2
            // 
            this.tabFriend2.BackColor = System.Drawing.SystemColors.Control;
            this.tabFriend2.Controls.Add(this.listFriend2);
            this.tabFriend2.Location = new System.Drawing.Point(4, 31);
            this.tabFriend2.Name = "tabFriend2";
            this.tabFriend2.Size = new System.Drawing.Size(728, 526);
            this.tabFriend2.TabIndex = 2;
            this.tabFriend2.Text = "Friend 2";
            // 
            // tabFriend3
            // 
            this.tabFriend3.BackColor = System.Drawing.SystemColors.Control;
            this.tabFriend3.Controls.Add(this.listFriend3);
            this.tabFriend3.Location = new System.Drawing.Point(4, 30);
            this.tabFriend3.Name = "tabFriend3";
            this.tabFriend3.Size = new System.Drawing.Size(728, 527);
            this.tabFriend3.TabIndex = 3;
            this.tabFriend3.Text = "Friend 3";
            // 
            // tabFriend4
            // 
            this.tabFriend4.BackColor = System.Drawing.SystemColors.Control;
            this.tabFriend4.Controls.Add(this.listFriend4);
            this.tabFriend4.Location = new System.Drawing.Point(4, 30);
            this.tabFriend4.Name = "tabFriend4";
            this.tabFriend4.Size = new System.Drawing.Size(728, 527);
            this.tabFriend4.TabIndex = 4;
            this.tabFriend4.Text = "Friend 4";
            // 
            // listMainPage
            // 
            this.listMainPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listMainPage.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMainPage.FormattingEnabled = true;
            this.listMainPage.ItemHeight = 33;
            this.listMainPage.Location = new System.Drawing.Point(46, 36);
            this.listMainPage.Name = "listMainPage";
            this.listMainPage.Size = new System.Drawing.Size(624, 367);
            this.listMainPage.TabIndex = 0;
            // 
            // tbStatusUpdate
            // 
            this.tbStatusUpdate.Location = new System.Drawing.Point(46, 445);
            this.tbStatusUpdate.Name = "tbStatusUpdate";
            this.tbStatusUpdate.Size = new System.Drawing.Size(469, 29);
            this.tbStatusUpdate.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(537, 445);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(133, 29);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // listFriend1
            // 
            this.listFriend1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFriend1.FormattingEnabled = true;
            this.listFriend1.ItemHeight = 23;
            this.listFriend1.Location = new System.Drawing.Point(52, 70);
            this.listFriend1.Name = "listFriend1";
            this.listFriend1.Size = new System.Drawing.Size(624, 372);
            this.listFriend1.TabIndex = 1;
            // 
            // listFriend2
            // 
            this.listFriend2.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFriend2.FormattingEnabled = true;
            this.listFriend2.ItemHeight = 34;
            this.listFriend2.Location = new System.Drawing.Point(52, 70);
            this.listFriend2.Name = "listFriend2";
            this.listFriend2.Size = new System.Drawing.Size(624, 378);
            this.listFriend2.TabIndex = 1;
            // 
            // listFriend3
            // 
            this.listFriend3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFriend3.FormattingEnabled = true;
            this.listFriend3.ItemHeight = 29;
            this.listFriend3.Location = new System.Drawing.Point(52, 70);
            this.listFriend3.Name = "listFriend3";
            this.listFriend3.Size = new System.Drawing.Size(624, 381);
            this.listFriend3.TabIndex = 1;
            // 
            // listFriend4
            // 
            this.listFriend4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFriend4.FormattingEnabled = true;
            this.listFriend4.ItemHeight = 25;
            this.listFriend4.Location = new System.Drawing.Point(52, 70);
            this.listFriend4.Name = "listFriend4";
            this.listFriend4.Size = new System.Drawing.Size(624, 379);
            this.listFriend4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Social Media Application";
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabMainPage.PerformLayout();
            this.tabFriend1.ResumeLayout(false);
            this.tabFriend2.ResumeLayout(false);
            this.tabFriend3.ResumeLayout(false);
            this.tabFriend4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TextBox tbStatusUpdate;
        private System.Windows.Forms.ListBox listMainPage;
        private System.Windows.Forms.TabPage tabFriend1;
        private System.Windows.Forms.ListBox listFriend1;
        private System.Windows.Forms.TabPage tabFriend2;
        private System.Windows.Forms.ListBox listFriend2;
        private System.Windows.Forms.TabPage tabFriend3;
        private System.Windows.Forms.ListBox listFriend3;
        private System.Windows.Forms.TabPage tabFriend4;
        private System.Windows.Forms.ListBox listFriend4;
    }
}

