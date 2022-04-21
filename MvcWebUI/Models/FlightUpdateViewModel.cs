using System.Collections.Generic;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class FlightUpdateViewModel
    {
        public Flight Flight { get; set; }
        public List<Airport> Airports { get; set; }
    }
}