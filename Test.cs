using System;
using System.Collections.Generic;
namespace Automjet
{

    class Test
    {
        static void Testo(List<Automjet> salloniMetoda)
        {
            foreach (Automjet kerr in salloniMetoda)
            {

                Console.WriteLine("=======================\n" + kerr + "\n=======================\n");
            }
        }
        static void Main(string[] args)
        {
            List<Automjet> Automjetet = new List<Automjet>()
            {
                new Automjet("SA 335C0", "VW", "Golf", "Verdh", 5, new DateTime(1998, 4, 5), false, 1000, "hekur"),
                new Automjet("SA 335C0", "Audi", "A4", "Kalter", 6, new DateTime(2005, 3, 1), false, 2000, "hekur"),
                new Automjet("SA 335C0", "Jeep", "Renegade", "Gjelbert", 6, new DateTime(2001, 4, 2), true, 3000, "hekur"),
                new Automjet("SA 335C0", "BMW", "X6", "Rozë", 6, new DateTime(2018, 4, 15), false, 2000, "hekur"),
                new Automjet("SA 335C0", "Audi", "A3", "Zeze", 4, new DateTime(2012, 9, 25), false, 2000, "hekur"),
                new Automjet("SA 335C0", "VW", "Passat", "Bardh", 4, new DateTime(2012, 11, 23), false, 2000, "hekur"),
                new Automjet("SA 335C0", "VW", "Bettle", "Kuqe", 4, new DateTime(1998, 3, 5), false, 1000, "hekur"),
                new Automjet("SA 335C0", "BMW", "E36", "Zeze", 5, new DateTime(1998, 6, 16), false, 1500, "hekur"),
                new Automjet("SA 335C0", "VW", "Passat", "Kalter", 6, new DateTime(1998, 2, 27), false, 1000, "hekur"),
                new Automjet("SA 335C0", "Toyota", "4Runner", "Kalter", 2, new DateTime(2020, 3, 20), true, 3500, "hekur"),
            };
            IAutoSallon AutoSalloniDrini = new AutoSallon("Drini", Automjetet);
            Testo(AutoSalloniDrini.MerrSipasProdhuesit("Audi"));
            Testo(AutoSalloniDrini.MerrSipasModelit("Passat"));
            Testo(AutoSalloniDrini.MerrSipasKubikazhes(1000, 1500));
            Testo(AutoSalloniDrini.MerrSipasUlseve(4));
            Testo(AutoSalloniDrini.MerrSipasUlseve(2, 6));
            Testo(AutoSalloniDrini.Merr4X4(true));
            Testo(AutoSalloniDrini.MerrVitit(2020));

        }
    }
}
