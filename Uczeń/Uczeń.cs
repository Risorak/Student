using System;
using System.Collections.Generic;
using System.Text;

namespace Uczeń
{
    class Uczeń
    {
        private double ocena1, ocena2;
        private string nazwisko;

       public Uczeń(double ocena1, double ocena2, string nazwisko)
        {
            this.ocena1 = ocena1;
            this.ocena2 = ocena2;
            this.nazwisko = nazwisko;
        }

        public double średnia()
        {
            return (ocena1 + ocena2) / 2;
        }

        public override string ToString()
        {
            return $"Nazwisko ({nazwisko}) ocena 1: ({ocena1}) ocena2: ({ocena2})";
        }

    }
}
