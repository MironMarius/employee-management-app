using Licenta.Entitate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class AngajatDetailViewModel
    {
        public int Id { get; set; }
        public string NrAngajat { get; set; }
        public string Nume { get; set; }
        public string Sex { get; set; }
        public string ImgUrl { get; set; }
        public DateTime ZiNastere { get; set; }
        public DateTime ZiAngajare { get; set; }
        public string NrTelefon { get; set; }
        public string Functie { get; set; }
        public string Email { get; set; }
        public MetodaPlata MetodaPlata { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
    }
}
