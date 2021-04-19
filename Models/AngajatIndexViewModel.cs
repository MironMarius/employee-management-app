using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class AngajatIndexViewModel
    {
        public int Id { get; set; }
        public string NrAngajat { get; set; }
        public string Nume { get; set; }
        public string Sex { get; set; }
        public string ImgUrl { get; set; }
        public DateTime ZiAngajare { get; set; }
        public string Functie { get; set; }
        public string Oras { get; set; }



    }
}
