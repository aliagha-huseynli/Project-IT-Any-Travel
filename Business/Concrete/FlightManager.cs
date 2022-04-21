using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FlightManager : IFlightService
    {
        private IFlightDal _flightDal;

        public FlightManager(IFlightDal flightDal)
        {
            _flightDal = flightDal;
        }

        public List<Flight> GetAll()
        {
            return _flightDal.GetList();
        }

        public List<Flight> GetByAirport(int airportId)
        {
            return _flightDal.GetList(f => f.AirportId == airportId);
        }

        public Flight GetById(int flightId)
        {
            return _flightDal.Get(f => f.FlightId == flightId);
        }

        public void Add(Flight flight)
        {
            _flightDal.Add(flight);
        }

        public void Update(Flight flight)
        {
            _flightDal.Update(flight);
        }

        public void Delete(int flightId)
        {
            _flightDal.Delete(new Flight { FlightId = flightId });
        }

        public List<Flight> Search(string fromLocation, string toLocation)
        {
            if (string.IsNullOrEmpty(toLocation) && string.IsNullOrEmpty(fromLocation))
            {
                return _flightDal.GetList();
            }

            return _flightDal.GetList(f => f.FromLocation.Contains(fromLocation) &&
                                           f.ToLocation.Contains(toLocation)); 
        }


    }
}
