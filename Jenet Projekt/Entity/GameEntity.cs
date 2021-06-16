using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    class GameEntity
    {
        private double health;
        private Klassen entityclass;
        private string username;
        private double[] modifiers = new double[3];
        private int posx;
        private int posy;
        private int speed; //speed: chance to hit, to get hit (get hit /3 ?), to flee
        private double attack; // enemyHealth-attack
        private double defence; // enemyAttack-defence
        private bool defending = false; //wird für eine Runde gesetzt wenn Verteigen ausgewählt wird
        Random rand = new Random();
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

        public int getx() { return posx; }
        public int gety() { return posy; }

        private void setx(int x) { posx = x; }
        private void sety(int y) { posy = y; }

        public void setcoords(int x, int y)
        {
            setx(x);
            sety(y);
        }

        public GameEntity(Klassen Klasse, string name) {
            entityclass = Klasse;
            username = name;
            setStartupModifiers(Klasse);
        }

        public Klassen getClass()
        {
            return entityclass;
        }

        public void takeDamageFrom(GameEntity attacker)
        {
            double shield = 0;
            if (defending)
                shield = defence;

            health -= (attacker.attack * modifiers[(int)Modifiers.damageTaken]) - shield;
            defending = false;
        }

        public void setShield(bool shield)
        {
            defending = shield;
        }

        public void healDamage(int amount)
        {
            health += amount;
        }

        public bool doesItHit(GameEntity attacker, GameEntity victim)
        {
            if ((((attacker.speed - victim.speed) * 10) + 5) > rand.Next(100))
                return true;
            return false;
        }

        public void setModifier(Modifiers modifiers, double value)
        {

        }

        public double getHealth()
        {
            return health;
        }

        public void setStartupModifiers(Klassen Klasse) //Implement modifier selection
        {
            switch (Klasse)
            {
                case Klassen.Virus:
                    health = 20;
                    speed = 4;
                    attack = 2;
                    defence = 2;
                    break;
                case Klassen.Virologe:
                    health = 100;
                    speed = 10;
                    attack = 10;
                    defence = 5;
                    break;
                case Klassen.Normalbürger:
                    health = 50;
                    speed = 10;
                    attack = 5;
                    defence = 5;
                    break;
                case Klassen.Coronaleugner:
                    health = 20;
                    speed = 10;
                    attack = 3;
                    defence = 3;
                    break;
            }
        }
    }
}
