namespace GUI.UserControlPanels
{
    partial class ucpCreateOwnerProfile
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
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(625, 385);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(130, 66);
            this.btnCreateProfile.TabIndex = 11;
            this.btnCreateProfile.Text = "Create profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(203, 362);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(269, 26);
            this.txtPIN.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "PIN:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(203, 293);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(269, 26);
            this.txtNickname.TabIndex = 8;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(199, 270);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(83, 20);
            this.lblNickname.TabIndex = 7;
            this.lblNickname.Text = "Nickname:";
            // 
            // ucpCreateOwnerProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblNickname);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpCreateOwnerProfile";
            this.Size = new System.Drawing.Size(954, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
    }
}
