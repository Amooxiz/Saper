namespace SaperUI
{
    partial class DiffControll
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
            this.chooseDifPB = new System.Windows.Forms.PictureBox();
            this.easyPB = new System.Windows.Forms.PictureBox();
            this.mediumPB = new System.Windows.Forms.PictureBox();
            this.hardPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chooseDifPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardPB)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseDifPB
            // 
            this.chooseDifPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chooseDifPB.BackColor = System.Drawing.Color.Transparent;
            this.chooseDifPB.Image = global::SaperUI.Properties.Resources.choose_diff;
            this.chooseDifPB.Location = new System.Drawing.Point(51, 32);
            this.chooseDifPB.Name = "chooseDifPB";
            this.chooseDifPB.Size = new System.Drawing.Size(645, 132);
            this.chooseDifPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.chooseDifPB.TabIndex = 0;
            this.chooseDifPB.TabStop = false;
            // 
            // easyPB
            // 
            this.easyPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.easyPB.BackColor = System.Drawing.Color.Transparent;
            this.easyPB.Image = global::SaperUI.Properties.Resources.easy_cimen;
            this.easyPB.Location = new System.Drawing.Point(179, 266);
            this.easyPB.Name = "easyPB";
            this.easyPB.Size = new System.Drawing.Size(368, 84);
            this.easyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.easyPB.TabIndex = 1;
            this.easyPB.TabStop = false;
            this.easyPB.Click += new System.EventHandler(this.easyPB_Click);
            this.easyPB.MouseLeave += new System.EventHandler(this.easyPB_MouseLeave);
            this.easyPB.MouseHover += new System.EventHandler(this.easyPB_MouseHover);
            // 
            // mediumPB
            // 
            this.mediumPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mediumPB.BackColor = System.Drawing.Color.Transparent;
            this.mediumPB.Image = global::SaperUI.Properties.Resources.medium_ciemne;
            this.mediumPB.Location = new System.Drawing.Point(179, 422);
            this.mediumPB.Name = "mediumPB";
            this.mediumPB.Size = new System.Drawing.Size(368, 83);
            this.mediumPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mediumPB.TabIndex = 1;
            this.mediumPB.TabStop = false;
            this.mediumPB.Click += new System.EventHandler(this.mediumPB_Click);
            this.mediumPB.MouseLeave += new System.EventHandler(this.mediumPB_MouseLeave);
            this.mediumPB.MouseHover += new System.EventHandler(this.mediumPB_MouseHover);
            // 
            // hardPB
            // 
            this.hardPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hardPB.BackColor = System.Drawing.Color.Transparent;
            this.hardPB.Image = global::SaperUI.Properties.Resources.hard_ciemne;
            this.hardPB.Location = new System.Drawing.Point(179, 577);
            this.hardPB.Name = "hardPB";
            this.hardPB.Size = new System.Drawing.Size(368, 83);
            this.hardPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hardPB.TabIndex = 1;
            this.hardPB.TabStop = false;
            this.hardPB.Click += new System.EventHandler(this.hardPB_Click);
            this.hardPB.MouseLeave += new System.EventHandler(this.hardPB_MouseLeave);
            this.hardPB.MouseHover += new System.EventHandler(this.hardPB_MouseHover);
            // 
            // DiffControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaperUI.Properties.Resources.tlo;
            this.Controls.Add(this.hardPB);
            this.Controls.Add(this.mediumPB);
            this.Controls.Add(this.easyPB);
            this.Controls.Add(this.chooseDifPB);
            this.Name = "DiffControll";
            this.Size = new System.Drawing.Size(775, 673);
            ((System.ComponentModel.ISupportInitialize)(this.chooseDifPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox chooseDifPB;
        private PictureBox easyPB;
        private PictureBox mediumPB;
        private PictureBox hardPB;
    }
}
