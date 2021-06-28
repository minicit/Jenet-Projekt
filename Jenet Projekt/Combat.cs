using Jenet_Projekt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Jenet_Projekt
{
    class Combat
    {
        private SpriteHelper spriteHelper = new SpriteHelper();
        private bool combatActive;
        private GameEntity enemy, player;
        private int turn; //zug variable; 1:spieler, 2:Gegner, 3:Kampfende?
        private Random rand = new Random();
        private ProgressBar playerbar, enemybar;
        private Eventcaller subject;
        private Panel combatPanel;
        private int[] itemArray = new int[5];
        public void begin( GameEntity emy, GameEntity ply, Panel combatPanel, Eventcaller subject, ProgressBar playerbar, ProgressBar enemybar)
        {
            this.enemy = emy;
            this.player = ply;
            this.playerbar = playerbar;
            this.enemybar = enemybar;
            this.subject = subject;
            this.combatPanel = combatPanel;
            combatActive = true;
            Graphics g = combatPanel.CreateGraphics();
            combatPanel.BackgroundImage = spriteHelper.getBackground(-1);
            combatPanel.Show();

            playerbar.Maximum = (int)player.getMaxHealth();
            enemybar.Maximum = (int)enemy.getMaxHealth();
            playerbar.Value = (int)player.getHealth();
            enemybar.Value = (int)enemy.getHealth();
            drawFight(g, enemy, player);
            g.Dispose();
        }

        public void getItem(int type)
        {
            itemArray[type-1]++;
        }

        public void useItem(int type)
        {
            if (itemArray[type - 1] != 0)
            {
                itemArray[type - 1]--;
            }
        }

        private void drawFight(Graphics g, GameEntity enemy, GameEntity player)
        {
            g.DrawImage(spriteHelper.getCombatSprite(player.getClass()), 170, 600);
            g.DrawImage(spriteHelper.getCombatSprite(enemy.getClass()), 950, 150);

        }

        private void enemyAction()
        {
            if(((enemy.getHealth()/enemy.getMaxHealth())*100) > rand.Next(100))
            {
                enemyShield();
                //MessageBox.Show("shielded!");
            }
            else
            {
                enemyAttack();
                //MessageBox.Show("ATTAAACK");
            }
        }

        private void fightSprite(Bitmap sprite)
        {
            Graphics g = combatPanel.CreateGraphics();
            g.DrawImage(sprite, 600, 400);
            System.Threading.Thread.Sleep(1000);
            g.DrawImage(spriteHelper.getBackground(-1), new Rectangle(600, 400, sprite.Width, sprite.Height), new Rectangle(476, 200, sprite.Width, sprite.Height), GraphicsUnit.Point);
        }

        public bool getCombatActive() { return combatActive; }

        public void setCombatActive(bool active) { combatActive = active; }

        public void setTurn(int turn) { this.turn = turn; }

        public int getTurn() { return turn; }

        private void enemyAttack()
        {
            //enemy.setShield(false);
            if (enemy.doesItHit(enemy, player))
            {
                player.takeDamageFrom(enemy);
                if (player.getHealth() > 0)
                    playerbar.Value = (int)player.getHealth();
                fightSprite(Resources.Resource1.OOF);
            }
            //else
            //    enemy.takeDamageFrom(enemy); //vllt? quasi verwirrung ohne statusveränderung?
        }

        private void enemyShield()
        {
            enemy.setShield(true);
            fightSprite(Resources.Resource1.Schild);
        }

        public void attack()
        {
            if (player.getSpeed() >= enemy.getSpeed())
            {
                player.setShield(false);
                if (player.doesItHit(player, enemy))
                {
                    enemy.takeDamageFrom(player);
                    if (enemy.getHealth() > 0)
                        enemybar.Value = (int)enemy.getHealth();
                    fightSprite(Resources.Resource1.Pow);
                }
                else
                {
                    //MessageBox.Show("misssd");
                    fightSprite(Resources.Resource1.Missed);
                }
                enemyAction();
            }
            else
            {
                enemyAction();
                player.setShield(false);
                if (player.doesItHit(player, enemy))
                {
                    enemy.takeDamageFrom(player);
                    if (enemy.getHealth() > 0)
                        enemybar.Value = (int)enemy.getHealth();
                    fightSprite(Resources.Resource1.Pow);
                }
                else
                {
                    //MessageBox.Show("misssd");
                    fightSprite(Resources.Resource1.Missed);
                }
            }
            combatOverCheck();
        }

        public void shield()
        {
            player.setShield(true);
            //MessageBox.Show("*spray desinfection spray like febreeze*");
            fightSprite(Resources.Resource1.Schild);
        }

        public void items()
        {
            MessageBox.Show("shoe");
            player.setShield(false);
            //wird ein Item eingesetzt muss shield auf false gesetzt werden
        }

        public void run()
        {
            //player.setShield(false);
            if (player.doesItHit(player, enemy))
                MessageBox.Show("runn");
            else
                MessageBox.Show("you decided to stay. Why?");
        }

        private void combatOverCheck()
        {
            if (enemy.getHealth() <= 0)
            {
                setCombatActive(false);
                subject.PlayerWon(player);
            }
            if (player.getHealth() <= 0)
            {
                setCombatActive(false);
                subject.EnemyWon(enemy);
            }
        }
    }
}
