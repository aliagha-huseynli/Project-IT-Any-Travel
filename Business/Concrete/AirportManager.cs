using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AirportManager : IAirportService
    {
        private IAirportDal _airportDal;

        public AirportManager(IAirportDal airportDal)
        {
            _airportDal = airportDal;
        }

        public List<Airport> GetAll()
        {
            return _airportDal.GetList();
        }
    }
}
