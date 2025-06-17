namespace GUI.UserControlPanels
{
    partial class ucpEditGenre
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbMovies = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(664, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 72);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove Genre";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbMovies
            // 
            this.gbMovies.Controls.Add(this.txtDescription);
            this.gbMovies.Controls.Add(this.label2);
            this.gbMovies.Controls.Add(this.txtName);
            this.gbMovies.Controls.Add(this.label1);
            this.gbMovies.Controls.Add(this.cbGenre);
            this.gbMovies.Controls.Add(this.btnSave);
            this.gbMovies.Location = new System.Drawing.Point(157, 108);
            this.gbMovies.Name = "gbMovies";
            this.gbMovies.Size = new System.Drawing.Size(476, 294);
            this.gbMovies.TabIndex = 11;
            this.gbMovies.TabStop = false;
            this.gbMovies.Text = "Genres";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(426, 22);
            this.txtDescription.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 22);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(25, 34);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(426, 24);
            this.cbGenre.TabIndex = 8;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbMovie_SelectedIndexChanged);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(732, 669);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(180, 33);
            this.btnAdminMenu.TabIndex = 10;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucpEditGenre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbMovies);
            this.Controls.Add(this.btnAdminMenu);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpEditGenre";
            this.Size = new System.Drawing.Size(954, 720);
            this.gbMovies.ResumeLayout(false);
            this.gbMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbMovies;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.Button btnSave;
    }
}
