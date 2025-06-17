namespace GUI.UserControlPanels
{
    partial class ucpAddPerson
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
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Add Person";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(671, 326);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(145, 41);
            this.btnAddPicture.TabIndex = 23;
            this.btnAddPicture.Text = "Select poster";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(659, 107);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(168, 213);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 22;
            this.pbPicture.TabStop = false;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(141, 255);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(426, 22);
            this.txtBirthdate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Birthdate:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 22);
            this.txtName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(656, 628);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 64);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(793, 628);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 64);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucpAddPerson
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpAddPerson";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
    }
}
