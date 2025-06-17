namespace GUI.UserControlPanels
{
    partial class ucpCreateProfile
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
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChildProfile = new System.Windows.Forms.CheckBox();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(193, 229);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(83, 20);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Nickname:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(197, 252);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(269, 26);
            this.txtNickname.TabIndex = 1;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(197, 321);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(269, 26);
            this.txtPIN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PIN (Required if not a child):";
            // 
            // cbChildProfile
            // 
            this.cbChildProfile.AutoSize = true;
            this.cbChildProfile.Location = new System.Drawing.Point(197, 386);
            this.cbChildProfile.Name = "cbChildProfile";
            this.cbChildProfile.Size = new System.Drawing.Size(158, 24);
            this.cbChildProfile.TabIndex = 4;
            this.cbChildProfile.Text = "Is it a child profile?";
            this.cbChildProfile.UseVisualStyleBackColor = true;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(619, 344);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(130, 66);
            this.btnCreateProfile.TabIndex = 6;
            this.btnCreateProfile.Text = "Create profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucpCreateProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.cbChildProfile);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblNickname);
            this.Name = "ucpCreateProfile";
            this.Size = new System.Drawing.Size(954, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbChildProfile;
        private System.Windows.Forms.Button btnCreateProfile;
    }
}
