using System;
using System.Collections.Generic;
using System.Text;


namespace Automjet
{
    public interface IAutoSallon
    {
        /// <summary>
        /// Merr Automjetet sipas prodhuesit
        /// </summary>
        /// <param name="prodhuesi">Emri i prodhuesit</param>

        List<Automjet> MerrSipasProdhuesit(string prodhuesi);
        /// <summary>
        /// Merr Automjetet sipas Modelit
        /// </summary>
        /// <param name="modeli">Emri i modelit</param>

        List<Automjet> MerrSipasModelit(string modeli);
        /// <summary>
        /// Merr Automjetet sipas rangut te Kubikazhes
        /// </summary>
        /// <param name="fillimi">Numri me i ulet</param>
        /// <param name="mbarimi">Numri me i lart</param>

        List<Automjet> MerrSipasKubikazhes(int fillimi, int mbarimi);

        /// <summary>
        /// Merr Automjete qe kane numrin e ulseve te njejt si numri i dhene
        /// </summary>
        /// <param name="nrUlseve">Nr i ulseve</param>

        List<Automjet> MerrSipasUlseve(int nrUlseve);
        /// <summary>
        /// Merr Automjetet sipas rangut te Ulseve
        /// </summary>
        /// <param name="fillimi">Numri me i ulet</param>
        /// <param name="mbarimi">Numri me i lart</param>

        List<Automjet> MerrSipasUlseve(int fillimi, int mbarimi);
        /// <summary>
        /// Merr Automjetet qe jane ose nuk jane 4X4 sipas vleres se dhene
        /// </summary>
        /// <param name="_4x4">Vlera bool</param>

        List<Automjet> Merr4X4(bool _4x4);
        /// <summary>
        /// Merr Automjetet sipas vitit
        /// </summary>
        /// <param name="viti">Viti i dhene</param>

        List<Automjet> MerrVitit(int viti);


    }
    public class AutoSallon : IAutoSallon
    {
        string Emri;
        List<Automjet> Automjetet;

        public delegate bool metodAutomjet(Automjet kerri);

        public List<Automjet> filterList(metodAutomjet kerriMetod)
        {
            List<Automjet> filteredList = new List<Automjet>();
            foreach (Automjet kerri in this.Automjetet)
            {
                if (kerriMetod(kerri))
                {
                    filteredList.Add(kerri);
                }
            }
            return filteredList;
        }
        public AutoSallon(string emri, List<Automjet> automjete)
        {
            this.Emri = emri;
            this.Automjetet = automjete;
        }
        public List<Automjet> MerrSipasKubikazhes(int fillimi, int mbarimi)
        {
            return filterList((kerr) => kerr.Kubik >= fillimi && kerr.Kubik <= mbarimi);
        }
        public List<Automjet> MerrSipasModelit(string modeli)
        {
            return filterList((kerr) => kerr.Modeli == modeli.Trim());
        }
        public List<Automjet> MerrSipasProdhuesit(string prodhuesi)
        {
            return filterList((kerr) => kerr.Brandi == prodhuesi.Trim());
        }

        public List<Automjet> MerrSipasUlseve(int nrUlseve)
        {
            return filterList((kerr) => kerr.Ulse.Equals(nrUlseve));
        }
        public List<Automjet> MerrSipasUlseve(int fillimi, int mbarimi)
        {

            return filterList((kerr) => kerr.Ulse >= fillimi && kerr.Ulse <= mbarimi);
        }
        public List<Automjet> MerrVitit(int viti)
        {
            return filterList((kerr) => kerr.VitiProdhimit.Year.Equals(viti));
        }
        public List<Automjet> Merr4X4(bool _4x4)
        {
            return filterList((kerr) => kerr.VozitjeMeKaterRRota.Equals(_4x4));
        }

    }
}
