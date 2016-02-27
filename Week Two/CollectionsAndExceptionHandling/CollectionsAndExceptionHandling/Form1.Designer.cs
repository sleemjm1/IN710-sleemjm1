namespace CollectionsAndExceptionHandling
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.tbAddYear = new System.Windows.Forms.TextBox();
            this.tbAddDirector = new System.Windows.Forms.TextBox();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.tbSearchDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listAllMovies = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(294, 148);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(111, 31);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(213, 268);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(111, 31);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(85, 268);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(418, 268);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(111, 31);
            this.btnPrintAll.TabIndex = 3;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // tbAddYear
            // 
            this.tbAddYear.Location = new System.Drawing.Point(85, 29);
            this.tbAddYear.Name = "tbAddYear";
            this.tbAddYear.Size = new System.Drawing.Size(579, 22);
            this.tbAddYear.TabIndex = 4;
            // 
            // tbAddDirector
            // 
            this.tbAddDirector.Location = new System.Drawing.Point(85, 67);
            this.tbAddDirector.Name = "tbAddDirector";
            this.tbAddDirector.Size = new System.Drawing.Size(579, 22);
            this.tbAddDirector.TabIndex = 5;
            // 
            // tbAddTitle
            // 
            this.tbAddTitle.Location = new System.Drawing.Point(85, 106);
            this.tbAddTitle.Name = "tbAddTitle";
            this.tbAddTitle.Size = new System.Drawing.Size(579, 22);
            this.tbAddTitle.TabIndex = 6;
            // 
            // tbSearchDelete
            // 
            this.tbSearchDelete.Location = new System.Drawing.Point(85, 225);
            this.tbSearchDelete.Name = "tbSearchDelete";
            this.tbSearchDelete.Size = new System.Drawing.Size(579, 22);
            this.tbSearchDelete.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 14;
            // 
            // listAllMovies
            // 
            this.listAllMovies.FormattingEnabled = true;
            this.listAllMovies.ItemHeight = 16;
            this.listAllMovies.Location = new System.Drawing.Point(85, 322);
            this.listAllMovies.Name = "listAllMovies";
            this.listAllMovies.Size = new System.Drawing.Size(579, 180);
            this.listAllMovies.TabIndex = 15;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(553, 268);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(111, 31);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Sort Movis";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 573);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.listAllMovies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchDelete);
            this.Controls.Add(this.tbAddTitle);
            this.Controls.Add(this.tbAddDirector);
            this.Controls.Add(this.tbAddYear);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.TextBox tbAddYear;
        private System.Windows.Forms.TextBox tbAddDirector;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.TextBox tbSearchDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listAllMovies;
        private System.Windows.Forms.Button btnSort;
    }
}

