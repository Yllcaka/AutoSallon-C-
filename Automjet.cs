using System;

namespace Automjet
{

    public class Automjet
    {

        string shasia;
        string targat;
        string ngjyra;
        int kubik;
        DateTime vitiProdhimit = DateTime.Today;
        string modeli;
        string brandi;
        int ulse;
        bool vozitjeMeKaterRRota;


        public string Modeli { get { return this.modeli; } }
        public string Brandi { get { return this.brandi; } }

        public int Kubik
        {
            get { return this.kubik; }
            set
            {
                if (value < 800 || value > 10000)
                    throw new ArgumentOutOfRangeException("Kubikazha duhet te jet ndermjet 800 dhe 10000");
                this.kubik = value;
            }
        }
        public int Ulse
        {
            get { return ulse; }
            set
            {
                if (value < 2 || value > 9)
                    throw new ArgumentOutOfRangeException("Numri i ulseve duhet te jet ndermjet 2 dhe 9");
                this.ulse = value;
            }
        }
        public string VitiProdhimitText
        {
            get
            {
                return vitiProdhimit.ToShortDateString();
            }
        }
        public DateTime VitiProdhimit
        {
            get { return this.vitiProdhimit; }
            set
            {
                var begin = new DateTime(1950, 1, 1).Ticks;
                var end = DateTime.Today.Ticks;
                if (value.Ticks < begin || value.Ticks > end)
                    throw new ArgumentOutOfRangeException("Vetura duhet te jet ndermjet vitit 1950 dhe dites se sotit");
                this.vitiProdhimit = value;
            }
        }
        public string Targat
        {
            get
            {
                return targat;
            }
            set
            {
                if (value.Length > 10)
                    throw new ArgumentOutOfRangeException("Nr i targave nuk mund te jet me e gjat se 10");
                targat = value;
            }
        }
        public bool VozitjeMeKaterRRota
        {
            get
            {
                return vozitjeMeKaterRRota;
            }
            set
            {
                vozitjeMeKaterRRota = value;
            }
        }
        public Automjet
        (
            string targat,
            string brandi,
            string modeli,
            string ngjyra,
            int ulset,
            DateTime vitiProdhimit,
            bool vozitjeMeKaterRRota,
            int kubik,
            string shasia
        )
        {
            this.Targat = targat;
            this.brandi = brandi;
            this.modeli = modeli;
            this.ngjyra = ngjyra;
            this.Ulse = ulset;
            this.VitiProdhimit = vitiProdhimit;
            this.VozitjeMeKaterRRota = vozitjeMeKaterRRota;
            this.Kubik = kubik;
            this.shasia = shasia;
        }

        public override string ToString()
        {
            return $"Prodhuesi:{brandi}\nModeli:{modeli}\nViti i Prodhimit: {VitiProdhimitText}";
        }

    }
}
