namespace GUI.UserControlPanels
{
    partial class ucpEditMovie
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.gbMovies = new System.Windows.Forms.GroupBox();
            this.btnEditRoles = new System.Windows.Forms.Button();
            this.cbRatedGA = new System.Windows.Forms.CheckBox();
            this.cbIsSponsored = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(732, 669);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(180, 33);
            this.btnAdminMenu.TabIndex = 2;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // gbMovies
            // 
            this.gbMovies.Controls.Add(this.txtYear);
            this.gbMovies.Controls.Add(this.label8);
            this.gbMovies.Controls.Add(this.btnEditRoles);
            this.gbMovies.Controls.Add(this.cbRatedGA);
            this.gbMovies.Controls.Add(this.cbIsSponsored);
            this.gbMovies.Controls.Add(this.label3);
            this.gbMovies.Controls.Add(this.cbGenre);
            this.gbMovies.Controls.Add(this.txtDescription);
            this.gbMovies.Controls.Add(this.label2);
            this.gbMovies.Controls.Add(this.txtName);
            this.gbMovies.Controls.Add(this.label1);
            this.gbMovies.Controls.Add(this.cbMovie);
            this.gbMovies.Controls.Add(this.btnSave);
            this.gbMovies.Location = new System.Drawing.Point(157, 108);
            this.gbMovies.Name = "gbMovies";
            this.gbMovies.Size = new System.Drawing.Size(476, 483);
            this.gbMovies.TabIndex = 7;
            this.gbMovies.TabStop = false;
            this.gbMovies.Text = "Movies";
            // 
            // btnEditRoles
            // 
            this.btnEditRoles.Location = new System.Drawing.Point(188, 420);
            this.btnEditRoles.Name = "btnEditRoles";
            this.btnEditRoles.Size = new System.Drawing.Size(129, 39);
            this.btnEditRoles.TabIndex = 18;
            this.btnEditRoles.Text = "Edit roles";
            this.btnEditRoles.UseVisualStyleBackColor = true;
            this.btnEditRoles.Click += new System.EventHandler(this.btnEditRoles_Click);
            // 
            // cbRatedGA
            // 
            this.cbRatedGA.AutoSize = true;
            this.cbRatedGA.Location = new System.Drawing.Point(162, 380);
            this.cbRatedGA.Name = "cbRatedGA";
            this.cbRatedGA.Size = new System.Drawing.Size(242, 24);
            this.cbRatedGA.TabIndex = 17;
            this.cbRatedGA.Text = "Rated for General Audiences";
            this.cbRatedGA.UseVisualStyleBackColor = true;
            // 
            // cbIsSponsored
            // 
            this.cbIsSponsored.AutoSize = true;
            this.cbIsSponsored.Location = new System.Drawing.Point(26, 380);
            this.cbIsSponsored.Name = "cbIsSponsored";
            this.cbIsSponsored.Size = new System.Drawing.Size(113, 24);
            this.cbIsSponsored.TabIndex = 16;
            this.cbIsSponsored.Text = "Sponsored";
            this.cbIsSponsored.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(26, 256);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(426, 28);
            this.cbGenre.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(426, 26);
            this.txtDescription.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 26);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // cbMovie
            // 
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(25, 34);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(426, 28);
            this.cbMovie.TabIndex = 8;
            this.cbMovie.SelectedIndexChanged += new System.EventHandler(this.cbMovie_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(664, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 72);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Movie";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(25, 329);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(426, 26);
            this.txtYear.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Release Year:";
            // 
            // ucpEditMovie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbMovies);
            this.Controls.Add(this.btnAdminMenu);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpEditMovie";
            this.Size = new System.Drawing.Size(954, 720);
            this.gbMovies.ResumeLayout(false);
            this.gbMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.GroupBox gbMovies;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbRatedGA;
        private System.Windows.Forms.CheckBox cbIsSponsored;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button btnEditRoles;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
    }
}
