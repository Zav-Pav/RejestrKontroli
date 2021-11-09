using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RejestrKontroli1.Models
{
    public class Rejestr
    {

        public int ID { get; set; }
        public string Działanie { get; set; }
        public string Poddziałanie { get; set; }
        public string NrProjektu { get; set; }
        public string TytułProjektu { get; set; }
        public string Beneficjent { get; set; }
        public string Zespół { get; set; }
        public string RodzajKontroli { get; set; }
        public DateTime TerminKontroli { get; set; }
        public DateTime DataZakończenia { get; set; }
        public bool WizytaMonitoringowa { get; set; }
        public bool Pzp { get; set; }
        public bool Konkurencyjnosc { get; set; }
        public bool RozeznanieRynku { get; set; }
        public DateTime DataPierwszejInformacji { get; set; }
        public bool ZastrzezeniaDoInf { get; set; }
        public DateTime DataOstatecznejInfo { get; set; }
        public DateTime DataPodpisaniaInfo { get; set; }
        public DateTime DataWpisuDoSL { get; set; }
        public string UchybieniaNIeprawidlowoci { get; set; }
        public bool Zalecenia { get; set; }//jezeli były zalecenia to ma wyskakiwac poniższe pole z datą
        public DateTime DataWykonaniaZalecen { get; set; }
        public bool KontrolaZakonczona { get; set; }
    }
}