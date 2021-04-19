using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Storage;

namespace WebApplication1.Controllers
{
    public class CatalogController : Controller
    {
        private readonly TourContext _context;

        public CatalogController(TourContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tours = _context.tours;
            ViewBag.tours = tours;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
