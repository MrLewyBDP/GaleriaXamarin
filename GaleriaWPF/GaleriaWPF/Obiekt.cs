using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaWPF
{
    public class Obiekt
    {
        public string[] Podzial { get; set; }
        public string[] zdjeciaPodzial { get; set; }
        public PodObiekt[] podPodzial { get; set; }

        public Obiekt(string[] Podzial, string[] zdjeciaPodzial, PodObiekt[] podPodzial)
        {
            this.Podzial = Podzial;
            this.zdjeciaPodzial = zdjeciaPodzial;
            this.podPodzial = podPodzial;
        }
    }

    public class PodObiekt
    {
        public int podzial { get; set; }
        public string nazwa { get; set; }
        public string zdjecie { get; set; }
        public string opis { get; set; }

        public PodObiekt(int podzial, string nazwa, string zdjecie, string opis)
        {
            this.podzial = podzial;
            this.nazwa = nazwa;
            this.zdjecie = zdjecie;
            this.opis = opis;
        }
    }
}
