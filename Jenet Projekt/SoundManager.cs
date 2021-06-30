using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Jenet_Projekt
{
    class SoundManager
    {
        private SoundPlayer player;

        public void Stop()
        {
            player.Stop();
        }
        public void MainMenuMusic()
        {
            player = new SoundPlayer(Resources.Sounds.MainMenuMusic);
            player.PlayLooping();
        }
        public void GameMusic()
        {
            player = new SoundPlayer(Resources.Sounds.GameMusic);
            player.PlayLooping();
        }
        public void CombatMusic()
        {
            SoundPlayer player = new SoundPlayer(Resources.Sounds.CombatMusic);
            player.PlayLooping();
        }
        public void OnHit()
        {

        }
        public void OnMove()
        {

        }
    }
}
