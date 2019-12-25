using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionStage.Models;
using static DataLibrary.BusinessLogic.ConventionProcessor;

namespace ConventionStageEnsa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListConventions()
        {
            ViewBag.Message = "Demandes De Convention";
            var data = LoadConventions();
            List<ConventionModel> conventions = new List<ConventionModel>();

            foreach (var conv in data)
            {
                conventions.Add(new ConventionModel
                {
                    IdEtudiant = conv.IdEtudiant,
                    NomEntreprise = conv.NomEntreprise,
                    Ville = conv.Ville,
                    DateDebut = conv.DateDebut,
                    DateFin = conv.DateFin,
                    Etat = conv.Etat
                });
                
            }
            return View(conventions);
        }
        public ActionResult NouvelleConvention()
        {
            ViewBag.Message = "Demande De Convention.";

            return View();
        }   
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NouvelleConvention(ConventionModel model)
        {
            if (ModelState.IsValid)
            {
                int rec = addConvention(model.IdEtudiant, model.NomEntreprise, model.Ville, model.DateDebut, model.DateFin,
                    model.Etat);
                return RedirectToAction("ListConventions");
            }

            return View(model);
        }
    }
}