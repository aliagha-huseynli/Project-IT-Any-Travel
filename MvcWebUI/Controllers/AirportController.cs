using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class AirportController : Controller
    {
        private IAirportService _airportService;

        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        public IActionResult Index()
        {
            var model = new AirportListViewModel
            {
                Airports = _airportService.GetAll()
            };
            return View(model);
        }
    }
}
