using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_2_MiniHra
{
    class Hra
    {
        public Lokace aktualniLokace;

        public Hra()
        {

            Lokace hrad = new Lokace("Hrad", "Stojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná.");
            Lokace les1 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace les2 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace les3 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace lesniRozcesti = new Lokace("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
            Lokace rybnik = new Lokace("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.");
            Lokace dum = new Lokace("Dům", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, která se line z hromady vedle vstupních dveří.");

            dum.zapad = les1;
            les1.vychod = dum;
            les1.sever = lesniRozcesti;
            lesniRozcesti.jih = les1;
            lesniRozcesti.zapad = les2;
            lesniRozcesti.vychod = les3;
            les2.zapad = hrad;
            les2.vychod = lesniRozcesti;
            hrad.vychod = les2;
            les3.zapad = lesniRozcesti;
            les3.vychod = rybnik;
            rybnik.zapad = les3;

            aktualniLokace = dum;
        }

        public void Prikaz(string prikaz)
        {
            prikaz = prikaz.ToLower();
            if (prikaz.StartsWith("jdi"))
            {
                if ((prikaz.EndsWith("sever")) && (aktualniLokace.sever != null))
                    aktualniLokace = aktualniLokace.sever;
                else if ((prikaz.EndsWith("jih")) && (aktualniLokace.jih != null))
                    aktualniLokace = aktualniLokace.jih;
                else if ((prikaz.EndsWith("zapad")) || (prikaz.EndsWith("západ")) && (aktualniLokace.zapad != null))
                    aktualniLokace = aktualniLokace.zapad;
                else if ((prikaz.EndsWith("vychod")) || (prikaz.EndsWith("východ")) && (aktualniLokace.vychod != null))
                    aktualniLokace = aktualniLokace.vychod;
                else
                    Console.WriteLine("Tímto směrem nelze jít.");
            }
            else if (prikaz != "konec")
                Console.WriteLine("Můj vstupní slovník neobsahuje tento příkaz.");

        }

    }
}
