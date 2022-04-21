using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private IFlightService _flightService;

        public HomeController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public IActionResult Index()
        {
            var flightListViewModel = new FlightListViewModel
            {
                Flights = _flightService.GetAll()
            };
            return View(flightListViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        

        public IActionResult Search(string fromLocation, string toLocation)
        {
           
            var flightListViewModel = new FlightListViewModel
            {
                Flights = _flightService.Search(fromLocation,toLocation)
            };
            return View(flightListViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
