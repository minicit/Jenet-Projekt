using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    class Spielfeld
    {
        enum spielobjekte
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

        Enum[,] spielfeld1 = new Enum[,]    { 
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            };

        Enum[,] spielfeld2 = new Enum[,]    {
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            };

        Enum[,] spielfeld3 = new Enum[,]    {
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            };

        Enum[,] spielfeld4 = new Enum[,]    {
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            { spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer, spielobjekte.leer},
                                            };
    }
}
