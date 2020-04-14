namespace MovieSpitter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.MovieList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IMDBLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imdbTitleTxt = new System.Windows.Forms.TextBox();
            this.imdbYearTxt = new System.Windows.Forms.TextBox();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.ImdbSearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imdbListView = new System.Windows.Forms.ListView();
            this.imdbMovieId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imdbTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imdbYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocRatingBox = new System.Windows.Forms.TextBox();
            this.LocDirectorBox = new System.Windows.Forms.TextBox();
            this.LocYearBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.LocTitleBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.BackColor = System.Drawing.Color.LightGray;
            this.MovieList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Title,
            this.Year,
            this.Director,
            this.Rating,
            this.IMDBLink});
            this.MovieList.FullRowSelect = true;
            this.MovieList.GridLines = true;
            this.MovieList.HideSelection = false;
            this.MovieList.Location = new System.Drawing.Point(41, 304);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(609, 251);
            this.MovieList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MovieList.TabIndex = 0;
            this.MovieList.UseCompatibleStateImageBehavior = false;
            this.MovieList.View = System.Windows.Forms.View.Details;
            this.MovieList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MovieList_ColumnClick);
            this.MovieList.DoubleClick += new System.EventHandler(this.MovieList_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Movie Id";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.Width = 228;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year.Width = 78;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Director.Width = 178;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // IMDBLink
            // 
            this.IMDBLink.Text = "IMDBLink";
            // 
            // imdbTitleTxt
            // 
            this.imdbTitleTxt.Location = new System.Drawing.Point(41, 92);
            this.imdbTitleTxt.Name = "imdbTitleTxt";
            this.imdbTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.imdbTitleTxt.TabIndex = 1;
            this.imdbTitleTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imdbTitleTxt_KeyUp);
            // 
            // imdbYearTxt
            // 
            this.imdbYearTxt.Location = new System.Drawing.Point(169, 92);
            this.imdbYearTxt.Name = "imdbYearTxt";
            this.imdbYearTxt.Size = new System.Drawing.Size(100, 20);
            this.imdbYearTxt.TabIndex = 2;
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovieBtn.Location = new System.Drawing.Point(670, 118);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(105, 23);
            this.addMovieBtn.TabIndex = 6;
            this.addMovieBtn.Text = "Add New Movie";
            this.addMovieBtn.UseVisualStyleBackColor = false;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Peru;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(670, 532);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Movie watched";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // RandomBtn
            // 
            this.RandomBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.RandomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomBtn.Location = new System.Drawing.Point(670, 304);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(105, 48);
            this.RandomBtn.TabIndex = 8;
            this.RandomBtn.Text = "Get Random Suggestion";
            this.RandomBtn.UseVisualStyleBackColor = false;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // ImdbSearchBtn
            // 
            this.ImdbSearchBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ImdbSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImdbSearchBtn.Location = new System.Drawing.Point(670, 89);
            this.ImdbSearchBtn.Name = "ImdbSearchBtn";
            this.ImdbSearchBtn.Size = new System.Drawing.Size(105, 23);
            this.ImdbSearchBtn.TabIndex = 18;
            this.ImdbSearchBtn.Text = "Search IMDB";
            this.ImdbSearchBtn.UseVisualStyleBackColor = false;
            this.ImdbSearchBtn.Click += new System.EventHandler(this.ImdbSearchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(166, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(38, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Title";
            // 
            // imdbListView
            // 
            this.imdbListView.AutoArrange = false;
            this.imdbListView.BackColor = System.Drawing.Color.LightGray;
            this.imdbListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imdbListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imdbMovieId,
            this.imdbTitle,
            this.imdbYear});
            this.imdbListView.FullRowSelect = true;
            this.imdbListView.GridLines = true;
            this.imdbListView.HideSelection = false;
            this.imdbListView.Location = new System.Drawing.Point(41, 118);
            this.imdbListView.MultiSelect = false;
            this.imdbListView.Name = "imdbListView";
            this.imdbListView.Size = new System.Drawing.Size(609, 109);
            this.imdbListView.TabIndex = 23;
            this.imdbListView.UseCompatibleStateImageBehavior = false;
            this.imdbListView.View = System.Windows.Forms.View.Details;
            // 
            // imdbMovieId
            // 
            this.imdbMovieId.Text = "Movie Id";
            this.imdbMovieId.Width = 90;
            // 
            // imdbTitle
            // 
            this.imdbTitle.Text = "Title";
            this.imdbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imdbTitle.Width = 400;
            // 
            // imdbYear
            // 
            this.imdbYear.Text = "Year";
            this.imdbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imdbYear.Width = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(428, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(298, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(167, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Year";
            // 
            // LocRatingBox
            // 
            this.LocRatingBox.Location = new System.Drawing.Point(431, 278);
            this.LocRatingBox.Name = "LocRatingBox";
            this.LocRatingBox.Size = new System.Drawing.Size(100, 20);
            this.LocRatingBox.TabIndex = 29;
            // 
            // LocDirectorBox
            // 
            this.LocDirectorBox.Location = new System.Drawing.Point(301, 278);
            this.LocDirectorBox.Name = "LocDirectorBox";
            this.LocDirectorBox.Size = new System.Drawing.Size(100, 20);
            this.LocDirectorBox.TabIndex = 28;
            // 
            // LocYearBox
            // 
            this.LocYearBox.Location = new System.Drawing.Point(170, 278);
            this.LocYearBox.Name = "LocYearBox";
            this.LocYearBox.Size = new System.Drawing.Size(100, 20);
            this.LocYearBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(39, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Title";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(671, 275);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(105, 23);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Search Local";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // LocTitleBox
            // 
            this.LocTitleBox.Location = new System.Drawing.Point(42, 278);
            this.LocTitleBox.Name = "LocTitleBox";
            this.LocTitleBox.Size = new System.Drawing.Size(100, 20);
            this.LocTitleBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 42);
            this.label5.TabIndex = 33;
            this.label5.Text = "Movie Roulette";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(813, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocRatingBox);
            this.Controls.Add(this.LocDirectorBox);
            this.Controls.Add(this.LocYearBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.LocTitleBox);
            this.Controls.Add(this.imdbListView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ImdbSearchBtn);
            this.Controls.Add(this.RandomBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(this.imdbYearTxt);
            this.Controls.Add(this.imdbTitleTxt);
            this.Controls.Add(this.MovieList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MovieRoulette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MovieList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.TextBox imdbTitleTxt;
        private System.Windows.Forms.TextBox imdbYearTxt;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Button ImdbSearchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView imdbListView;
        private System.Windows.Forms.ColumnHeader imdbMovieId;
        private System.Windows.Forms.ColumnHeader imdbTitle;
        private System.Windows.Forms.ColumnHeader imdbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocRatingBox;
        private System.Windows.Forms.TextBox LocDirectorBox;
        private System.Windows.Forms.TextBox LocYearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox LocTitleBox;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader IMDBLink;
        private System.Windows.Forms.Label label5;
    }
}

