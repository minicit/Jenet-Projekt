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
    public partial class Form1 : Form
    {

        int[,] grid = new int[10, 7]; // Array speichert Positionen in der Karte
        private int fieldsize = 125; //Größe eines Feldes in px 
        private SpriteHelper spriteHelper = new SpriteHelper();
        private GameEntity player = new GameEntity(GameEntity.Klassen.Normalbürger, "Test");
        private GameEntity[] enemy;
        private int currentStage;
        private int invX = 3;
        private int invY = 4;
        public Form1()
        {
            InitializeComponent();
            panelGame.Hide();
            CombatBox.Hide();
            enemy = new GameEntity[5];
            enemy[0] = new GameEntity(GameEntity.Klassen.Virus, "Virus");
            //panelMap.BackgroundImage = Resources.Resource1.MapBackground;
        }

        private void gameStart(int stage)
        {
            initGrid(stage);
            drawMap();
        }

        private void initGrid(int gridNo)
        {
            //Schreibt Startpositionen der Gegner / Spieler / Hindernisse in das Array
            // Wert 0 = frei
            // Wert 1 = Spieler
            // Wert 2 = Virus
            // Wert 3 = Hindernis
            // Bsp : grid[1,2] = 3; setzt ein Hindernis an die Position X = 1 / Y = 2
            // Erlaubte Positionen X : 0 - 9 
            // Erlaubte Positionen Y : 0 - 6
            Array.Clear(grid, 0, grid.Length);
            switch (gridNo)
            {
                case 1:
                    player.setcoords(7, 4);
                    enemy[0].setcoords(1, 1);
                    currentStage = 1;
                    setBackground(currentStage);
                    grid[7, 4] = 1;
                    grid[1, 1] = 2;
                    grid[5, 3] = 3;
                    grid[4, 5] = 3;
                    grid[4, 3] = 3;
                    break;

                case 2:

                    break;

                case 3:

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
                    if (grid[i, j] != 0)
                        drawEntity(g, spriteHelper.getSprite(i, j, grid), i, j);
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
            int startpunktx = 0;
            int startpunkty = 0;
            for (int j = 0; j < invX; j++)
            {
                for (int i = 0; i < invY; i++)
                {
                    g.DrawRectangle(Pens.Black, startpunktx, startpunkty, panelInv.ClientSize.Width / invY, panelInv.ClientSize.Height / 8);
                    startpunktx += panelInv.ClientSize.Width / invY;
                }
                startpunktx = 0;
                startpunkty += (panelInv.ClientSize.Height / 8) - 1;
            }
            //g.DrawLine(Pens.Black, 0, panel1.ClientSize.Height, panel1.ClientSize.Width, panel1.ClientSize.Height);
            //panel1.Refresh();
            g.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelMain.Hide();
            panelGame.Show();
            gameStart(1);
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
                    drawEntity(g, Resources.Resource1.virologeSpriteTrans, xMove, yMove);
                    player.setcoords(xMove, yMove);
                }
                
                    
            }
            moveEnemy();
            foreach (var item in enemy)
            {
                if (item != null)
                {
                    if ((int)distance(player.getx(), player.gety(), item.getx(), item.gety()) == 1)
                    {
                        Combat fight = new Combat();
                        GameEntity.Klassen winner = fight.begin(item, player, combatPanel);
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
            return CombatBox.Visible;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!combatActive())
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
        }
    }
}
