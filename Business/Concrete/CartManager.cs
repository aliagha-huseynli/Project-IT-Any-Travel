using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Flight flight)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Flight.FlightId == flight.FlightId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Flight = flight, Quantity = 1 });
            }
        }

        public void RemoveFromCart(Cart cart, int flightId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Flight.FlightId == flightId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
