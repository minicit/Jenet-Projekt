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
        private int turn;
        public GameEntity.Klassen begin(GameEntity enemy, GameEntity player, Panel combatPanel)
        {
            this.enemy = enemy;
            this.player = player;
            combatActive = true;
            Graphics g = combatPanel.CreateGraphics();
            combatPanel.BackgroundImage = spriteHelper.getBackground(2);

            combatPanel.Show();
            drawFight(g, enemy, player);

            g.Dispose();
            
            //falls player oder virus health <1
            //combatPanel.Hide();

            combatActive = false;
            if(player.getHealth() <= 0)
                return enemy.getClass(); //return enum type of winner
            else
                return enemy.getClass();
        }

        private void drawFight(Graphics g, GameEntity enemy, GameEntity player)
        {
            g.DrawImage(spriteHelper.getCombatSprite(player.getClass()), 170, 600);
            g.DrawImage(spriteHelper.getCombatSprite(enemy.getClass()), 950, 150);

        }

        private void hit(Graphics g)
        {
            g.DrawImage(Resources.Resource1.Sprite_0001, 600, 400);
        }

        private void oof(Graphics g)
        {
            g.DrawImage(Resources.Resource1.Sprite_0001, 600, 400);
        }

        public bool getCombatActive()
        {
            return combatActive;
        }

        public void setCombatActive(bool active)
        {
            combatActive = active;
        }

        public void setTurn(int turn)
        {
            this.turn = turn;
        }

        private void enemyAttack()
        {
            enemy.setShield(false);
            if (enemy.doesItHit(enemy, player))
                player.takeDamageFrom(enemy);
            else
                enemy.takeDamageFrom(enemy); //vllt?
        }

        private void enemyShield()
        {
            enemy.setShield(true);
        }

        public void attack()
        {
            player.setShield(false);
            if (player.doesItHit(player, enemy))
                MessageBox.Show("atteck");
            else
                MessageBox.Show("misssd");
        }

        public void shield()
        {
            player.setShield(true);
            MessageBox.Show("*spray desinfection spray like febreeze*");
        }

        public void items()
        {
            MessageBox.Show("shoe");
            //wird ein Item eingesetzt muss shield auf false gesetzt werden
        }

        public void run()
        {
            player.setShield(false);
            if (player.doesItHit(player, enemy))
                MessageBox.Show("runn");
            else
                MessageBox.Show("you decided to stay. Why?");
        }
    }
}
