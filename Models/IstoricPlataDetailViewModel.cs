using Licenta.Entitate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class IstoricPlataDetailViewModel
    {
        public int Id { get; set; }
        public int IdAngajat { get; set; }
        public Angajat Angajat { get; set; }
        [Display(Name = "Angajat")]
        public string Nume { get; set; }
        [DataType(DataType.Date), Display(Name = "Data platii")]
        public DateTime ZiPlata { get; set; } 
        [Display(Name = "Luna platii")]
        public string LunaPlata { get; set; }
        [Display(Name = "An taxa")]
        public int IdAnTaxa { get; set; }

        public string Functie { get; set; }
        public string An { get; set; }
        public AnTaxa AnTaxa { get; set; }
        [Display(Name = "Plata/Ora")]
        public decimal RataOra { get; set; }
        [Display(Name ="Metoda de plata")]
        public string MetodaPlata { get; set; }

        [Display(Name = "Plata/Ora extra")]
        public decimal RataOraExtra { get; set; }
        [Display(Name = "Ore lucrate")]
        public decimal OreLucrate { get; set; }
        [Display(Name = "Ore contractuale")]
        public decimal OreContract { get; set; }
        [Display(Name = "Ore extra")]
        public decimal OreExtra { get; set; }
        [Display(Name = "Salariu contractual")]
        public decimal SalariuContractual { get; set; }
        [Display(Name = "Plata extra")]
        public decimal PlataExtra { get; set; }
        [Display(Name = "Taxe salariale")]
        public decimal TaxeSalariale { get; set; }
     
        [Display(Name = "Venituri totale ")]
        public decimal CastiguriTotale { get; set; }
        [Display(Name = "Total taxe")]
        public decimal TotalTaxe { get; set; }
        [Display(Name = "Salariu net")]
        public decimal PlataNeta { get; set; }

    }
}
