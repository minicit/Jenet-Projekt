
namespace Jenet_Projekt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelGame = new System.Windows.Forms.Panel();
            this.combatPanel = new System.Windows.Forms.Panel();
            this.panelInv = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarEnemy = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonEndlos = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelGame.SuspendLayout();
            this.panelInv.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Aqua;
            this.panelGame.Controls.Add(this.combatPanel);
            this.panelGame.Controls.Add(this.panelInv);
            this.panelGame.Controls.Add(this.panelMap);
            this.panelGame.ForeColor = System.Drawing.Color.Coral;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1600, 900);
            this.panelGame.TabIndex = 1;
            // 
            // combatPanel
            // 
            this.combatPanel.BackColor = System.Drawing.Color.Gold;
            this.combatPanel.Location = new System.Drawing.Point(10, 13);
            this.combatPanel.Name = "combatPanel";
            this.combatPanel.Size = new System.Drawing.Size(1250, 875);
            this.combatPanel.TabIndex = 4;
            // 
            // panelInv
            // 
            this.panelInv.BackColor = System.Drawing.Color.DarkBlue;
            this.panelInv.Controls.Add(this.listBox1);
            this.panelInv.Controls.Add(this.label2);
            this.panelInv.Controls.Add(this.label1);
            this.panelInv.Controls.Add(this.progressBarEnemy);
            this.panelInv.Controls.Add(this.progressBarPlayer);
            this.panelInv.ForeColor = System.Drawing.Color.Coral;
            this.panelInv.Location = new System.Drawing.Point(1266, 13);
            this.panelInv.Name = "panelInv";
            this.panelInv.Size = new System.Drawing.Size(325, 875);
            this.panelInv.TabIndex = 3;
            this.panelInv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInv_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Health";
            // 
            // progressBarEnemy
            // 
            this.progressBarEnemy.Location = new System.Drawing.Point(3, 557);
            this.progressBarEnemy.Name = "progressBarEnemy";
            this.progressBarEnemy.Size = new System.Drawing.Size(318, 23);
            this.progressBarEnemy.TabIndex = 1;
            // 
            // progressBarPlayer
            // 
            this.progressBarPlayer.Location = new System.Drawing.Point(3, 494);
            this.progressBarPlayer.Name = "progressBarPlayer";
            this.progressBarPlayer.Size = new System.Drawing.Size(318, 23);
            this.progressBarPlayer.TabIndex = 0;
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
            this.panelMain.Controls.Add(this.buttonEndlos);
            this.panelMain.Controls.Add(this.btnCredits);
            this.panelMain.Controls.Add(this.btnHighscore);
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1600, 900);
            this.panelMain.TabIndex = 0;
            // 
            // buttonEndlos
            // 
            this.buttonEndlos.Location = new System.Drawing.Point(560, 439);
            this.buttonEndlos.Name = "buttonEndlos";
            this.buttonEndlos.Size = new System.Drawing.Size(480, 120);
            this.buttonEndlos.TabIndex = 1;
            this.buttonEndlos.Text = "Endlos";
            this.buttonEndlos.UseVisualStyleBackColor = true;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(560, 761);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(480, 120);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(560, 599);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(480, 120);
            this.btnHighscore.TabIndex = 2;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 587);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(317, 121);
            this.listBox1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 900);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelInv.ResumeLayout(false);
            this.panelInv.PerformLayout();
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
        private System.Windows.Forms.Panel combatPanel;
        private System.Windows.Forms.Button buttonEndlos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarEnemy;
        private System.Windows.Forms.ProgressBar progressBarPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

