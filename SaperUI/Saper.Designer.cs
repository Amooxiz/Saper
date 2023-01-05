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
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterNickPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePB)).BeginInit();
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
            this.menuPanel.Location = new System.Drawing.Point(78, 285);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(894, 353);
            this.menuPanel.TabIndex = 0;
            // 
            // playPB
            // 
            this.playPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playPB.Enabled = false;
            this.playPB.Image = global::SaperUI.Properties.Resources.play_off;
            this.playPB.Location = new System.Drawing.Point(276, 15);
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
            this.rankingPB.Location = new System.Drawing.Point(276, 141);
            this.rankingPB.Name = "rankingPB";
            this.rankingPB.Size = new System.Drawing.Size(364, 83);
            this.rankingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rankingPB.TabIndex = 2;
            this.rankingPB.TabStop = false;
            this.rankingPB.MouseLeave += new System.EventHandler(this.rankingPB_MouseLeave);
            this.rankingPB.MouseHover += new System.EventHandler(this.rankingPB_MouseHover);
            // 
            // exitPB
            // 
            this.exitPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitPB.Image = global::SaperUI.Properties.Resources.exit;
            this.exitPB.Location = new System.Drawing.Point(276, 267);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(364, 83);
            this.exitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitPB.TabIndex = 1;
            this.exitPB.TabStop = false;
            this.exitPB.MouseLeave += new System.EventHandler(this.exitPB_MouseLeave);
            this.exitPB.MouseHover += new System.EventHandler(this.exitPB_MouseHover);
            // 
            // nickTextBox
            // 
            this.nickTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickTextBox.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nickTextBox.Location = new System.Drawing.Point(376, 220);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(313, 44);
            this.nickTextBox.TabIndex = 1;
            this.nickTextBox.TextChanged += new System.EventHandler(this.nickTextBox_TextChanged);
            // 
            // enterNickPB
            // 
            this.enterNickPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterNickPB.BackColor = System.Drawing.Color.Transparent;
            this.enterNickPB.Image = global::SaperUI.Properties.Resources.ENTER_YOUR_NICKAmE;
            this.enterNickPB.Location = new System.Drawing.Point(354, 186);
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
            this.titlePB.Location = new System.Drawing.Point(252, 12);
            this.titlePB.Name = "titlePB";
            this.titlePB.Size = new System.Drawing.Size(586, 143);
            this.titlePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.titlePB.TabIndex = 3;
            this.titlePB.TabStop = false;
            // 
            // saperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SaperUI.Properties.Resources.tlo;
            this.ClientSize = new System.Drawing.Size(1079, 668);
            this.Controls.Add(this.titlePB);
            this.Controls.Add(this.enterNickPB);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.nickTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}