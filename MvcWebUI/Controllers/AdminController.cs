using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IFlightService _flightService;
        private IAirportService _airportService;

        public AdminController(IFlightService flightService, IAirportService airportService)
        {
            _flightService = flightService;
            _airportService = airportService;
        }

        public IActionResult Index()
        {
            var flightListViewModel = new FlightListViewModel
            {
                Flights = _flightService.GetAll()
            };
            return View(flightListViewModel);
        }

        public IActionResult Add()
        {
            var model = new FlightAddViewModel
            {
                Flight = new Flight(),
                Airports = _airportService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Flight flight)
        {
            _flightService.Add(flight);
            TempData.Add("message","Flight was successfully added");
            return View();
        }

        public IActionResult Update(int flightId)
        {
            var model = new FlightUpdateViewModel
            {
                Flight = _flightService.GetById(flightId),
                Airports = _airportService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Flight flight)
        {
            _flightService.Update(flight);
            TempData.Add("message", "Flight was successfully updated");
            return View();
        }

        public IActionResult Delete(int flightId)
        {
            _flightService.Delete(flightId);
            TempData.Add("message", "Flight was successfully updated");
            return RedirectToAction("Index");
        }
    }
}
