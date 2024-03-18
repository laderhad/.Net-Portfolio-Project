﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id) {
            var values = testimonialManager.TGetByID(id);

            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        
            
        
        
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";

            var values = testimonialManager.TGetByID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {

            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");



        }


    }
}
