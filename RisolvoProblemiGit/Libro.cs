using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTPS
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private string _dataPublicazione;
        private string _editor;
        private int _numeroPagine;
        public Libro(string autore, string titolo, string datapubblicazione, string editor, int numeropagine)
        {
            Autore = autore;
            Titolo = titolo;
            DataPublicazione = datapubblicazione;
            Editor = editor;
            NumeroPagine = numeropagine;
        }
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _autore = value;
                }
            }
        }
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _titolo = value;
                }
            }
        }
        public string DataPublicazione
        {
            get
            {
                return _dataPublicazione;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _dataPublicazione = value;
                }
            }
        }
        public string Editor
        {
            get
            {
                return _editor;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _editor = value;
                }
            }
        }
        public int NumeroPagine
        {
            get
            {
                return _numeroPagine;
            }
            set
            {
                try
                {
                    _numeroPagine = value;
                }catch
                {

                }
            }
        }
        public string CalcolaTempoLettura()
        {
            string TempoLettura="Errore";
            if(NumeroPagine<100)
            {
                TempoLettura = "1H";
                return TempoLettura;
            }
            else
            {
                if(NumeroPagine>100&&NumeroPagine<200)
                {
                    TempoLettura = "2H";
                    return TempoLettura;
                }
                else
                {
                    if(NumeroPagine>200)
                    {
                        TempoLettura = ">2H";
                        return TempoLettura;
                    }
                }
            }
            return TempoLettura;
        }
        public override string ToString()
        {
            return "Il libro scritto da:" + Autore + " chiamato:" + Titolo+" publicato nel "+DataPublicazione+" dalla:"+Editor+" possiede "+NumeroPagine+" pagine";
        }
    }
}
