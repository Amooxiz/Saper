namespace SaperUI
{
    partial class Saper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.rankingButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.controlsButton);
            this.panel1.Controls.Add(this.rankingButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(300, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 267);
            this.panel1.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(3, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(243, 47);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // rankingButton
            // 
            this.rankingButton.Location = new System.Drawing.Point(3, 73);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(243, 47);
            this.rankingButton.TabIndex = 0;
            this.rankingButton.Text = "RANKING";
            this.rankingButton.UseVisualStyleBackColor = true;
            // 
            // controlsButton
            // 
            this.controlsButton.Location = new System.Drawing.Point(3, 143);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(243, 47);
            this.controlsButton.TabIndex = 0;
            this.controlsButton.Text = "CONTROLS";
            this.controlsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(243, 47);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Saper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 518);
            this.Controls.Add(this.panel1);
            this.Name = "Saper";
            this.Text = "Saper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button exitButton;
        private Button controlsButton;
        private Button rankingButton;
        private Button playButton;
    }
}