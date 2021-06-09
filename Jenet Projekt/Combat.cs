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
        public GameEntity.Klassen begin(GameEntity enemy, GameEntity player, Panel combatPanel)
        {
            Graphics g = combatPanel.CreateGraphics();
            combatPanel.BackgroundImage = spriteHelper.getBackground(2);

            combatPanel.Show();
            drawFight(g, enemy, player);

            g.Dispose();

            return GameEntity.Klassen.Virologe; //return enum type of winner
        }

        private void drawFight(Graphics g, GameEntity enemy, GameEntity player)
        {
            //g.DrawImage(spriteHelper.getCombatSprite(player.getClass()), 15, 17);
            g.DrawImage(Resources.Resource1.Sprite_0001, 15, 17);
            g.DrawImage(spriteHelper.getCombatSprite(enemy.getClass()), 55, 55);
        }
    }
}
