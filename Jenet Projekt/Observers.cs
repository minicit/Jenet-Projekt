using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jenet_Projekt
{
    public interface IObserver
    {
        void PlayerWon(GameEntity subject);
        void EnemyWon(GameEntity subject);
    }

    public interface IEventcaller
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);
    }

    public class Eventcaller : IEventcaller
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void EnemyWon(GameEntity enemy)
        {
            foreach (var observer in _observers)
            {
                observer.EnemyWon(enemy);
            }
        }
        public void PlayerWon(GameEntity player)
        {
            foreach (var observer in _observers)
            {
                observer.PlayerWon(player);
            }
        }
    }

    class CombatObserver : IObserver
    {
        public CombatObserver()
        {

        }
        public void PlayerWon(GameEntity subject)
        {
            Main.getInstance().combatFinished(subject);
        }

        public void EnemyWon(GameEntity subject)
        {
            Main.getInstance().combatFinished(subject);
        }
    }
}
