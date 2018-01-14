using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia
{
    class Pacjent:Osoba
    {
        private string choroba;
        private int wiek;

        public Pacjent() { }

        public Pacjent(string imie, string nazwisko, int wiek, string choroba)
            :base (imie,nazwisko)
        {
            this.choroba = choroba;
            this.wiek = wiek;
        }

        public override string ToString()
        {
            return $"Pacjent: {imie} {nazwisko}, wiek {wiek}, choroba: {choroba}";
        }

    }
}
