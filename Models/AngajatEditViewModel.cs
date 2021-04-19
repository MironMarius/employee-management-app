using Licenta.Entitate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class AngajatEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Acest camp este obligatoriu!")]
        public string NrAngajat { get; set; }

        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(50, MinimumLength = 2)]
        public string PrenumeAngajat { get; set; }

        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(50, MinimumLength = 2)]
        public string NumeAngajat { get; set; }
       
        public string Sex { get; set; }
        [Display(Name = "Poza")]
        public IFormFile ImgUrl { get; set; }
        [DataType(DataType.Date), Display(Name = "Ziua nasterii")]
        public DateTime ZiNastere { get; set; }
        [DataType(DataType.Date), Display(Name = "Ziua angajarii")]
        public DateTime ZiAngajare { get; set; }
        [Required(ErrorMessage = "Functia ocupata este obligatorie "), StringLength(100)]

        public string NrTelefon { get; set; }
        public string Functie { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public MetodaPlata MetodaPlata { get; set; }
        [Required, StringLength(150)]
        public string Adresa { get; set; }
        [Required, StringLength(50)]
        public string Oras { get; set; }
    }
}
