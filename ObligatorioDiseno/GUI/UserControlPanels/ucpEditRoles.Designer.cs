namespace GUI.UserControlPanels
{
    partial class ucpEditRoles
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
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbActors = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.gbRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(664, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 72);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Role";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.label2);
            this.gbRoles.Controls.Add(this.cbRoles);
            this.gbRoles.Controls.Add(this.txtMovie);
            this.gbRoles.Controls.Add(this.label1);
            this.gbRoles.Controls.Add(this.cbActors);
            this.gbRoles.Controls.Add(this.btnSave);
            this.gbRoles.Location = new System.Drawing.Point(157, 108);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Size = new System.Drawing.Size(476, 281);
            this.gbRoles.TabIndex = 13;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Role:";
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(25, 101);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(426, 24);
            this.cbRoles.TabIndex = 13;
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            // 
            // txtMovie
            // 
            this.txtMovie.Enabled = false;
            this.txtMovie.Location = new System.Drawing.Point(25, 35);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(426, 22);
            this.txtMovie.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actor:";
            // 
            // cbActors
            // 
            this.cbActors.FormattingEnabled = true;
            this.cbActors.Location = new System.Drawing.Point(25, 171);
            this.cbActors.Name = "cbActors";
            this.cbActors.Size = new System.Drawing.Size(426, 24);
            this.cbActors.TabIndex = 8;
            this.cbActors.SelectedIndexChanged += new System.EventHandler(this.cbActors_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(732, 669);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(180, 33);
            this.btnAdminMenu.TabIndex = 15;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // ucpEditRoles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbRoles);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpEditRoles";
            this.Size = new System.Drawing.Size(954, 720);
            this.gbRoles.ResumeLayout(false);
            this.gbRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbActors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnAdminMenu;
    }
}
