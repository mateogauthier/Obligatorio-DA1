namespace GUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.Location = new System.Drawing.Point(12, 12);
            this.flpMain.MaximumSize = new System.Drawing.Size(954, 720);
            this.flpMain.MinimumSize = new System.Drawing.Size(954, 720);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(954, 720);
            this.flpMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(972, 727);
            this.Controls.Add(this.flpMain);
            this.MaximumSize = new System.Drawing.Size(994, 783);
            this.MinimumSize = new System.Drawing.Size(994, 783);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Threat Level Midnight Entertainment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
    }
}

