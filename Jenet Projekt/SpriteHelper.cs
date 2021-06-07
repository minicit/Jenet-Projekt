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
                    return Resources.Resource1.Sprite_0001;
                case 2:
                    return Resources.Resource1.Sprite_0002;
                case 3:
                    return Resources.Resource1.Sprite_0002;
            }
            return null;
        }

        public Bitmap getBackground(int x)
        {
            switch (x)
            {
                case 1:
                    return Resources.Resource1.Hintergrund_base;
                case 0:
                    return Resources.Resource1.MapBackground;
            }
            return null;
        }

    }
}
