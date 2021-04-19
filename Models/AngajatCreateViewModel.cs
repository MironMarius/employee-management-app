using Licenta.Entitate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class AngajatCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Acest camp este obligatoriu!"), Display(Name = "Numar angajat")]

        public string NrAngajat { get; set; }

        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(50, MinimumLength = 2)]
        [Display(Name = "Prenume")]
        public string PrenumeAngajat { get; set; }

        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(50, MinimumLength = 2)]
        [Display(Name = "Nume")]
        public string NumeAngajat { get; set; }
        public string Nume
        {
            get
            {
                return PrenumeAngajat +" "+ NumeAngajat;
            }
        }
        public string Sex { get; set; }
        [Display(Name = "Poza angajatului ")]
        public IFormFile ImgUrl { get; set; }
        [DataType(DataType.Date), Display(Name = "Ziua nasterii")]
        public DateTime ZiNastere { get; set; } = DateTime.UtcNow;
        [DataType(DataType.Date), Display(Name = "Ziua angajarii")]
        public DateTime ZiAngajare { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(100), Display(Name="Numar de telefon")]

        public string NrTelefon { get; set; }
        public string Functie { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name ="Metoda de plata dorita de angajat")]
        public MetodaPlata MetodaPlata { get; set; }
        [Required(ErrorMessage="Acest camp este obligatoriu!"), StringLength(150)]
        public string Adresa { get; set; }
        [Required(ErrorMessage = "Acest camp este obligatoriu!"), StringLength(50)]
        public string Oras { get; set; }
        
    }
}
