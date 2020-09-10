using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationCore.WebUi.Models;
using DataFormation;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationCore.WebUi.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {

            int a = 5;
            var allFormationVM = new AllFormationViewModel();
            allFormationVM.Message = "Mon premier message du controlleur  ";
            allFormationVM.Nombre = 1;
            return View(allFormationVM);
        }





        public IActionResult AllFormationList()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            var listeFormation = repository.GetAllFormation();
            return View(listeFormation);
        }
        

        public IActionResult FormationJava()
        {

            Formation java = new Formation() { Nom = "JAVA", NomSeo = "Oracle", Description = "Design Pattern SOLID c'est la classe " };
            Formation php = new Formation() { Nom = "PHP", NomSeo = "Symphony", Description = "Design Pattern" };

            Formation[] listFormation = { java, php };

            FormationJava javaPages = new FormationJava();
            var infoJava = javaPages.Formations(listFormation).ToList();
            return View(infoJava);
        }



        public IActionResult DetailsFormation(String idFormation)
        {

            int id_Formation = -1;

            if(!Int32.TryParse(idFormation, out id_Formation))
            {
                return RedirectToAction("AllFormationList");
            }

            FormationMemoryRepository repository = new FormationMemoryRepository();
            var detailsFormation = repository.GetformationById(id_Formation);
            if(detailsFormation == null)
            {
                return RedirectToAction("AllFormationList");
            }

            return View(detailsFormation);
        }


    }
}
