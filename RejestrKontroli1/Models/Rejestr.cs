using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RejestrKontroli1.Models
{
    public class Rejestr
    {

        public int ID { get; set; }
        public string Działanie { get; set; }
        public string Poddziałanie { get; set; }

        [Display(Name = "Numer projektu")]
        public string NrProjektu { get; set; }

        [Display(Name = "Tytuł projektu")]
        public string TytułProjektu { get; set; }
        public string Beneficjent { get; set; }
        public string Zespół { get; set; }

        [Display(Name = "Rodzaj kontroli")]
        public string RodzajKontroli { get; set; }

        [Display(Name = "Termin kontroli")]
        public DateTime TerminKontroli { get; set; }

        [Display(Name = "Data zakończenia kontroli")]
        public DateTime DataZakończenia { get; set; }

        [Display(Name = "Wizyta monitoringowa")]
        public bool WizytaMonitoringowa { get; set; }
        public bool Pzp { get; set; }
        public bool Konkurencyjnosc { get; set; }

        [Display(Name = "Rozeznanie rynku")]
        public bool RozeznanieRynku { get; set; }

        [Display(Name = "Data pierwszej informacji")]
        public DateTime DataPierwszejInformacji { get; set; }

        [Display(Name = "Zastrzeżenia do informacji")]
        public bool ZastrzezeniaDoInf { get; set; }

        [Display(Name = "Data ostatecznej informacji")]
        public DateTime DataOstatecznejInfo { get; set; }

        [Display(Name = "Data podpisania informacji")]
        public DateTime DataPodpisaniaInfo { get; set; }

        [Display(Name = "Data wpisu do SL")]
        public DateTime DataWpisuDoSL { get; set; }

        [Display(Name = "Uzcybienia/nieprawidłowości")]
        public string UchybieniaNIeprawidlowoci { get; set; }
        public bool Zalecenia { get; set; }//jezeli były zalecenia to ma wyskakiwac poniższe pole z datą

        [Display(Name = "Data wykonania zaleceń")]
        public DateTime DataWykonaniaZalecen { get; set; }

        [Display(Name = "Kontrola zakończona")]
        public bool KontrolaZakonczona { get; set; }
    }
}