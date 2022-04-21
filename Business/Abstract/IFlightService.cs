using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFlightService
    {
        List<Flight> GetAll();
        List<Flight> GetByAirport(int airportId);
        Flight GetById(int flightId);
        void Add(Flight flight);
        void Update(Flight flight);
        void Delete(int flightId);
        List<Flight> Search(string fromLocation, string toLocation);
    }
}
