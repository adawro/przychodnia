using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia
{
    class Lekarz : Osoba
    {
        private string specjalnosc;

        public Lekarz() { }

        public Lekarz(string imie, string nazwisko, string specjalnosc)
            :base(imie,nazwisko)
        {
            this.specjalnosc = specjalnosc;
        }
        public override string ToString()
        {
            return $"Imie: {imie} {nazwisko}, Specjalnosc: {specjalnosc}\n";
        }
    }
}
