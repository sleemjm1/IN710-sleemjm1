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
            this.dgShowBandMembers = new System.Windows.Forms.DataGridView();
            this.tbBandSearch = new System.Windows.Forms.TextBox();
            this.btnListBandMembers = new System.Windows.Forms.Button();
            this.Bands = new System.Windows.Forms.GroupBox();
            this.rbShowThisMonth = new System.Windows.Forms.RadioButton();
            this.rbShowHardRock = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbVenue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddGig = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowBandMembers)).BeginInit();
            this.Bands.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(141, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 278);
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
            this.btnShowAll.Location = new System.Drawing.Point(6, 91);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(108, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgShowBandMembers
            // 
            this.dgShowBandMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowBandMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Instrument,
            this.Role});
            this.dgShowBandMembers.Location = new System.Drawing.Point(248, 19);
            this.dgShowBandMembers.Name = "dgShowBandMembers";
            this.dgShowBandMembers.Size = new System.Drawing.Size(766, 215);
            this.dgShowBandMembers.TabIndex = 4;
            // 
            // tbBandSearch
            // 
            this.tbBandSearch.Location = new System.Drawing.Point(78, 18);
            this.tbBandSearch.Name = "tbBandSearch";
            this.tbBandSearch.Size = new System.Drawing.Size(144, 20);
            this.tbBandSearch.TabIndex = 5;
            // 
            // btnListBandMembers
            // 
            this.btnListBandMembers.Location = new System.Drawing.Point(114, 44);
            this.btnListBandMembers.Name = "btnListBandMembers";
            this.btnListBandMembers.Size = new System.Drawing.Size(108, 23);
            this.btnListBandMembers.TabIndex = 6;
            this.btnListBandMembers.Text = "List Band Members";
            this.btnListBandMembers.UseVisualStyleBackColor = true;
            this.btnListBandMembers.Click += new System.EventHandler(this.btnListBandMembers_Click);
            // 
            // Bands
            // 
            this.Bands.Controls.Add(this.rbShowThisMonth);
            this.Bands.Controls.Add(this.rbShowHardRock);
            this.Bands.Controls.Add(this.rbShowAll);
            this.Bands.Controls.Add(this.btnShowAll);
            this.Bands.Location = new System.Drawing.Point(15, 19);
            this.Bands.Name = "Bands";
            this.Bands.Size = new System.Drawing.Size(120, 123);
            this.Bands.TabIndex = 7;
            this.Bands.TabStop = false;
            this.Bands.Text = "Bands";
            // 
            // rbShowThisMonth
            // 
            this.rbShowThisMonth.AutoSize = true;
            this.rbShowThisMonth.Location = new System.Drawing.Point(6, 65);
            this.rbShowThisMonth.Name = "rbShowThisMonth";
            this.rbShowThisMonth.Size = new System.Drawing.Size(108, 17);
            this.rbShowThisMonth.TabIndex = 4;
            this.rbShowThisMonth.TabStop = true;
            this.rbShowThisMonth.Text = "Show This Month";
            this.rbShowThisMonth.UseVisualStyleBackColor = true;
            // 
            // rbShowHardRock
            // 
            this.rbShowHardRock.AutoSize = true;
            this.rbShowHardRock.Location = new System.Drawing.Point(7, 42);
            this.rbShowHardRock.Name = "rbShowHardRock";
            this.rbShowHardRock.Size = new System.Drawing.Size(107, 17);
            this.rbShowHardRock.TabIndex = 3;
            this.rbShowHardRock.TabStop = true;
            this.rbShowHardRock.Text = "Show Hard Rock";
            this.rbShowHardRock.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(7, 19);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(66, 17);
            this.rbShowAll.TabIndex = 2;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Bands);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 315);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Band Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBandSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnListBandMembers);
            this.groupBox2.Location = new System.Drawing.Point(14, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Band Members";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgShowBandMembers);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 262);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbVenue);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnAddGig);
            this.groupBox4.Controls.Add(this.tbTime);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.tbGenre);
            this.groupBox4.Controls.Add(this.tbName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(757, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 315);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add New Gig";
            // 
            // tbVenue
            // 
            this.tbVenue.Location = new System.Drawing.Point(69, 160);
            this.tbVenue.Name = "tbVenue";
            this.tbVenue.Size = new System.Drawing.Size(200, 20);
            this.tbVenue.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Venue:";
            // 
            // btnAddGig
            // 
            this.btnAddGig.Location = new System.Drawing.Point(194, 186);
            this.btnAddGig.Name = "btnAddGig";
            this.btnAddGig.Size = new System.Drawing.Size(75, 23);
            this.btnAddGig.TabIndex = 8;
            this.btnAddGig.Text = "Add Gig";
            this.btnAddGig.UseVisualStyleBackColor = true;
            this.btnAddGig.Click += new System.EventHandler(this.btnAddGig_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(69, 128);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(200, 20);
            this.tbTime.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(69, 62);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(200, 20);
            this.tbGenre.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(69, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
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
            this.Instrument.Width = 400;
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
            this.ClientSize = new System.Drawing.Size(1065, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pubs and Clubs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowBandMembers)).EndInit();
            this.Bands.ResumeLayout(false);
            this.Bands.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridView dgShowBandMembers;
        private System.Windows.Forms.TextBox tbBandSearch;
        private System.Windows.Forms.Button btnListBandMembers;
        private System.Windows.Forms.GroupBox Bands;
        private System.Windows.Forms.RadioButton rbShowThisMonth;
        private System.Windows.Forms.RadioButton rbShowHardRock;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddGig;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbVenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}

