namespace GUI.UserControlPanels
{
    partial class ucpRegisterView
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
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbOtherGenres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMarkAsViewed = new System.Windows.Forms.GroupBox();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnPlusTwo = new System.Windows.Forms.Button();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.cbRatedGa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.gbMarkAsViewed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(60, 49);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(357, 480);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(462, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 37);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(469, 181);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(415, 125);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(464, 95);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(80, 29);
            this.lbGenre.TabIndex = 3;
            this.lbGenre.Text = "Genre";
            // 
            // lbOtherGenres
            // 
            this.lbOtherGenres.FormattingEnabled = true;
            this.lbOtherGenres.ItemHeight = 20;
            this.lbOtherGenres.Location = new System.Drawing.Point(469, 389);
            this.lbOtherGenres.Name = "lbOtherGenres";
            this.lbOtherGenres.Size = new System.Drawing.Size(415, 84);
            this.lbOtherGenres.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Other genres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // gbMarkAsViewed
            // 
            this.gbMarkAsViewed.Controls.Add(this.btnPlusOne);
            this.gbMarkAsViewed.Controls.Add(this.btnPlusTwo);
            this.gbMarkAsViewed.Controls.Add(this.btnMinusOne);
            this.gbMarkAsViewed.Location = new System.Drawing.Point(60, 577);
            this.gbMarkAsViewed.Name = "gbMarkAsViewed";
            this.gbMarkAsViewed.Size = new System.Drawing.Size(377, 100);
            this.gbMarkAsViewed.TabIndex = 7;
            this.gbMarkAsViewed.TabStop = false;
            this.gbMarkAsViewed.Text = "Mark as viewed";
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusOne.Location = new System.Drawing.Point(132, 25);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(118, 69);
            this.btnPlusOne.TabIndex = 8;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnPlusTwo
            // 
            this.btnPlusTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTwo.Location = new System.Drawing.Point(256, 25);
            this.btnPlusTwo.Name = "btnPlusTwo";
            this.btnPlusTwo.Size = new System.Drawing.Size(115, 69);
            this.btnPlusTwo.TabIndex = 8;
            this.btnPlusTwo.Text = "++1";
            this.btnPlusTwo.UseVisualStyleBackColor = true;
            this.btnPlusTwo.Click += new System.EventHandler(this.btnPlusTwo_Click);
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusOne.Location = new System.Drawing.Point(3, 25);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(123, 69);
            this.btnMinusOne.TabIndex = 0;
            this.btnMinusOne.Text = "-1";
            this.btnMinusOne.UseVisualStyleBackColor = true;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // cbRatedGa
            // 
            this.cbRatedGa.AutoCheck = false;
            this.cbRatedGa.AutoSize = true;
            this.cbRatedGa.Location = new System.Drawing.Point(648, 505);
            this.cbRatedGa.Name = "cbRatedGa";
            this.cbRatedGa.Size = new System.Drawing.Size(236, 24);
            this.cbRatedGa.TabIndex = 8;
            this.cbRatedGa.Text = "Rated for general audiences";
            this.cbRatedGa.UseVisualStyleBackColor = true;
            // 
            // ucpRegisterView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbRatedGa);
            this.Controls.Add(this.gbMarkAsViewed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOtherGenres);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbPoster);
            this.MaximumSize = new System.Drawing.Size(954, 720);
            this.MinimumSize = new System.Drawing.Size(954, 720);
            this.Name = "ucpRegisterView";
            this.Size = new System.Drawing.Size(954, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.gbMarkAsViewed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.ListBox lbOtherGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMarkAsViewed;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnPlusTwo;
        private System.Windows.Forms.Button btnMinusOne;
        private System.Windows.Forms.CheckBox cbRatedGa;
    }
}
