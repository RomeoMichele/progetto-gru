using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gru
    {
        private static int s_serialNumberSeed = 1234567890;

        public string NumeroSeriale { get; }
        public string Produttore { get; }

        public int PesoMax { get; }
        public int AltezzaMax { get; }
        public int AltezzaMin { get; }
        public int altezza { get; set; }

        public Gru(string produttore, int pesoMax,int altezzaMax, int altezzaMin)
        {
            this.AltezzaMax = altezzaMax;
            this.AltezzaMin = altezzaMin;
            this.Produttore = produttore;
            this.PesoMax = pesoMax;
            this.NumeroSeriale = s_serialNumberSeed.ToString();
            s_serialNumberSeed++;
        }

        public void AlzaGru(int quantità)
        {
            this.altezza = altezza + quantità;
            if (altezza > AltezzaMax)
            {
                altezza = altezza - quantità;
                throw new ArgumentOutOfRangeException(nameof(altezza), "la gru non può alzarsi oltre l'altezza massima");
                
            }


        }
        public void AbbassaGru(int quantità)
        {
            this.altezza = altezza - quantità;
            if (altezza < AltezzaMin)
            {
                altezza = altezza + quantità;
                throw new ArgumentOutOfRangeException(nameof(altezza), "la gru non può abbassarsi sotto l'altezza minima");
  
            }

        }
        public void ResetGru()
        {
            this.altezza = AltezzaMin;
        }

    }
}
