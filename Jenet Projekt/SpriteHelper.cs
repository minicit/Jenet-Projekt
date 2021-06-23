using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    class SpriteHelper
    {

        public Bitmap getSprite(int x, int j, int[,] grid)
        {
            switch (grid[x, j])
            {
                case 1:
                    return Resources.Resource1.virologeSpriteTrans;
                case 2:
                    return Resources.Resource1.virusSpriteTrans;
                case 3:
                    return Resources.Resource1.forrestSprite;
                case 4:
                    return Resources.Resource1.Sprite_0002;
            }
            return null;
        }

        public Bitmap getCombatSprite(Klasse.Klassen player)
        {
            switch (player)
            {
                case Klasse.Klassen.Coronaleugner:
                    return Resources.Resource1.leugnerSpriteTrans;
                case Klasse.Klassen.Normalbürger:
                    return Resources.Resource1.normalboiSpriteTrans;
                case Klasse.Klassen.Virologe:
                    return Resources.Resource1.virologeSpriteTrans;
                case Klasse.Klassen.Virus:
                    return Resources.Resource1.virusSpriteTrans;
            }
            return null;
        }
        
        public Bitmap getBackground(int x)
        {
            switch (x)
            {
                case 2:
                    return Resources.Resource1.combatBackgroundMitMenu;
                case 1:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 0:
                    return Resources.Resource1.MapBackground;
            }
            return null;
        }

    }
}
