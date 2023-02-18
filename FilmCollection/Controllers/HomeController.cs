using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private FormContext mainContext { get; set; }

        public HomeController(ILogger<HomeController> logger, FormContext someName)
        {
            _logger = logger;
            mainContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = mainContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                mainContext.Add(ar);
                mainContext.SaveChanges();

                TempData["Message"] = "Your film has been added!";

                return RedirectToAction("Form", ar);
            }
            else
            {
                ViewBag.Categories = mainContext.Categories.ToList();
                return View(ar);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { 
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult MovieList()
        {     
            var applications = mainContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.CreeperStalker == false)
                //.OrderBy(x => x.LastName)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int filmid)
        {
            ViewBag.Categories = mainContext.Categories.ToList();

            var application = mainContext.Responses.Single(x => x.FilmId == filmid);

            return View("Form", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            mainContext.Update(blah);
            mainContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int filmid)
        {
            var application = mainContext.Responses.Single(x => x.FilmId == filmid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            mainContext.Responses.Remove(ar);
            mainContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
