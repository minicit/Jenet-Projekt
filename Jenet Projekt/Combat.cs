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
        public GameEntity.Klassen begin(GameEntity enemy, GameEntity player, PictureBox CombatBox)
        {
            combatActive = true;
            Graphics g = CombatBox.CreateGraphics();
            CombatBox.BackgroundImage = spriteHelper.getBackground(2);

            CombatBox.Show();
            drawFight(g, enemy, player);

            g.Dispose();
            CombatBox.Hide();
            combatActive = false;
            return GameEntity.Klassen.Virologe; //return enum type of winner
        }

        private void drawFight(Graphics g, GameEntity enemy, GameEntity player)
        {
            g.DrawImage(spriteHelper.getCombatSprite(player.getClass()), 100, 1000);
            g.DrawImage(spriteHelper.getCombatSprite(enemy.getClass()), 55, 55);
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
    }
}
