using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IFlightService _flightService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IFlightService flightService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _flightService = flightService;
        }

        public IActionResult AddToCart(int flightId)
        {
            Flight flight = _flightService.GetById(flightId);

            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart, flight);

            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", "Flight " + flight.FlightNumber + " Added to Your Cart!");

            return RedirectToAction("Index", "Flight");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }

        public IActionResult RemoveFromCart(int flightId)
        {
            Flight flight = _flightService.GetById(flightId);

            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.RemoveFromCart(cart, flightId);

            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", "Flight " + flight.FlightNumber + " Removed from Your Cart!");

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Complete()
        {
            var model = new CreditCardDetailsViewModel
            {
                CreditCardDetails = new CreditCardDetails()
            };
            //return View(model);
            return View();
        }

        [HttpPost]
        public IActionResult Complete(CreditCardDetails creditCardDetails)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            TempData.Add("message", "Your Order Completed Successfully!");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Home");


        }
    }
}
