
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.CombatBox = new System.Windows.Forms.PictureBox();
            this.panelInv = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEndlos = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CombatBox)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Aqua;
            this.panelGame.Controls.Add(this.CombatBox);
            this.panelGame.Controls.Add(this.panelInv);
            this.panelGame.Controls.Add(this.panelMap);
            this.panelGame.ForeColor = System.Drawing.Color.Coral;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1600, 900);
            this.panelGame.TabIndex = 1;
            // 
            // CombatBox
            // 
            this.CombatBox.BackColor = System.Drawing.Color.Yellow;
            this.CombatBox.Location = new System.Drawing.Point(10, 13);
            this.CombatBox.Name = "CombatBox";
            this.CombatBox.Size = new System.Drawing.Size(1250, 875);
            this.CombatBox.TabIndex = 4;
            this.CombatBox.TabStop = false;
            // 
            // panelInv
            // 
            this.panelInv.BackColor = System.Drawing.Color.DarkBlue;
            this.panelInv.ForeColor = System.Drawing.Color.Coral;
            this.panelInv.Location = new System.Drawing.Point(1266, 13);
            this.panelInv.Name = "panelInv";
            this.panelInv.Size = new System.Drawing.Size(325, 875);
            this.panelInv.TabIndex = 3;
            this.panelInv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInv_Paint);
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Navy;
            this.panelMap.ForeColor = System.Drawing.Color.Coral;
            this.panelMap.Location = new System.Drawing.Point(10, 13);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1250, 875);
            this.panelMap.TabIndex = 2;
            this.panelMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMap_MouseClick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.Controls.Add(this.btnEndlos);
            this.panelMain.Controls.Add(this.btnCredits);
            this.panelMain.Controls.Add(this.btnHighscore);
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1600, 900);
            this.panelMain.TabIndex = 0;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(560, 761);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(480, 120);
            this.btnCredits.TabIndex = 2;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(560, 599);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(480, 120);
            this.btnHighscore.TabIndex = 1;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(560, 279);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(480, 120);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEndlos
            // 
            this.btnEndlos.Location = new System.Drawing.Point(560, 439);
            this.btnEndlos.Name = "btnEndlos";
            this.btnEndlos.Size = new System.Drawing.Size(480, 120);
            this.btnEndlos.TabIndex = 3;
            this.btnEndlos.Text = "Endlos";
            this.btnEndlos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 899);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CombatBox)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelInv;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox CombatBox;
        private System.Windows.Forms.Button btnEndlos;
    }
}

