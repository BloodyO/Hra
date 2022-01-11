using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_2_MiniHra
{
    class Lokace
    {
        public string nazevLokace;
        public string popis;


      
        public Lokace sever;
        public Lokace jih;
        public Lokace vychod;
        public Lokace zapad;

        public Lokace(string nazevLokace, string popis)
        {
            this.nazevLokace = nazevLokace;
            this.popis = popis;
        }

        public override string ToString()
        {
            string vystup = nazevLokace + "\n";
            vystup += popis + "\n";
            string smery = "";
            if (sever != null)
                smery += "sever ";
            if (jih != null)
                smery += "jih ";
            if (zapad != null)
                smery += "západ ";
            if (vychod != null)
                smery += "východ ";
            vystup += "\nMůžeš jít na " + smery + "\n";
            return vystup;
        }

    }
}
