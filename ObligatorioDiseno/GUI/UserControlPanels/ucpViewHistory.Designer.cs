namespace GUI.UserControlPanels
{
    partial class ucpViewHistory
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
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
            this.dgvMovies.TabIndex = 1;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(519, 666);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(168, 33);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "All movies";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ucpViewHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dgvMovies);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpViewHistory";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnAll;
    }
}
