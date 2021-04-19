using Licenta.Entitate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class IstoricPlataIndexViewModel
    {
        public int Id { get; set; }
        public int IdAngajat { get; set; }
        public Angajat Angajat { get; set; }

        public string Nume { get; set; }
        [Display(Name="Data platii")]
        public DateTime DataPlatii { get; set; }
        [Display(Name ="Luna")]
        public string LunaPlatii { get; set; }

        public int IdAnTaxa { get; set; }

        public string An { get; set; }
        [Display(Name ="Venituri totale")]
        public decimal CastiguriTotale { get; set; }
        [Display(Name ="Taxe totale")]
        public decimal TaxeTotale { get; set; }
        [Display(Name ="Venit net")]
        public decimal PlataNeta { get; set; }  

    }
}
