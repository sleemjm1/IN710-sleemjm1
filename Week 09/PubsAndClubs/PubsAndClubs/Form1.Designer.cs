namespace PubsAndClubs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnHardRock = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.dgShowBandMembers = new System.Windows.Forms.DataGridView();
            this.tbBandSearch = new System.Windows.Forms.TextBox();
            this.btnListBandMembers = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowBandMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.BandName,
            this.Genre,
            this.Venue});
            this.dataGridView1.Location = new System.Drawing.Point(23, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // BandName
            // 
            this.BandName.HeaderText = "Band Name";
            this.BandName.Name = "BandName";
            this.BandName.Width = 150;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.Width = 150;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(23, 22);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnHardRock
            // 
            this.btnHardRock.Location = new System.Drawing.Point(23, 51);
            this.btnHardRock.Name = "btnHardRock";
            this.btnHardRock.Size = new System.Drawing.Size(98, 23);
            this.btnHardRock.TabIndex = 2;
            this.btnHardRock.Text = "Show Hard Rock";
            this.btnHardRock.UseVisualStyleBackColor = true;
            this.btnHardRock.Click += new System.EventHandler(this.btnHardRock_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(195, 22);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(106, 23);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "Show This Month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // dgShowBandMembers
            // 
            this.dgShowBandMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowBandMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Instrument,
            this.Role});
            this.dgShowBandMembers.Location = new System.Drawing.Point(604, 105);
            this.dgShowBandMembers.Name = "dgShowBandMembers";
            this.dgShowBandMembers.Size = new System.Drawing.Size(440, 453);
            this.dgShowBandMembers.TabIndex = 4;
            // 
            // tbBandSearch
            // 
            this.tbBandSearch.Location = new System.Drawing.Point(768, 40);
            this.tbBandSearch.Name = "tbBandSearch";
            this.tbBandSearch.Size = new System.Drawing.Size(100, 20);
            this.tbBandSearch.TabIndex = 5;
            // 
            // btnListBandMembers
            // 
            this.btnListBandMembers.Location = new System.Drawing.Point(743, 66);
            this.btnListBandMembers.Name = "btnListBandMembers";
            this.btnListBandMembers.Size = new System.Drawing.Size(161, 23);
            this.btnListBandMembers.TabIndex = 6;
            this.btnListBandMembers.Text = "List Band Members";
            this.btnListBandMembers.UseVisualStyleBackColor = true;
            this.btnListBandMembers.Click += new System.EventHandler(this.btnListBandMembers_Click);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Instrument
            // 
            this.Instrument.HeaderText = "Instrument(s)";
            this.Instrument.Name = "Instrument";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 570);
            this.Controls.Add(this.btnListBandMembers);
            this.Controls.Add(this.tbBandSearch);
            this.Controls.Add(this.dgShowBandMembers);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnHardRock);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowBandMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.Button btnHardRock;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.DataGridView dgShowBandMembers;
        private System.Windows.Forms.TextBox tbBandSearch;
        private System.Windows.Forms.Button btnListBandMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}

