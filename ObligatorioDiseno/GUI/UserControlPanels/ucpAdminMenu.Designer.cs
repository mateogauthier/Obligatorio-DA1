namespace GUI.UserControlPanels
{
    partial class ucpAdminMenu
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
            this.gbMovies = new System.Windows.Forms.GroupBox();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.gbGenres = new System.Windows.Forms.GroupBox();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.gbMovies.SuspendLayout();
            this.gbGenres.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMovies
            // 
            this.gbMovies.Controls.Add(this.btnEditMovie);
            this.gbMovies.Controls.Add(this.btnAddMovie);
            this.gbMovies.Location = new System.Drawing.Point(125, 96);
            this.gbMovies.Name = "gbMovies";
            this.gbMovies.Size = new System.Drawing.Size(141, 154);
            this.gbMovies.TabIndex = 0;
            this.gbMovies.TabStop = false;
            this.gbMovies.Text = "Movies";
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Location = new System.Drawing.Point(6, 86);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(129, 55);
            this.btnEditMovie.TabIndex = 2;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(6, 25);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(129, 55);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // gbGenres
            // 
            this.gbGenres.Controls.Add(this.btnEditGenre);
            this.gbGenres.Controls.Add(this.btnAddGenre);
            this.gbGenres.Location = new System.Drawing.Point(316, 96);
            this.gbGenres.Name = "gbGenres";
            this.gbGenres.Size = new System.Drawing.Size(141, 154);
            this.gbGenres.TabIndex = 1;
            this.gbGenres.TabStop = false;
            this.gbGenres.Text = "Genres";
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Location = new System.Drawing.Point(6, 86);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(129, 55);
            this.btnEditGenre.TabIndex = 2;
            this.btnEditGenre.Text = "Edit";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(6, 25);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(129, 55);
            this.btnAddGenre.TabIndex = 1;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(798, 642);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 55);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Admin Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditPerson);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Location = new System.Drawing.Point(509, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(6, 86);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(129, 55);
            this.btnEditPerson.TabIndex = 2;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(6, 25);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(129, 55);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ucpAdminMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbGenres);
            this.Controls.Add(this.gbMovies);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpAdminMenu";
            this.Size = new System.Drawing.Size(954, 720);
            this.gbMovies.ResumeLayout(false);
            this.gbGenres.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMovies;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.GroupBox gbGenres;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnAddPerson;
    }
}
