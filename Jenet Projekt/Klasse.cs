using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    public class Klasse
    {
        Klassen Entityclass;

        public enum Klassen
        {
            Virologe,
            Normalbürger,
            Coronaleugner,
            Virus,
            Bat
        }
        public void setClass(Klassen k)
        {
            Entityclass = k;
        }
        public Klassen getClass()
        {
            return Entityclass;
        }
    }
}
