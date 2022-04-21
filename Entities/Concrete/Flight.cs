using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abstract;
using Microsoft.Data.SqlClient.Server;

namespace Entities.Concrete
{
    public class Flight : IEntity
    {
        public int FlightId { get; set; }
        public int FlightNumber { get; set; }
        //public int AirlineId { get; set; }
        public int AirportId { get; set; }
        //public int AircraftId { get; set; }
        //public int UserId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

    }
}
