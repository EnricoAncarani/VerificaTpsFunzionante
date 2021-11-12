using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTPS
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _oraDiApertura;
        private string _oraDiChiusura;
        public List<Libro> _listaLibri;
        public Biblioteca()
        {
            _listaLibri = new List<Libro>();
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(string.IsNullOrEmpty(value)==false)
                {
                    _nome = value;
                }
            }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _indirizzo = value;
                }
            }
        }
        public string OraApertura
        {
            get { return _oraDiApertura; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _oraDiApertura = value;
                }
            }
        }
        public string OraChiusura
        {
            get { return _oraDiChiusura; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _oraDiChiusura = value;
                }
            }
        }
        public void AggiungiLibro(Libro x)
        {
            _listaLibri.Add(x);
        }
        public void AggiungiLibro(string autore, string titolo, string annoPublicazione, string editor, int numeroPagine)
        {
            Libro x = new Libro(autore, titolo, annoPublicazione, editor, numeroPagine);
            _listaLibri.Add(x);
        }
        public List<Libro> RicercaLibroPerTitolo(string titolo)
        {
            List<Libro> ListaDeiLibriRicercati = new List<Libro>();
            foreach (Libro x in _listaLibri)
            {
                if (x.Titolo == titolo)
                {
                    ListaDeiLibriRicercati.Add(x);
                }
            }
            return ListaDeiLibriRicercati;
        }
        public List<Libro> RIcercaPerAutore(string autore)
        {
            List<Libro> ListaDeiLibriRicercati = new List<Libro>();
            foreach (Libro x in _listaLibri)
            {
                if (x.Autore == autore)
                {
                    ListaDeiLibriRicercati.Add(x);
                }
            }
            return ListaDeiLibriRicercati;
        }
        public int NumeroLibriPresenti()
        {
            return _listaLibri.Count;
        }
    }
}
