
namespace Jenet_Projekt
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelInv = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelHighscore = new System.Windows.Forms.Panel();
            this.panelCredits = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.Controls.Add(this.panelStart);
            this.panelMain.Controls.Add(this.panelHighscore);
            this.panelMain.Controls.Add(this.panelCredits);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1600, 900);
            this.panelMain.TabIndex = 0;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Aqua;
            this.panelGame.Controls.Add(this.panelInv);
            this.panelGame.Controls.Add(this.panelMap);
            this.panelGame.ForeColor = System.Drawing.Color.Coral;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1600, 900);
            this.panelGame.TabIndex = 1;
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Blue;
            this.panelMap.ForeColor = System.Drawing.Color.Coral;
            this.panelMap.Location = new System.Drawing.Point(8, 8);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1250, 884);
            this.panelMap.TabIndex = 2;
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
            // 
            // panelInv
            // 
            this.panelInv.BackColor = System.Drawing.Color.Blue;
            this.panelInv.ForeColor = System.Drawing.Color.Coral;
            this.panelInv.Location = new System.Drawing.Point(1266, 8);
            this.panelInv.Name = "panelInv";
            this.panelInv.Size = new System.Drawing.Size(325, 884);
            this.panelInv.TabIndex = 3;
            this.panelInv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInv_Paint);
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.Transparent;
            this.panelStart.Location = new System.Drawing.Point(535, 454);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(529, 95);
            this.panelStart.TabIndex = 2;
            this.panelStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelStart_MouseClick);
            // 
            // panelHighscore
            // 
            this.panelHighscore.BackColor = System.Drawing.Color.Transparent;
            this.panelHighscore.Location = new System.Drawing.Point(535, 581);
            this.panelHighscore.Name = "panelHighscore";
            this.panelHighscore.Size = new System.Drawing.Size(529, 84);
            this.panelHighscore.TabIndex = 3;
            // 
            // panelCredits
            // 
            this.panelCredits.BackColor = System.Drawing.Color.Transparent;
            this.panelCredits.Location = new System.Drawing.Point(535, 700);
            this.panelCredits.Name = "panelCredits";
            this.panelCredits.Size = new System.Drawing.Size(529, 81);
            this.panelCredits.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 901);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelInv;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelHighscore;
        private System.Windows.Forms.Panel panelCredits;
    }
}

