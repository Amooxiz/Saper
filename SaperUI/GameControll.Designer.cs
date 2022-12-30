namespace SaperUI
{
    partial class GameControll
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
            this.pGame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pGame
            // 
            this.pGame.Location = new System.Drawing.Point(28, 22);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(200, 100);
            this.pGame.TabIndex = 0;
            // 
            // GameControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pGame);
            this.Name = "GameControll";
            this.Size = new System.Drawing.Size(651, 597);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pGame;
    }
}
