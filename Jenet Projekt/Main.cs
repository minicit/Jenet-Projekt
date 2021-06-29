using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//panelMain
//panelGame
//panelMap
//panelInv
namespace Jenet_Projekt
{
    public partial class Main : Form
    {
        private static Main instance;

        int[,] grid = new int[10, 7]; // Array speichert Positionen in der Karte
        private int fieldsize = 125; //Größe eines Feldes in px 
        private SpriteHelper spriteHelper = new SpriteHelper();
        private GameEntity player = new GameEntity(Klasse.Klassen.Normalbürger, "Test");
        private GameEntity[] enemy;
        private Combat fight = new Combat();
        private int currentfighter;
        private int currentStage = 0;
        private int invX = 3;
        private int invY = 4;
        private int currentStory = 1;
        private bool storyActive = false;
        Eventcaller subject = new Eventcaller();
        CombatObserver observer = new CombatObserver();
        StoryManager story = new StoryManager();
        
        public Main()
        {
            InitializeComponent();

            instance = this;

            subject.Attach(observer);
            panelMain.BackgroundImage = Resources.Resource1.Titlescreen;
            panelGame.BackgroundImage = Resources.Resource1.GamePanelBackground;
            panelGame.Hide();
            combatPanel.Hide();
            enemy = new GameEntity[5];
            enemy[0] = new GameEntity(Klasse.Klassen.Virus, "Virus");
            //panelMap.BackgroundImage = Resources.Resource1.MapBackground;
        }

        private void gameStart(int stage)
        {
            panelStory.BackgroundImage = story.getStory(currentStory, player.getClass());
            currentStory++;
            storyActive = true;
            panelStory.Show();
        }

        public static Main getInstance()
        {
            if (instance == null)
            {
                instance = new Main();
            }
            return instance;
        }
        private void initGrid(int gridNo)
        {
            //Schreibt Startpositionen der Gegner / Spieler / Hindernisse in das Array
            // Wert 0 = frei
            // Wert 1 = Spieler
            // Wert 2 = Virus
            // Wert 3 = Wald
            // Wert 4 = Berge
            // Wert 5 = Haus
            // Bsp : grid[1,2] = 3; setzt ein Hindernis an die Position X = 1 / Y = 2
            // Erlaubte Positionen X : 0 - 9 
            // Erlaubte Positionen Y : 0 - 6
            Array.Clear(grid, 0, grid.Length);
            switch (gridNo)
            {
                case 1:
                    player.setcoords(5, 4);
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "yoink");
                    enemy[0].setcoords(5, 2);
                    currentStage = 1;
                    setBackground(currentStage);
                    /*for (int i = 0; i < 8; i++)
                    {
                        grid[0, i] = 3;
                        grid[7, i] = 3;
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        grid[i, 0] = 3;
                        grid[i, 1] = 3;
                        grid[i, 8] = 3;
                        grid[i, 9] = 3;
                    }*/
                    /*grid[7, 4] = 1;
                    grid[1, 1] = 2;
                    grid[5, 3] = 3;
                    grid[4, 5] = 4;
                    grid[4, 3] = 3;
                    grid[5, 2] = 3;
                    grid[4, 2] = 3;*/
                    grid[0, 0] = 3;
                    grid[1, 0] = 3;
                    grid[2, 0] = 3;
                    grid[3, 0] = 3;
                    grid[4, 0] = 3;
                    grid[5, 0] = 3;
                    grid[6, 0] = 3;
                    grid[7, 0] = 3;
                    grid[8, 0] = 3;
                    grid[9, 0] = 3;
                    grid[0, 1] = 3;
                    grid[1, 1] = 3;
                    grid[2, 1] = 3;
                    grid[7, 1] = 3;
                    grid[8, 1] = 3;
                    grid[9, 1] = 3;
                    grid[0, 2] = 3;
                    grid[1, 2] = 3;
                    grid[8, 2] = 3;
                    grid[9, 2] = 3;
                    grid[0, 3] = 3;
                    grid[1, 3] = 3;
                    grid[8, 3] = 3;
                    grid[9, 3] = 3;
                    grid[0, 4] = 3;
                    grid[1, 4] = 3;
                    grid[2, 4] = 3;
                    grid[8, 4] = 3;
                    grid[9, 4] = 3;
                    grid[0, 5] = 3;
                    grid[1, 5] = 3;
                    grid[2, 5] = 3;
                    grid[3, 5] = 3;
                    grid[7, 5] = 3;
                    grid[8, 5] = 3;
                    grid[9, 5] = 3;
                    grid[0, 6] = 3;
                    grid[1, 6] = 3;
                    grid[2, 6] = 3;
                    grid[3, 6] = 3;
                    grid[4, 6] = 3;
                    grid[5, 6] = 3;
                    grid[6, 6] = 3;
                    grid[7, 6] = 3;
                    grid[8, 6] = 3;
                    grid[9, 6] = 3;
                    grid[5, 2] = 2;
                    grid[5, 4] = 1;



                    break;

                case 2:
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "yoink");
                    player.setcoords(6, 3);
                    enemy[0].setcoords(0, 0);
                    currentStage = 2;
                    setBackground(currentStage);
                    grid[6, 3] = 1;
                    grid[0, 0] = 2;
                    grid[5, 3] = 3;
                    grid[4, 5] = 4;
                    grid[4, 3] = 4;
                    grid[5, 2] = 3;
                    grid[4, 2] = 3;
                    break;

                case 3:
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "CoVid");
                    enemy[1] = new GameEntity(Klasse.Klassen.Virus, "yeee");
                    enemy[2] = new GameEntity(Klasse.Klassen.Virus, "Corona");
                    player.setcoords(8, 5);
                    enemy[0].setcoords(1, 7);
                    enemy[1].setcoords(6, 3);
                    enemy[2].setcoords(8, 3);
                    currentStage = 3;
                    setBackground(currentStage);
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            grid[i, j] = 5;
                        }
                    }
                    break;
                case 4:
                    player.setcoords(5, 4);
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "yoink");
                    enemy[0].setcoords(5, 2);
                    currentStage = 4;
                    setBackground(currentStage);
                    break;
                case 5:
                    player.setcoords(5, 4);
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "yoink");
                    enemy[0].setcoords(5, 2);
                    currentStage = 5;
                    setBackground(currentStage);
                    break;
                case 6:
                    player.setcoords(5, 4);
                    enemy[0] = new GameEntity(Klasse.Klassen.Virus, "yoink");
                    enemy[0].setcoords(5, 2);
                    currentStage = 6;
                    setBackground(currentStage);
                    break;
            }
        }
        private void drawMap()
        {
            Graphics g = panelMap.CreateGraphics();
            //Location werte werden mit 125 multipliziert => Position im Grid angeben (10*7)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (grid[i, j] != 0 && grid[i, j] != 1)
                        drawEntity(g, spriteHelper.getSprite(i, j, grid), i, j);
                    if (grid[i, j] == 1)
                        drawEntity(g, spriteHelper.getCombatSprite(player.getClass()), i, j);
                }
            }
            g.Dispose();
        }

        private void setBackground(int x)
        {
            panelMap.BackgroundImage = spriteHelper.getBackground(x);
            panelMap.Refresh();
        }

        private void refreshField(int locationX, int locationY)
        {
            int pixelX = locationX * fieldsize;
            int pixelY = locationY * fieldsize;
            Graphics g = panelMap.CreateGraphics();
            Bitmap bmp = new Bitmap(spriteHelper.getBackground(currentStage));
            g.DrawImage(bmp, pixelX, pixelY, new Rectangle(pixelX, pixelY, fieldsize, fieldsize), GraphicsUnit.Pixel);
            g.Dispose();
        }
        private void panelInv_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelInv.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);
            g.DrawRectangle(p, 38, 38, 250 , 250);
            g.DrawLine(p, 163, 38, 163, 288);
            g.DrawLine(p, 38, 163, 288, 163);
            g.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void drawEntity(Graphics g, Bitmap bild, int locationX, int locationY)
        {
            locationX *= fieldsize;
            locationY *= fieldsize;
            g.DrawImage(bild, locationX, locationY);
        }

        private double distance(int pointAx, int pointAy, int pointBx, int pointBy) //Distanz zwischen 2 Punkten berechnen
        {
            return Math.Sqrt(Math.Pow(pointAx - pointBx, 2) + Math.Pow(pointAy - pointBy, 2));
        }

        private void movePlayer(int xMove, int yMove)
        {
            Graphics g = panelMap.CreateGraphics();
            if ((int)distance(xMove, yMove, player.getx(), player.gety()) == 1) //Check if Spieler in ein valides Feld geclickt hat (Distanzcheck)
            {
                if (grid[xMove, yMove] == 0) //Check if Spieler ein valides Feld geclickt hat (Hindernischeck)
                {
                    grid[player.getx(), player.gety()] = 0;
                    grid[xMove, yMove] = 1;
                    refreshField(player.getx(), player.gety());
                    drawEntity(g, spriteHelper.getCombatSprite(player.getClass()), xMove, yMove);
                    player.setcoords(xMove, yMove);
                }
            }
            moveEnemy();
            for(int i = 0; i < 5; i++)
            {
                if (enemy[i] != null)
                {
                    if ((int)distance(player.getx(), player.gety(), enemy[i].getx(), enemy[i].gety()) == 1)
                    {
                        if (fight == null)
                            fight = new Combat();
                        currentfighter = i;
                        fight.getItem(1);
                        fight.begin(enemy[i], player, combatPanel, subject, progressBarPlayer, progressBarEnemy);
                        break;
                    }
                }
            }
            g.Dispose();
        }

        private void moveEnemy()
        {

        }
        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            movePlayer(e.X / fieldsize, e.Y / fieldsize);
        }

        public bool combatActive()
        {
            return combatPanel.Visible;
        }

        public void combatFinished(GameEntity winner)
        {
            if (winner.getClass() != Klasse.Klassen.Virus)
            {
                MessageBox.Show(winner.getName() + " won the fight");
                grid[enemy[currentfighter].getx(), enemy[currentfighter].gety()] = 0;
                enemy[currentfighter] = null;
                progressBarEnemy.Value = 0;

                if (!enemiesleft())
                {
                    startNextStage();
                }
                
            }
        }

        private void startNextStage()
        {
            fight = null;
            combatPanel.Hide();
            //drawMap();
            gameStart(currentStage + 1);
        }

        public void addtoList(string ay)
        {
            listBox1.Items.Insert(0, ay);
        }

        public void showItems(int[] itemArray)
        {
            Graphics g = panelInv.CreateGraphics();
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i] != 0)
                {
                    switch (i)
                    {
                        case 0:
                            g.DrawImage(Resources.Resource1.Mundschutz, 38, 38);
                            break;
                        case 1:
                            g.DrawImage(Resources.Resource1.Feuerzeug, 38+125, 38);
                            break;
                        case 2:
                            g.DrawImage(Resources.Resource1.Spritze, 38, 38+125);
                            break;
                        case 3:
                            g.DrawImage(Resources.Resource1.Crocs, 38+125, 38+125);
                            break;
                    }
                }
            }
            g.Dispose();
        }

        private bool enemiesleft()
        {
            bool yoink = false;
            foreach (var item in enemy)
            {
                if (item != null)
                    yoink = true;
            }
            return yoink;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (!combatActive() && !storyActive)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (player.gety() - 1 >= 0)
                    {
                        movePlayer(player.getx(), player.gety() - 1);
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (player.gety() + 1 < 7)
                    {
                        movePlayer(player.getx(), player.gety() + 1);
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (player.getx() - 1 >= 0)
                    {
                        movePlayer(player.getx() - 1, player.gety());
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (player.getx() + 1 < 10)
                    {
                        movePlayer(player.getx() + 1, player.gety());
                    }
                }
                
            }
            else
            {
                if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                {
                    fight.attack();
                }
                else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                {
                    fight.shield();
                }
                else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                {
                    fight.items();
                }
                else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                {
                    fight.run();
                }
            }
            if (storyActive && e.KeyCode == Keys.Space)
            {
                panelStory.Hide();
                storyActive = false;
                currentStage++;
                initGrid(currentStage);
                drawMap();
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                player.setName(tbNameInput.Text);
                panelMain.Hide();
                panelGame.Show();
                lblName.Text = player.getClass().ToString() + player.getName();
                gameStart(1);
            }
            catch(Exception)
            {
                tbNameInput.Text = "";
                btnStart_Click(this, e);
            }
        }

        private void btnClassVirologe_Click(object sender, EventArgs e)
        {
            player.setClass(Klasse.Klassen.Virologe);
        }

        private void btnClassNormal_Click(object sender, EventArgs e)
        {
            player.setClass(Klasse.Klassen.Normalbürger);
        }

        private void btnClassLeugner_Click(object sender, EventArgs e)
        {
            player.setClass(Klasse.Klassen.Coronaleugner);
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            // TODO: Set the correct highscore
            new Highscore(this.player.getName(), 0).ShowDialog();
        }
    }


}
