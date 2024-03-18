using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";

            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);

            if (results.IsValid) { 

                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }


            }
            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Düzenleme";

            var values = portfolioManager.TGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();

            portfolioManager.TUpdate(portfolio);
            ValidationResult results = validations.Validate(portfolio);

            if (results.IsValid) {

                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
                
            
            }
            else
            {
                foreach (var item in results.Errors) {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);    
                
                
                
                }

                
            }
            return View();


        }

    }
}
