    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Licenta.Entitate;
using Licenta.Models;
using Licenta.Servicii;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace Licenta.Controllers
{
    [Authorize]
    public class AngajatiController : Controller
    {
        private readonly IntServiciiAngajati _serviciiAngajati;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AngajatiController(IntServiciiAngajati serviciiAngajati,IWebHostEnvironment hostingEnvironment)
        {
            _serviciiAngajati = serviciiAngajati;
            _hostingEnvironment = hostingEnvironment;
             
        }

        public IActionResult Index(int? numarPagini)
        {

            var angajati = _serviciiAngajati.GetAll().Select(angajat => new AngajatIndexViewModel
            {
                Id = angajat.Id,
                NrAngajat = angajat.NrAngajat,
                ImgUrl = angajat.ImgUrl,
                Nume = angajat.Nume,
                Sex = angajat.Sex,
                Functie = angajat.Functie,
                ZiAngajare=angajat.ZiAngajare,
                Oras=angajat.Oras
            }
            ).ToList() ;
            int paginaSize = 4;
            return View(PaginiListaAngajati<AngajatIndexViewModel>.Create(angajati, numarPagini ?? 1, paginaSize));
        }
        [HttpGet]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Create()
        {

            var model = new AngajatCreateViewModel();

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Create(AngajatCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                var angajat = new Angajat
                {
                    Id = model.Id,
                    NrAngajat = model.NrAngajat,
                    NumeAngajat = model.NumeAngajat,
                    PrenumeAngajat = model.PrenumeAngajat,
                    Nume=model.Nume,
                    Sex = model.Sex,
                    Email = model.Email,
                    ZiNastere = model.ZiNastere,
                    ZiAngajare = model.ZiAngajare,
                    MetodaPlata = model.MetodaPlata,
                    Adresa = model.Adresa,
                    Oras = model.Oras,
                    NrTelefon = model.NrTelefon,
                    Functie = model.Functie,
                };
                if(model.ImgUrl != null && model.ImgUrl.Length>0)
                {
                    var uploadDir = @"imagini/angajat";
                    var fileName = Path.GetFileNameWithoutExtension(model.ImgUrl.FileName);
                    var extension = Path.GetExtension(model.ImgUrl.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extension;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    await model.ImgUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    angajat.ImgUrl = "/" + uploadDir + "/" + fileName;
                }

                await _serviciiAngajati.CreateAsync(angajat);
                return RedirectToAction(nameof(Index));            
            }

            return View();
                
        }

        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Edit(int id)
        {
            var angajat  = _serviciiAngajati.GetById(id);
            if( angajat== null)
            {
                return NotFound();
            }

            var model = new AngajatEditViewModel()
            {
                Id = angajat.Id,
                NrAngajat = angajat.NrAngajat,
                NumeAngajat = angajat.NumeAngajat,
                PrenumeAngajat = angajat.PrenumeAngajat,
                Sex = angajat.Sex,
                Email = angajat.Email,
                ZiNastere = angajat.ZiNastere,
                ZiAngajare = angajat.ZiAngajare,
                MetodaPlata = angajat.MetodaPlata,
                Adresa = angajat.Adresa,
                Oras = angajat.Oras,
                NrTelefon = angajat.NrTelefon,
                Functie = angajat.Functie,

            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(AngajatEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var angajat = _serviciiAngajati.GetById(model.Id);
                if(angajat==null)
                {
                    return NotFound();

                }

                angajat.NrAngajat = model.NrAngajat;
                angajat.NumeAngajat = model.NumeAngajat;
                angajat.PrenumeAngajat = model.PrenumeAngajat;
                angajat.Sex = model.Sex;
                angajat.Email = model.Email;
                angajat.ZiNastere = model.ZiNastere;
                angajat.ZiAngajare = model.ZiAngajare;
                angajat.NrTelefon = model.NrTelefon;
                angajat.Functie = model.Functie;
                angajat.MetodaPlata = model.MetodaPlata;
                angajat.Adresa = model.Adresa;
                angajat.Oras = model.Oras;
                if(model.ImgUrl != null && model.ImgUrl.Length>0)
                {
                    var uploadDir = @"imagini/angajat";
                    var fileName = Path.GetFileNameWithoutExtension(model.ImgUrl.FileName);
                    var extension = Path.GetExtension(model.ImgUrl.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extension;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    await model.ImgUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    angajat.ImgUrl = "/" + uploadDir + "/" + fileName;

                }
                await _serviciiAngajati.UpdateAsync(angajat);
                return RedirectToAction(nameof(Index));

            }    

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Detail(int id)
        {

            var angajat = _serviciiAngajati.GetById(id);
            if(angajat==null)
            {
                return NotFound();
            }
            var model = new AngajatDetailViewModel()
            {
                Id = angajat.Id,
                NrAngajat = angajat.NrAngajat,
                Nume = angajat.Nume,
                Sex = angajat.Sex,
                Functie=angajat.Functie,
                ZiNastere = angajat.ZiNastere,
                ZiAngajare = angajat.ZiAngajare,
                Adresa = angajat.Adresa,
                NrTelefon = angajat.NrTelefon,
                Email = angajat.Email,
                MetodaPlata = angajat.MetodaPlata,
                Oras = angajat.Oras,
                ImgUrl = angajat.ImgUrl
            };
            return View(model);

           
        }
        [HttpGet]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Delete(int id)
        {
            var angajat = _serviciiAngajati.GetById(id);
            if (angajat == null)
            {
                return NotFound();

            }
            var model = new AngajatDeleteViewModel()
            {
                Id = angajat.Id,
                Nume = angajat.Nume
            };
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task <IActionResult> Delete(AngajatDeleteViewModel model)
        {
            await _serviciiAngajati.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }


    }
}
