using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    public class GameEntity
    {
        private double health, maxHealth;
        private Klasse.Klassen entityclass;
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
        //public enum Klassen
        //{
        //    Virologe,
        //    Normalbürger,
        //    Coronaleugner,
        //    Virus
        //}

        public int getx() { return posx; }
        public int gety() { return posy; }

        private void setx(int x) { posx = x; }
        private void sety(int y) { posy = y; }

        public void setcoords(int x, int y)
        {
            setx(x);
            sety(y);
        }

        public GameEntity(Klasse.Klassen Klasse, string name) {
            entityclass = Klasse;
            username = name;
            setStartupModifiers(Klasse);
        }

        public Klasse.Klassen getClass()
        {
            return entityclass;
        }

        public void takeDamageFrom(GameEntity attacker)
        {
            double shield = 0;
            if (defending)
                shield = defence;

            health -= attacker.attack - shield;
            Main.getInstance().addtoList(attacker.getName().ToString() + " did damage to " + this.getName().ToString());
            Main.getInstance().addtoList(attacker.getHealth().ToString() + "Attacker health\n" + this.getHealth().ToString() + "Victim health");
            defending = false;
        }

        public void setShield(bool val) { defending = val; }

        public int getSpeed() { return speed; }

        public void heal(int amount)
        {
            health += amount;
        }

        public bool doesItHit(GameEntity attacker, GameEntity victim)
        {
            if ((attacker.speed / victim.speed) * 10 + rand.Next(40,60) > rand.Next(100))
                return true;
            return false;
        }

        public void setModifier(Modifiers modifiers, double value)
        {

        }

        public void setClass(Klasse.Klassen clazz)
        {
            entityclass = clazz;
        }

        public void setName(string name)
        {
            this.username = name;
        }

        public double getHealth() { return health; }

        public double getMaxHealth() { return maxHealth; }

        public void setAttack(double effect) { attack = effect; }

        public void takeDamage(double effectDamage) { health -= effectDamage; }

        public void setStartupModifiers(Klasse.Klassen x) //Implement modifier selection
        {
            switch (x)
            {
                case Klasse.Klassen.Virus:
                    maxHealth = 20;
                    health = maxHealth;
                    speed = 7;
                    attack = 8;
                    defence = 2;
                    break;
                case Klasse.Klassen.Virologe:
                    maxHealth = 100;
                    health = maxHealth;
                    speed = 10;
                    attack = 10;
                    defence = 5;
                    break;
                case Klasse.Klassen.Normalbürger:
                    maxHealth = 50;
                    health = maxHealth;
                    speed = 10;
                    attack = 3;
                    defence = 5;
                    break;
                case Klasse.Klassen.Coronaleugner:
                    maxHealth = 20;
                    health = maxHealth;
                    speed = 10;
                    attack = 1;
                    defence = 3;
                    break;
            }
        }

        public string getName() { return username; }
    }
}
