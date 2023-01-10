namespace SaperUI
{
    partial class saperForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.playPB = new System.Windows.Forms.PictureBox();
            this.rankingPB = new System.Windows.Forms.PictureBox();
            this.exitPB = new System.Windows.Forms.PictureBox();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.enterNickPB = new System.Windows.Forms.PictureBox();
            this.titlePB = new System.Windows.Forms.PictureBox();
            this.restartPB = new System.Windows.Forms.PictureBox();
            this.backPB = new System.Windows.Forms.PictureBox();
            this.rankingPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterNickPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).BeginInit();
            this.rankingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.AutoSize = true;
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.playPB);
            this.menuPanel.Controls.Add(this.rankingPB);
            this.menuPanel.Controls.Add(this.exitPB);
            this.menuPanel.Location = new System.Drawing.Point(68, 324);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(782, 305);
            this.menuPanel.TabIndex = 0;
            // 
            // playPB
            // 
            this.playPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playPB.Enabled = false;
            this.playPB.Image = global::SaperUI.Properties.Resources.play_off;
            this.playPB.Location = new System.Drawing.Point(242, 11);
            this.playPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playPB.Name = "playPB";
            this.playPB.Size = new System.Drawing.Size(364, 83);
            this.playPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPB.TabIndex = 3;
            this.playPB.TabStop = false;
            this.playPB.Click += new System.EventHandler(this.playPB_Click);
            this.playPB.MouseLeave += new System.EventHandler(this.playPB_MouseLeave);
            this.playPB.MouseHover += new System.EventHandler(this.playPB_MouseHover);
            // 
            // rankingPB
            // 
            this.rankingPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rankingPB.Image = global::SaperUI.Properties.Resources.ranking_ciemne;
            this.rankingPB.Location = new System.Drawing.Point(242, 106);
            this.rankingPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankingPB.Name = "rankingPB";
            this.rankingPB.Size = new System.Drawing.Size(364, 83);
            this.rankingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rankingPB.TabIndex = 2;
            this.rankingPB.TabStop = false;
            this.rankingPB.Click += new System.EventHandler(this.rankingPB_Click);
            this.rankingPB.MouseLeave += new System.EventHandler(this.rankingPB_MouseLeave);
            this.rankingPB.MouseHover += new System.EventHandler(this.rankingPB_MouseHover);
            // 
            // exitPB
            // 
            this.exitPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitPB.Image = global::SaperUI.Properties.Resources.exit;
            this.exitPB.Location = new System.Drawing.Point(242, 200);
            this.exitPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(364, 83);
            this.exitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitPB.TabIndex = 1;
            this.exitPB.TabStop = false;
            this.exitPB.Click += new System.EventHandler(this.exitPB_Click);
            this.exitPB.MouseLeave += new System.EventHandler(this.exitPB_MouseLeave);
            this.exitPB.MouseHover += new System.EventHandler(this.exitPB_MouseHover);
            // 
            // nickTextBox
            // 
            this.nickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickTextBox.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nickTextBox.Location = new System.Drawing.Point(346, 248);
            this.nickTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nickTextBox.MaxLength = 10;
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(274, 37);
            this.nickTextBox.TabIndex = 1;
            this.nickTextBox.TextChanged += new System.EventHandler(this.nickTextBox_TextChanged);
            // 
            // enterNickPB
            // 
            this.enterNickPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterNickPB.BackColor = System.Drawing.Color.Transparent;
            this.enterNickPB.Image = global::SaperUI.Properties.Resources.ENTER_YOUR_NICKAmE;
            this.enterNickPB.Location = new System.Drawing.Point(309, 210);
            this.enterNickPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterNickPB.Name = "enterNickPB";
            this.enterNickPB.Size = new System.Drawing.Size(365, 18);
            this.enterNickPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enterNickPB.TabIndex = 2;
            this.enterNickPB.TabStop = false;
            // 
            // titlePB
            // 
            this.titlePB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlePB.BackColor = System.Drawing.Color.Transparent;
            this.titlePB.Image = global::SaperUI.Properties.Resources.tytul_mine;
            this.titlePB.Location = new System.Drawing.Point(220, 9);
            this.titlePB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlePB.Name = "titlePB";
            this.titlePB.Size = new System.Drawing.Size(586, 143);
            this.titlePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.titlePB.TabIndex = 3;
            this.titlePB.TabStop = false;
            // 
            // restartPB
            // 
            this.restartPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restartPB.BackColor = System.Drawing.Color.Transparent;
            this.restartPB.Image = global::SaperUI.Properties.Resources.refresh;
            this.restartPB.Location = new System.Drawing.Point(835, 55);
            this.restartPB.Name = "restartPB";
            this.restartPB.Size = new System.Drawing.Size(68, 71);
            this.restartPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.restartPB.TabIndex = 4;
            this.restartPB.TabStop = false;
            this.restartPB.Visible = false;
            this.restartPB.Click += new System.EventHandler(this.restartPB_Click);
            // 
            // backPB
            // 
            this.backPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backPB.BackColor = System.Drawing.Color.Transparent;
            this.backPB.Image = global::SaperUI.Properties.Resources.strzalka_w_lewo;
            this.backPB.Location = new System.Drawing.Point(46, 55);
            this.backPB.Name = "backPB";
            this.backPB.Size = new System.Drawing.Size(60, 60);
            this.backPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backPB.TabIndex = 5;
            this.backPB.TabStop = false;
            this.backPB.Visible = false;
            this.backPB.Click += new System.EventHandler(this.backPB_Click);
            // 
            // rankingPanel
            // 
            this.rankingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rankingPanel.AutoSize = true;
            this.rankingPanel.BackColor = System.Drawing.Color.Transparent;
            this.rankingPanel.Controls.Add(this.pictureBox3);
            this.rankingPanel.Controls.Add(this.pictureBox2);
            this.rankingPanel.Controls.Add(this.pictureBox1);
            this.rankingPanel.Location = new System.Drawing.Point(-2, 132);
            this.rankingPanel.Name = "rankingPanel";
            this.rankingPanel.Size = new System.Drawing.Size(945, 507);
            this.rankingPanel.TabIndex = 6;
            this.rankingPanel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::SaperUI.Properties.Resources.hard;
            this.pictureBox3.Location = new System.Drawing.Point(700, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::SaperUI.Properties.Resources.medium;
            this.pictureBox2.Location = new System.Drawing.Point(324, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaperUI.Properties.Resources.easy;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SaperUI.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(944, 651);
            this.Controls.Add(this.backPB);
            this.Controls.Add(this.restartPB);
            this.Controls.Add(this.titlePB);
            this.Controls.Add(this.enterNickPB);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this.rankingPanel);
            this.Name = "saperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterNickPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).EndInit();
            this.rankingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel menuPanel;
        private TextBox nickTextBox;
        private PictureBox enterNickPB;
        private PictureBox titlePB;
        private PictureBox exitPB;
        private PictureBox rankingPB;
        private PictureBox playPB;
        private PictureBox restartPB;
        private PictureBox backPB;
        private Panel rankingPanel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}