using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Aircraft : IEntity
    {
        public int AircraftId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int MaxSeats { get; set; }
    }
}
