using Licenta.Entitate;
using Licenta.Models;
using Licenta.Servicii;
using Microsoft.AspNetCore.Mvc;
using RotativaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Controllers
{
    public class PlataController : Controller
    {
        private readonly IntServiciiPlata _serviciiPlata;
        private readonly IntServiciiAngajati _serviciiAngajati;
        private decimal oreExtra;
        private decimal salariuContract;
        private decimal castiguriTotale;
        private decimal taxeSalariale;
        private decimal taxeTotale;
        private decimal plataExtra;

        public PlataController(IntServiciiPlata serviciiPlata, IntServiciiAngajati serviciiAngajati)
        {
            _serviciiPlata = serviciiPlata;
            _serviciiAngajati = serviciiAngajati;
        }
        public IActionResult Index()
        {
            var istoricPlati = _serviciiPlata.GetAll().Select(plata => new IstoricPlataIndexViewModel
            {
                Id = plata.Id,
                IdAngajat = plata.IdAngajat,
                Nume = plata.Nume,
                DataPlatii = plata.ZiPlata,
                LunaPlatii = plata.LunaPlata,
                IdAnTaxa = plata.IdAnTaxa,
                CastiguriTotale=plata.CastiguriTotale,
                TaxeTotale=plata.TaxeTotale,
                PlataNeta=plata.PlataNeta,
                Angajat=plata.Angajat,



            }
            ) ;

            return View(istoricPlati);

        }


        public IActionResult Create()
        {
            ViewBag.angajati = _serviciiAngajati.GetAllAngajatiForPlata();
            ViewBag.aniTaxa = _serviciiPlata.GetAllAnTaxa();
            var model = new IstoricPlataCreateViewModel();
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IstoricPlataCreateViewModel model)
        {

            if(ModelState.IsValid)
            {
                var istoricplata = new IstoricPlata()
                {
                    Id = model.Id,
                    IdAngajat = model.IdAngajat,
                    Nume = _serviciiAngajati.GetById(model.IdAngajat).Nume,
                    ZiPlata = model.ZiPlata,
                    LunaPlata = model.LunaPlata,
                    IdAnTaxa = model.IdAnTaxa,
                    RataOra = model.RataOra,
                    OreLucrate = model.OreLucrate,
                    OreContract = model.OreContract,
                    OreExtra = oreExtra =_serviciiPlata.OreExtra(model.OreLucrate,model.OreContract),
                    SalariuContractual= salariuContract = _serviciiPlata.SalariuContractual(model.OreContract, model.OreLucrate, model.RataOra),
                    PlataExtra = plataExtra =_serviciiPlata.PlataExtra(_serviciiPlata.RataOraExtra(model.RataOra), oreExtra),
                    CastiguriTotale= castiguriTotale =_serviciiPlata.CastiguriTotale(plataExtra, salariuContract),
                    TaxeSalariale = taxeSalariale = _serviciiPlata.TaxeSalariale(salariuContract),
                    TaxeTotale= taxeTotale = _serviciiPlata.TaxeTotale(castiguriTotale),
                    PlataNeta= _serviciiPlata.CastigNet(castiguriTotale, taxeTotale)

                };
               await _serviciiPlata.CreateAsync(istoricplata);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.angajati = _serviciiAngajati.GetAllAngajatiForPlata();
            ViewBag.aniTaxa = _serviciiPlata.GetAllAnTaxa();
            return View();
        }

        public IActionResult Detail(int id)
        {

            var istoricPlata = _serviciiPlata.GetById(id);
            if (istoricPlata == null)
            {
                return NotFound();
            }
            var model = new IstoricPlataDetailViewModel()
                
                {
                Id = istoricPlata.Id,
                IdAngajat = istoricPlata.IdAngajat,
                Nume = istoricPlata.Nume,
                ZiPlata = istoricPlata.ZiPlata,
                LunaPlata = istoricPlata.LunaPlata,
                IdAnTaxa = istoricPlata.IdAnTaxa,
                An = _serviciiPlata.GetAnTaxaById(istoricPlata.IdAnTaxa).AnDeTaxa,
                RataOra=istoricPlata.RataOra,
                OreLucrate=istoricPlata.OreLucrate,
                OreContract=istoricPlata.OreContract,
                OreExtra=istoricPlata.OreExtra,
                RataOraExtra=_serviciiPlata.RataOraExtra(istoricPlata.RataOra),
                SalariuContractual=istoricPlata.SalariuContractual,
                TaxeSalariale=istoricPlata.TaxeSalariale,
                PlataExtra=istoricPlata.PlataExtra,
                CastiguriTotale=istoricPlata.CastiguriTotale,
                TotalTaxe=istoricPlata.TaxeTotale,
                Angajat = istoricPlata.Angajat,
                AnTaxa=istoricPlata.AnTaxa,
                PlataNeta=istoricPlata.PlataNeta
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Plata(int id)
        {

            var istoricPlata = _serviciiPlata.GetById(id);
            if (istoricPlata == null)
            {
                return NotFound();
            }
            var model = new IstoricPlataDetailViewModel()

            {
                Id = istoricPlata.Id,
                IdAngajat = istoricPlata.IdAngajat,
                Nume = istoricPlata.Nume,
                ZiPlata = istoricPlata.ZiPlata,
                LunaPlata = istoricPlata.LunaPlata,
                IdAnTaxa = istoricPlata.IdAnTaxa,
                An = _serviciiPlata.GetAnTaxaById(istoricPlata.IdAnTaxa).AnDeTaxa,
                RataOra = istoricPlata.RataOra,
                OreLucrate = istoricPlata.OreLucrate,
                OreContract = istoricPlata.OreContract,
                OreExtra = istoricPlata.OreExtra,
                RataOraExtra = _serviciiPlata.RataOraExtra(istoricPlata.RataOra),
                SalariuContractual = istoricPlata.SalariuContractual,
                TaxeSalariale=istoricPlata.TaxeSalariale,
                PlataExtra = istoricPlata.PlataExtra,
                CastiguriTotale = istoricPlata.CastiguriTotale,
                TotalTaxe = istoricPlata.TaxeTotale,
                Angajat = istoricPlata.Angajat,
                AnTaxa = istoricPlata.AnTaxa,
                PlataNeta = istoricPlata.PlataNeta
            };
            return View(model);
        }

        public IActionResult GenereazaPlataPdf(int id)
        {

            var plata = new ActionAsPdf("Plata", new { id = id })
            {
                FileName= "plata.pdf"
            };
            return plata;
        }


    }
}
