namespace GUI.UserControlPanels
{
    partial class ucpChooseProfile
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
            this.lblProfile1 = new System.Windows.Forms.Label();
            this.pbProfile1 = new System.Windows.Forms.PictureBox();
            this.pbProfile2 = new System.Windows.Forms.PictureBox();
            this.lblProfile2 = new System.Windows.Forms.Label();
            this.pbProfile3 = new System.Windows.Forms.PictureBox();
            this.lblProfile3 = new System.Windows.Forms.Label();
            this.pbProfile4 = new System.Windows.Forms.PictureBox();
            this.lblProfile4 = new System.Windows.Forms.Label();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnEnterPin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfile1
            // 
            this.lblProfile1.AutoSize = true;
            this.lblProfile1.Location = new System.Drawing.Point(179, 273);
            this.lblProfile1.Name = "lblProfile1";
            this.lblProfile1.Size = new System.Drawing.Size(10, 16);
            this.lblProfile1.TabIndex = 0;
            this.lblProfile1.Text = " ";
            // 
            // pbProfile1
            // 
            this.pbProfile1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbProfile1.Location = new System.Drawing.Point(183, 296);
            this.pbProfile1.Name = "pbProfile1";
            this.pbProfile1.Size = new System.Drawing.Size(99, 96);
            this.pbProfile1.TabIndex = 1;
            this.pbProfile1.TabStop = false;
            this.pbProfile1.Click += new System.EventHandler(this.PbProfile1_Click);
            // 
            // pbProfile2
            // 
            this.pbProfile2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbProfile2.Location = new System.Drawing.Point(288, 296);
            this.pbProfile2.Name = "pbProfile2";
            this.pbProfile2.Size = new System.Drawing.Size(99, 96);
            this.pbProfile2.TabIndex = 4;
            this.pbProfile2.TabStop = false;
            this.pbProfile2.Visible = false;
            this.pbProfile2.Click += new System.EventHandler(this.PbProfile2_Click);
            // 
            // lblProfile2
            // 
            this.lblProfile2.AutoSize = true;
            this.lblProfile2.Location = new System.Drawing.Point(284, 273);
            this.lblProfile2.Name = "lblProfile2";
            this.lblProfile2.Size = new System.Drawing.Size(10, 16);
            this.lblProfile2.TabIndex = 3;
            this.lblProfile2.Text = " ";
            // 
            // pbProfile3
            // 
            this.pbProfile3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbProfile3.Location = new System.Drawing.Point(393, 296);
            this.pbProfile3.Name = "pbProfile3";
            this.pbProfile3.Size = new System.Drawing.Size(99, 96);
            this.pbProfile3.TabIndex = 7;
            this.pbProfile3.TabStop = false;
            this.pbProfile3.Visible = false;
            this.pbProfile3.Click += new System.EventHandler(this.PbProfile3_Click);
            // 
            // lblProfile3
            // 
            this.lblProfile3.AutoSize = true;
            this.lblProfile3.Location = new System.Drawing.Point(389, 273);
            this.lblProfile3.Name = "lblProfile3";
            this.lblProfile3.Size = new System.Drawing.Size(10, 16);
            this.lblProfile3.TabIndex = 6;
            this.lblProfile3.Text = " ";
            // 
            // pbProfile4
            // 
            this.pbProfile4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbProfile4.Location = new System.Drawing.Point(498, 296);
            this.pbProfile4.Name = "pbProfile4";
            this.pbProfile4.Size = new System.Drawing.Size(99, 96);
            this.pbProfile4.TabIndex = 10;
            this.pbProfile4.TabStop = false;
            this.pbProfile4.Visible = false;
            this.pbProfile4.Click += new System.EventHandler(this.PbProfile4_Click);
            // 
            // lblProfile4
            // 
            this.lblProfile4.AutoSize = true;
            this.lblProfile4.Location = new System.Drawing.Point(494, 273);
            this.lblProfile4.Name = "lblProfile4";
            this.lblProfile4.Size = new System.Drawing.Size(10, 16);
            this.lblProfile4.TabIndex = 9;
            this.lblProfile4.Text = " ";
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(659, 322);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(135, 43);
            this.btnCreateProfile.TabIndex = 11;
            this.btnCreateProfile.Text = "New profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.BtnCreateProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(800, 658);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 45);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdminMenu.Location = new System.Drawing.Point(660, 658);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(134, 45);
            this.btnAdminMenu.TabIndex = 17;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(224, 481);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(138, 26);
            this.txtPin.TabIndex = 18;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(179, 484);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(39, 20);
            this.lblPin.TabIndex = 19;
            this.lblPin.Text = "PIN:";
            // 
            // btnEnterPin
            // 
            this.btnEnterPin.Location = new System.Drawing.Point(368, 475);
            this.btnEnterPin.Name = "btnEnterPin";
            this.btnEnterPin.Size = new System.Drawing.Size(87, 38);
            this.btnEnterPin.TabIndex = 20;
            this.btnEnterPin.Text = "Enter";
            this.btnEnterPin.UseVisualStyleBackColor = true;
            this.btnEnterPin.Click += new System.EventHandler(this.btnEnterPin_Click);
            // 
            // ucpChooseProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnEnterPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.pbProfile4);
            this.Controls.Add(this.lblProfile4);
            this.Controls.Add(this.pbProfile3);
            this.Controls.Add(this.lblProfile3);
            this.Controls.Add(this.pbProfile2);
            this.Controls.Add(this.lblProfile2);
            this.Controls.Add(this.pbProfile1);
            this.Controls.Add(this.lblProfile1);
            this.Name = "ucpChooseProfile";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile1;
        private System.Windows.Forms.PictureBox pbProfile1;
        private System.Windows.Forms.PictureBox pbProfile2;
        private System.Windows.Forms.Label lblProfile2;
        private System.Windows.Forms.PictureBox pbProfile3;
        private System.Windows.Forms.Label lblProfile3;
        private System.Windows.Forms.PictureBox pbProfile4;
        private System.Windows.Forms.Label lblProfile4;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnEnterPin;
    }
}
