using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    class Spielfeld
    {
        enum Spielobjekte
        {
            Spieler,
            Virus,
            Start,
            Ziel,
            Item,
            Berg,
            Hurensohn,
            leer
        }

        class Spielobject
        {
            static Spielobject LEER = new Spielobject(Pens.Black);


            private Spielobject(Pen farbe)
            {
                Farbe = farbe;
            }

            public Pen Farbe { get; }
        }

        Enum[,] spielfeld1 = new Enum[,]    {
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            };

        Enum[,] spielfeld2 = new Enum[,]    {
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            };

        Enum[,] spielfeld3 = new Enum[,]    {
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            };

        Enum[,] spielfeld4 = new Enum[,]    {
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            { Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer, Spielobjekte.leer},
                                            };

        public Enum[,] getMap1() {
            return spielfeld1;
            }

        public Enum[,] getMap2()
        {
            return spielfeld2;
        }

        public Enum[,] getMap3()
        {
            return spielfeld3;
        }

        public Enum[,] getMap4()
        {
            return spielfeld4;
        }
    }

}
