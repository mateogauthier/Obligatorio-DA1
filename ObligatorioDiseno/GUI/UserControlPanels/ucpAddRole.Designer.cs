namespace GUI.UserControlPanels
{
    partial class ucpAddRole
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
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.RolesToAdd = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Add Role";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(141, 325);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(426, 22);
            this.txtRole.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Role:";
            // 
            // txtActor
            // 
            this.txtActor.Enabled = false;
            this.txtActor.Location = new System.Drawing.Point(141, 177);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(426, 22);
            this.txtActor.TabIndex = 25;
            this.txtActor.TextChanged += new System.EventHandler(this.txtActor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Actor selected:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(663, 633);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 64);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(800, 633);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 64);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // RolesToAdd
            // 
            this.RolesToAdd.AutoSize = true;
            this.RolesToAdd.Location = new System.Drawing.Point(425, 368);
            this.RolesToAdd.Name = "RolesToAdd";
            this.RolesToAdd.Size = new System.Drawing.Size(142, 16);
            this.RolesToAdd.TabIndex = 35;
            this.RolesToAdd.Text = "Roles pending to add: ";
            this.RolesToAdd.Visible = false;
            // 
            // txtMovie
            // 
            this.txtMovie.Enabled = false;
            this.txtMovie.Location = new System.Drawing.Point(140, 249);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(426, 22);
            this.txtMovie.TabIndex = 37;
            this.txtMovie.TextChanged += new System.EventHandler(this.txtMovie_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Current movie:";
            // 
            // ucpAddRole
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RolesToAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpAddRole";
            this.Size = new System.Drawing.Size(954, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label RolesToAdd;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label3;
    }
}
