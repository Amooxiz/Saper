namespace SaperUI
{
    partial class TimerControll
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
            this.components = new System.ComponentModel.Container();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bombPB2 = new System.Windows.Forms.PictureBox();
            this.bombPB1 = new System.Windows.Forms.PictureBox();
            this.finalScorePB = new System.Windows.Forms.PictureBox();
            this.gameOverPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bombPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalScorePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPB)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(100, 53);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(312, 62);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00:00:000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bombPB2
            // 
            this.bombPB2.Image = global::SaperUI.Properties.Resources.pxArt;
            this.bombPB2.Location = new System.Drawing.Point(418, 3);
            this.bombPB2.Name = "bombPB2";
            this.bombPB2.Size = new System.Drawing.Size(91, 135);
            this.bombPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bombPB2.TabIndex = 1;
            this.bombPB2.TabStop = false;
            // 
            // bombPB1
            // 
            this.bombPB1.Image = global::SaperUI.Properties.Resources.pxArt;
            this.bombPB1.Location = new System.Drawing.Point(3, 3);
            this.bombPB1.Name = "bombPB1";
            this.bombPB1.Size = new System.Drawing.Size(91, 135);
            this.bombPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bombPB1.TabIndex = 1;
            this.bombPB1.TabStop = false;
            // 
            // finalScorePB
            // 
            this.finalScorePB.Image = global::SaperUI.Properties.Resources.final_score;
            this.finalScorePB.Location = new System.Drawing.Point(122, 12);
            this.finalScorePB.Name = "finalScorePB";
            this.finalScorePB.Size = new System.Drawing.Size(259, 23);
            this.finalScorePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finalScorePB.TabIndex = 2;
            this.finalScorePB.TabStop = false;
            this.finalScorePB.Visible = false;
            // 
            // gameOverPB
            // 
            this.gameOverPB.Image = global::SaperUI.Properties.Resources.game_over;
            this.gameOverPB.Location = new System.Drawing.Point(113, 53);
            this.gameOverPB.Name = "gameOverPB";
            this.gameOverPB.Size = new System.Drawing.Size(283, 30);
            this.gameOverPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOverPB.TabIndex = 3;
            this.gameOverPB.TabStop = false;
            this.gameOverPB.Visible = false;
            // 
            // TimerControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gameOverPB);
            this.Controls.Add(this.finalScorePB);
            this.Controls.Add(this.bombPB1);
            this.Controls.Add(this.bombPB2);
            this.Controls.Add(this.timerLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimerControll";
            this.Size = new System.Drawing.Size(511, 170);
            ((System.ComponentModel.ISupportInitialize)(this.bombPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalScorePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bombPB2;
        private PictureBox bombPB1;
        private PictureBox finalScorePB;
        private PictureBox gameOverPB;
    }
}
