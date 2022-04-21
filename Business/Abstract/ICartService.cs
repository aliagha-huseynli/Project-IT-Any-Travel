using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Flight flight);
        void RemoveFromCart(Cart cart, int flightId);
        List<CartLine> List(Cart cart);
    }
}
