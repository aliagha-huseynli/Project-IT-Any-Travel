using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class FlightAddViewModel
    {
        public Flight Flight { get; set; }
        public List<Airport> Airports { get; internal set; }
    }
}
