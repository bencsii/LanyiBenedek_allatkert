using allatkert_feladat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert_feladat
{
    internal class Allatkert
    {
        Random random = new Random();

        List<Capa> capa = new List<Capa>();
        List<Oroszlan> oroszlan = new List<Oroszlan>();
        List<Pingvin_class> pingiv = new List<Pingvin_class>();
        List<Szkolopendra> szkolopendra = new List<Szkolopendra>();
        List<Tigris> tigris = new List<Tigris>();

        private int hely;

        public void peldanyosit()
        {
            capa.Add(new Capa("Capi", 23, "him"));
            oroszlan.Add(new Oroszlan("Oroszlany", 14, "nosteny"));
            pingiv.Add(new Pingvin_class("Pingu", 50, "him"));
            szkolopendra.Add(new Szkolopendra("valaminev", 5, "nosteny"));
            tigris.Add(new Tigris("Diego", 75, "him"));
        }

        private int mennyiseg;

        public void telitettseg()
        {
            hely = random.Next(5, 16);
            mennyiseg = capa.Count + oroszlan.Count + pingiv.Count + szkolopendra.Count + tigris.Count;

            for (int i = 0; i < hely; i++)
            {
                if (i < mennyiseg)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine($"Allatkert ferohelye: {hely} allatok mennyisege: {mennyiseg}");
        }

        public void race()
        {
            int allat1 = random.Next(0, 5);
            int allat2 = random.Next(0, 5);


            bool stop = false;
            string nyertes = "";
            int endRace = 60;

            int lepes1 = 0;
            int lepes2 = 0;

            string[] allatNev = new string[5]
            {
                capa[0].Nev,
                oroszlan[0].Nev,
                pingiv[0].Nev,
                szkolopendra[0].Nev,
                tigris[0].Nev
            };

            int[] sebesseg = new int[5]
            {
                capa[0].Sebesseg,
                oroszlan[0].Sebesseg,
                pingiv[0].Sebesseg,
                szkolopendra[0].Sebesseg,
                tigris[0].Sebesseg
            };


            while (!stop)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(allatNev[allat1]);
                Console.SetCursorPosition(lepes1 += sebesseg[allat1], 0);
                Console.Write("O");
                if (Console.GetCursorPosition().Left >= endRace)
                {
                    stop = true;
                    nyertes = allatNev[allat1];
                }

                Console.SetCursorPosition(0, 1);
                Console.WriteLine(allatNev[allat2]);
                Console.SetCursorPosition(lepes2 += sebesseg[allat2], 1);
                Console.Write("O");
                if (Console.GetCursorPosition().Left >= endRace)
                {
                    stop = true;
                    nyertes = allatNev[allat2];
                }
            }

            Console.WriteLine($"\n{nyertes} nyerte a versenyt");
        }
    }
}
