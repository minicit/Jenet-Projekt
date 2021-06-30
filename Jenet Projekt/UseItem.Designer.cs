
namespace Jenet_Projekt
{
    partial class UseItem
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
            this.btnItem1 = new System.Windows.Forms.Button();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.btnItem4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(13, 13);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(100, 50);
            this.btnItem1.TabIndex = 0;
            this.btnItem1.Text = "Mundschutz";
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.btnItem1_Click);
            // 
            // btnItem2
            // 
            this.btnItem2.Location = new System.Drawing.Point(141, 12);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(100, 50);
            this.btnItem2.TabIndex = 1;
            this.btnItem2.Text = "Feuerzeug";
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.btnItem2_Click);
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(13, 99);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(100, 50);
            this.btnItem3.TabIndex = 2;
            this.btnItem3.Text = "Spritze";
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click);
            // 
            // btnItem4
            // 
            this.btnItem4.Location = new System.Drawing.Point(141, 99);
            this.btnItem4.Name = "btnItem4";
            this.btnItem4.Size = new System.Drawing.Size(100, 50);
            this.btnItem4.TabIndex = 3;
            this.btnItem4.Text = "Schuh";
            this.btnItem4.UseVisualStyleBackColor = true;
            this.btnItem4.Click += new System.EventHandler(this.btnItem4_Click);
            // 
            // UseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 170);
            this.Controls.Add(this.btnItem4);
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.btnItem1);
            this.Name = "UseItem";
            this.Text = "UseItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.Button btnItem3;
        private System.Windows.Forms.Button btnItem4;
    }
}