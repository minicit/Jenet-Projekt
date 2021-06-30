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

        public Bitmap getSprite(int x, int j, int[,] grid, Klasse.Klassen player, int stage)
        {
            switch (grid[x, j])
            {
                case 1:
                    return Resources.Resource1.virologeSpriteTrans;
                case 2:
                    if (player == Klasse.Klassen.Coronaleugner)
                        return Resources.Resource1.Verkleidetes_Virus;
                    return Resources.Resource1.virusSpriteTrans;
                case 3:
                    return Resources.Resource1.forrestSprite;
                case 4:
                    return Resources.Resource1.Gebirge;
                case 5:
                    return Resources.Resource1.deepBatTrans;
                case 6:
                    return Resources.Resource1.Straße_horizontal;
                case 7:
                    return Resources.Resource1.Straße_vertikal;
                case 8:
                    return Resources.Resource1.Straße_Kreuzung_Sprite;
                case 9:
                    return Resources.Resource1.haus;
            }
            return null;
        }

        public Bitmap getCombatSprite(Klasse.Klassen player, Klasse.Klassen chosenClass)
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
                case Klasse.Klassen.Bat:
                    return Resources.Resource1.deepBatTrans;
            }
            return null;
        }
        
        public Bitmap getBackground(int x)
        {
            switch (x)
            {
                case -1:
                    return Resources.Resource1.combatBackgroundMitMenu;
                case 6:
                    return Resources.Resource1.batRound;
                case 5:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 4:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 3:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 2:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 1:
                    return Resources.Resource1.Hintergrund_mapGrass;
                case 0:
                    return Resources.Resource1.MapBackground;
            }
            return null;
        }

    }
}
