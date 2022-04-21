using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class FlightController : Controller
    {
        private IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public IActionResult Index()
        {
            var model = new FlightListViewModel
            {
                Flights = _flightService.GetAll()
            };
            return View(model);
        }
    }
}
