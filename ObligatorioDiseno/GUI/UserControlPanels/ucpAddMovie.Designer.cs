namespace GUI.UserControlPanels
{
    partial class ucpAddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIsSponsored = new System.Windows.Forms.CheckBox();
            this.cbRatedGA = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.fdPoster = new System.Windows.Forms.OpenFileDialog();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.btnAddPoster = new System.Windows.Forms.Button();
            this.dgvSecondaryGenres = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 164);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(426, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(796, 630);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 64);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(106, 227);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(426, 28);
            this.cbGenre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre:";
            // 
            // cbIsSponsored
            // 
            this.cbIsSponsored.AutoSize = true;
            this.cbIsSponsored.Location = new System.Drawing.Point(106, 340);
            this.cbIsSponsored.Name = "cbIsSponsored";
            this.cbIsSponsored.Size = new System.Drawing.Size(113, 24);
            this.cbIsSponsored.TabIndex = 8;
            this.cbIsSponsored.Text = "Sponsored";
            this.cbIsSponsored.UseVisualStyleBackColor = true;
            // 
            // cbRatedGA
            // 
            this.cbRatedGA.AutoSize = true;
            this.cbRatedGA.Location = new System.Drawing.Point(290, 340);
            this.cbRatedGA.Name = "cbRatedGA";
            this.cbRatedGA.Size = new System.Drawing.Size(242, 24);
            this.cbRatedGA.TabIndex = 9;
            this.cbRatedGA.Text = "Rated for General Audiences";
            this.cbRatedGA.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(659, 630);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 64);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Add Movie";
            // 
            // fdPoster
            // 
            this.fdPoster.FileName = "fdPoster";
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(659, 75);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(168, 213);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 11;
            this.pbPoster.TabStop = false;
            // 
            // btnAddPoster
            // 
            this.btnAddPoster.Location = new System.Drawing.Point(671, 294);
            this.btnAddPoster.Name = "btnAddPoster";
            this.btnAddPoster.Size = new System.Drawing.Size(145, 41);
            this.btnAddPoster.TabIndex = 12;
            this.btnAddPoster.Text = "Select poster";
            this.btnAddPoster.UseVisualStyleBackColor = true;
            this.btnAddPoster.Click += new System.EventHandler(this.btnAddPoster_Click);
            // 
            // dgvSecondaryGenres
            // 
            this.dgvSecondaryGenres.AllowUserToAddRows = false;
            this.dgvSecondaryGenres.AllowUserToDeleteRows = false;
            this.dgvSecondaryGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecondaryGenres.Location = new System.Drawing.Point(38, 418);
            this.dgvSecondaryGenres.Name = "dgvSecondaryGenres";
            this.dgvSecondaryGenres.RowHeadersWidth = 62;
            this.dgvSecondaryGenres.RowTemplate.Height = 28;
            this.dgvSecondaryGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecondaryGenres.Size = new System.Drawing.Size(270, 164);
            this.dgvSecondaryGenres.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Secondary genres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "*(Use CTRL key to select multiples)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Directors:";
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.AllowUserToAddRows = false;
            this.dgvDirectors.AllowUserToDeleteRows = false;
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(332, 418);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.RowHeadersWidth = 62;
            this.dgvDirectors.RowTemplate.Height = 28;
            this.dgvDirectors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectors.Size = new System.Drawing.Size(277, 164);
            this.dgvDirectors.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Actors:";
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(634, 418);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.RowHeadersWidth = 62;
            this.dgvActors.RowTemplate.Height = 28;
            this.dgvActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActors.Size = new System.Drawing.Size(276, 164);
            this.dgvActors.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(106, 291);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(426, 26);
            this.txtYear.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Release Year:";
            // 
            // ucpAddMovie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvActors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDirectors);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSecondaryGenres);
            this.Controls.Add(this.btnAddPoster);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbRatedGA);
            this.Controls.Add(this.cbIsSponsored);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpAddMovie";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsSponsored;
        private System.Windows.Forms.CheckBox cbRatedGA;
        private System.Windows.Forms.Button btnReturn;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.OpenFileDialog fdPoster;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnAddPoster;
        private System.Windows.Forms.DataGridView dgvSecondaryGenres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
    }
}
