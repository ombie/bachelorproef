using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bachelorproef.Models;
using Bachelorproef.Models.Domain;

namespace Bachelorproef.Controllers
{
    public class VoorstelController : Controller
    {
        private IStudentenRepository studentenRepository;
        private IVoorstellenRepository voorstellenRepository;
        private IOnderzoeksdomeinenRepository onderzoeksdomeinenRepository;
        //
        // GET: /Voorstel/

        public VoorstelController(IStudentenRepository studentenRepository, IVoorstellenRepository voorstellenRepository, IOnderzoeksdomeinenRepository onderzoeksdomeinenRepository)
        {
            this.voorstellenRepository = voorstellenRepository;
            this.studentenRepository = studentenRepository;
            this.onderzoeksdomeinenRepository = onderzoeksdomeinenRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Indienen")]
        public ActionResult Indienen(Student student, VoorstelIndienenModel vim)
        {
            Voorstel voorstel = voorstellenRepository.Find(student.Emailadres);
            voorstel.Titel = vim.Titel;
            voorstel.VrijeTrefwoorden = vim.VrijeTrefwoorden;
            voorstel.Onderzoeksvraag = vim.Onderzoeksvraag;
            voorstel.Probleemstelling = vim.Probleemstelling;
            voorstel.PlanVanAanpak = vim.PlanVanAanpak;
            voorstel.TijdstipVanIndienen = DateTime.Now;
            voorstel.toInBehandelingState();
            voorstellenRepository.SaveChanges();
            //View nog aan te passen
            return View();
        }

        [HttpPost, ActionName("Opslaan")]
        public ActionResult Opslaan(Student student, VoorstelIndienenModel vim)
        {
            Voorstel voorstel = voorstellenRepository.Find(student.Emailadres);
            voorstel.Titel = vim.Titel;
            voorstel.VrijeTrefwoorden = vim.VrijeTrefwoorden;
            voorstel.Onderzoeksvraag = vim.Onderzoeksvraag;
            voorstel.Probleemstelling = vim.Probleemstelling;
            voorstel.PlanVanAanpak = vim.PlanVanAanpak;
            voorstellenRepository.SaveChanges();
            //View nog aan te passen
            return View();
        }
    }
}
