using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jenet_Projekt
{
    public partial class Highscore : Form
    {
        private Dictionary<string, int> highscores = new Dictionary<string, int>();
        private string name;
        private int currentHighscore;

        public Highscore(string name, int currentHighscore)
        {
            InitializeComponent();
            this.name = name;
            this.currentHighscore = currentHighscore;
            this.highscores[this.name] = this.currentHighscore;
            this.updateLbHighscores();
        }
        public Highscore()
        {
            InitializeComponent();
        }

        private void updateLbHighscores()
        {
            if(lbHighscores.Items != null)
                this.lbHighscores.Items.Clear();
            foreach (KeyValuePair<string, int> highscore in this.highscores.OrderByDescending(highscore => highscore.Value))
            {
                this.lbHighscores.Items.Add($"{highscore.Key}: {highscore.Value}");
            }
        }

        public void addScore(int score, string name)
        {
            this.highscores[name] = score;
            updateLbHighscores();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string[] test = File.ReadAllLines("highscores.txt");
                foreach (var item in test)
                {
                    string[] score = item.Split(':');
                    highscores.Add(score[0], Convert.ToInt32(score[1]));
                }
                //this.highscores = File.ReadAllLines("highscores.txt").Select(highscore => highscore.Split(':')).ToDictionary(
                //    highscore => highscore[0],
                //    highscore => Convert.ToInt32(highscore[1])
                //);
                //if (this.highscores.ContainsKey(this.name))
                //{
                //    if (this.highscores[this.name] < this.currentHighscore)
                //    {
                //        this.highscores[this.name] = this.currentHighscore;
                //    } else
                //    {
                //        this.currentHighscore = this.highscores[this.name];
                //    }
                //}
                this.updateLbHighscores();
            }
            catch (Exception _)
            {
                MessageBox.Show(
                    "Beim Lesen der Highscores ist ein Fehler aufgetreten! Bitte stelle sicher das die Datei vorhanden ist.",
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("highscores.txt", this.highscores.Select(highscore => $"{highscore.Key}:{highscore.Value}"));
        }
    }
}
