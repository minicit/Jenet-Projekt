using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    abstract class GameEntity
    {
        private double health;
        private Klassen entityclass;
        private string username;
        private double[] modifiers = new double[3];
        public enum Modifiers
        {
            health,
            damageTaken,
            damageDealt
        }
        public enum Klassen
        {
            Virologe,
            Normalbürger,
            Coronaleugner,
            Virus
        }

        public GameEntity(Klassen Klasse, string name) {
            entityclass = Klasse;
            username = name;
            setStartupModifiers(Klasse);
        }

        public void takeDamage(int amount)
        {
            health -= amount * modifiers[(int)Modifiers.damageTaken];
        }
        public void healDamage(int amount)
        {
            health += amount;
        }

        public void setModifier(Modifiers modifiers, double value)
        {

        }

        public void setStartupModifiers(Klassen Klasse) //Implement modifier selection
        {
            switch (Klasse)
            {
                case Klassen.Virus:
                    break;
                case Klassen.Virologe:
                    break;
                case Klassen.Normalbürger:
                    break;
                case Klassen.Coronaleugner:
                    break;
            }
        }
    }
}
