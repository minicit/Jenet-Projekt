
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
            this.lblName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarEnemy = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.btnClassVirologe = new System.Windows.Forms.Button();
            this.btnClassNormal = new System.Windows.Forms.Button();
            this.btnClassLeugner = new System.Windows.Forms.Button();
            this.buttonEndlos = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.panelInv.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelInv.Controls.Add(this.lblName);
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(226, 474);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 5;
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
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.buttonEndlos);
            this.panelMain.Controls.Add(this.btnCredits);
            this.panelMain.Controls.Add(this.btnHighscore);
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1600, 900);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.tbNameInput);
            this.panel1.Controls.Add(this.btnClassVirologe);
            this.panel1.Controls.Add(this.btnClassNormal);
            this.panel1.Controls.Add(this.btnClassLeugner);
            this.panel1.Location = new System.Drawing.Point(525, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 322);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(161, 257);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(207, 46);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Bestätigen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbNameInput
            // 
            this.tbNameInput.Location = new System.Drawing.Point(22, 169);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(100, 20);
            this.tbNameInput.TabIndex = 3;
            // 
            // btnClassVirologe
            // 
            this.btnClassVirologe.Location = new System.Drawing.Point(22, 110);
            this.btnClassVirologe.Name = "btnClassVirologe";
            this.btnClassVirologe.Size = new System.Drawing.Size(134, 41);
            this.btnClassVirologe.TabIndex = 2;
            this.btnClassVirologe.Text = "Virologe";
            this.btnClassVirologe.UseVisualStyleBackColor = true;
            this.btnClassVirologe.Click += new System.EventHandler(this.btnClassVirologe_Click);
            // 
            // btnClassNormal
            // 
            this.btnClassNormal.Location = new System.Drawing.Point(22, 63);
            this.btnClassNormal.Name = "btnClassNormal";
            this.btnClassNormal.Size = new System.Drawing.Size(134, 41);
            this.btnClassNormal.TabIndex = 1;
            this.btnClassNormal.Text = "Normalbürger";
            this.btnClassNormal.UseVisualStyleBackColor = true;
            this.btnClassNormal.Click += new System.EventHandler(this.btnClassNormal_Click);
            // 
            // btnClassLeugner
            // 
            this.btnClassLeugner.Location = new System.Drawing.Point(22, 13);
            this.btnClassLeugner.Name = "btnClassLeugner";
            this.btnClassLeugner.Size = new System.Drawing.Size(134, 44);
            this.btnClassLeugner.TabIndex = 0;
            this.btnClassLeugner.Text = "Coronaleugner";
            this.btnClassLeugner.UseVisualStyleBackColor = true;
            this.btnClassLeugner.Click += new System.EventHandler(this.btnClassLeugner_Click);
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
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Button btnClassVirologe;
        private System.Windows.Forms.Button btnClassNormal;
        private System.Windows.Forms.Button btnClassLeugner;
        private System.Windows.Forms.Label lblName;
    }
}

