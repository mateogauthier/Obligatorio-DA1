namespace GUI.UserControlPanels
{
    partial class ucpEditPerson
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
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(679, 327);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(145, 41);
            this.btnAddPhoto.TabIndex = 18;
            this.btnAddPhoto.Text = "Select photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(669, 108);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(168, 213);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 17;
            this.pbPhoto.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(680, 418);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 72);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Person";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.txtBirthdate);
            this.gbPerson.Controls.Add(this.label2);
            this.gbPerson.Controls.Add(this.txtName);
            this.gbPerson.Controls.Add(this.label1);
            this.gbPerson.Controls.Add(this.cbPerson);
            this.gbPerson.Controls.Add(this.btnSave);
            this.gbPerson.Location = new System.Drawing.Point(157, 108);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(476, 286);
            this.gbPerson.TabIndex = 15;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(26, 181);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(426, 22);
            this.txtBirthdate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Birthdate:";
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
            // cbPerson
            // 
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(25, 34);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(426, 24);
            this.cbPerson.TabIndex = 8;
            this.cbPerson.SelectedIndexChanged += new System.EventHandler(this.cbPerson_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 233);
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
            this.btnAdminMenu.TabIndex = 19;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // ucpEditPerson
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbPerson);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpEditPerson";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdminMenu;
    }
}
