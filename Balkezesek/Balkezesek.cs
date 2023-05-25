using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    internal class Balkezesek
    {
        string nev;
        string elso;
        string utolso;
        int suly;
        int magassag;

        public Balkezesek(string nev, string elso, string utolso, int suly, int magassag)
        {
            this.nev = nev;
            this.elso = elso;
            this.utolso = utolso;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; }
        public string Elso { get => elso; }
        public string Utolso { get => utolso; }
        public int Suly { get => suly; }
        public int Magassag { get => magassag; }
    }
}
