﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVSZadaca1
{
    internal class Stranka
    {
        private String identifikacionaSkracenica, puniNaziv;
        private int brojGlasova;
        private List<Kandidat> kandidati;

        public Stranka(string identifikacionaSkracenica, string puniNaziv)
        {
            this.identifikacionaSkracenica = identifikacionaSkracenica;
            this.puniNaziv = puniNaziv;
            this.kandidati = new List<Kandidat>();
            this.brojGlasova = 0;
        }

        public String getIdentifikacionaSkracenica()
        {
            return identifikacionaSkracenica;
        }
        public String getPuniNaziv()
        {
            return puniNaziv;
        }
        public int getBrojGlasova()
        {
            return brojGlasova;
        }
        public List<Kandidat> getKandidati()
        {
            return kandidati;
        }
        public void dodajGlas()
        {
            brojGlasova++;
        }

        //stranka ima svoju liistu kandidata, ovako stranka dodaje kandidata na listu
        public void dodajKandidata(Kandidat kandidat)
        {
            kandidati.Add(kandidat);   
        }

        public void izbaciKandidata(Kandidat kandidat)
        {
            kandidati.Remove(kandidat);
        }

    }
}
