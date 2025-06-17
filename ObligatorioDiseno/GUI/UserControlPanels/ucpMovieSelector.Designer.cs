namespace GUI.UserControlPanels
{
    partial class ucpMovieSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnChangeProfile = new System.Windows.Forms.Button();
            this.btnSortSponsored = new System.Windows.Forms.Button();
            this.btnSortByGenre = new System.Windows.Forms.Button();
            this.btnSortByScore = new System.Windows.Forms.Button();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchByYear = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.rbDirector = new System.Windows.Forms.RadioButton();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.gbSorting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(32, 26);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersWidth = 62;
            this.dgvMovies.RowTemplate.Height = 100;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(886, 495);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // btnChangeProfile
            // 
            this.btnChangeProfile.Location = new System.Drawing.Point(732, 669);
            this.btnChangeProfile.Name = "btnChangeProfile";
            this.btnChangeProfile.Size = new System.Drawing.Size(180, 33);
            this.btnChangeProfile.TabIndex = 1;
            this.btnChangeProfile.Text = "Change profile";
            this.btnChangeProfile.UseVisualStyleBackColor = true;
            this.btnChangeProfile.Click += new System.EventHandler(this.btnChangeProfile_Click);
            // 
            // btnSortSponsored
            // 
            this.btnSortSponsored.Location = new System.Drawing.Point(6, 25);
            this.btnSortSponsored.Name = "btnSortSponsored";
            this.btnSortSponsored.Size = new System.Drawing.Size(168, 33);
            this.btnSortSponsored.TabIndex = 5;
            this.btnSortSponsored.Text = "Sponsored";
            this.btnSortSponsored.UseVisualStyleBackColor = true;
            this.btnSortSponsored.Click += new System.EventHandler(this.btnSortSponsored_Click);
            // 
            // btnSortByGenre
            // 
            this.btnSortByGenre.Location = new System.Drawing.Point(6, 64);
            this.btnSortByGenre.Name = "btnSortByGenre";
            this.btnSortByGenre.Size = new System.Drawing.Size(168, 33);
            this.btnSortByGenre.TabIndex = 4;
            this.btnSortByGenre.Text = "Genre";
            this.btnSortByGenre.UseVisualStyleBackColor = true;
            this.btnSortByGenre.Click += new System.EventHandler(this.btnSortByGenre_Click);
            // 
            // btnSortByScore
            // 
            this.btnSortByScore.Location = new System.Drawing.Point(6, 103);
            this.btnSortByScore.Name = "btnSortByScore";
            this.btnSortByScore.Size = new System.Drawing.Size(168, 33);
            this.btnSortByScore.TabIndex = 3;
            this.btnSortByScore.Text = "Score";
            this.btnSortByScore.UseVisualStyleBackColor = true;
            this.btnSortByScore.Click += new System.EventHandler(this.btnSortByScore_Click);
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.btnSortSponsored);
            this.gbSorting.Controls.Add(this.btnSortByScore);
            this.gbSorting.Controls.Add(this.btnSortByGenre);
            this.gbSorting.Location = new System.Drawing.Point(26, 557);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(180, 145);
            this.gbSorting.TabIndex = 6;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Sort by:";
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteProfile.Location = new System.Drawing.Point(732, 630);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(180, 33);
            this.btnDeleteProfile.TabIndex = 7;
            this.btnDeleteProfile.Text = "Delete profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(519, 666);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(168, 33);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "View History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchByYear);
            this.groupBox1.Controls.Add(this.btnSearchByName);
            this.groupBox1.Controls.Add(this.rbDirector);
            this.groupBox1.Controls.Add(this.rbActor);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(212, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // btnSearchByYear
            // 
            this.btnSearchByYear.Location = new System.Drawing.Point(168, 99);
            this.btnSearchByYear.Name = "btnSearchByYear";
            this.btnSearchByYear.Size = new System.Drawing.Size(122, 37);
            this.btnSearchByYear.TabIndex = 12;
            this.btnSearchByYear.Text = "Chronological";
            this.btnSearchByYear.UseVisualStyleBackColor = true;
            this.btnSearchByYear.Click += new System.EventHandler(this.btnSearchByYear_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(168, 57);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(122, 37);
            this.btnSearchByName.TabIndex = 11;
            this.btnSearchByName.Text = "Alphabetical";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // rbDirector
            // 
            this.rbDirector.AutoSize = true;
            this.rbDirector.Location = new System.Drawing.Point(6, 87);
            this.rbDirector.Name = "rbDirector";
            this.rbDirector.Size = new System.Drawing.Size(75, 20);
            this.rbDirector.TabIndex = 10;
            this.rbDirector.TabStop = true;
            this.rbDirector.Text = "Director";
            this.rbDirector.UseVisualStyleBackColor = true;
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(6, 57);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(59, 20);
            this.rbActor.TabIndex = 9;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInstruction.Location = new System.Drawing.Point(214, 534);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(215, 16);
            this.lblInstruction.TabIndex = 9;
            this.lblInstruction.Text = "To search by multiples use spaces";
            // 
            // ucpMovieSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.gbSorting);
            this.Controls.Add(this.btnChangeProfile);
            this.Controls.Add(this.dgvMovies);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpMovieSelector";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.gbSorting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnChangeProfile;
        private System.Windows.Forms.Button btnSortSponsored;
        private System.Windows.Forms.Button btnSortByGenre;
        private System.Windows.Forms.Button btnSortByScore;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.RadioButton rbDirector;
        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchByYear;
        private System.Windows.Forms.Label lblInstruction;
    }
}
