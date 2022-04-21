using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Airport : IEntity
    {
        public int AirportId { get; set; }
        public string AirportCode { get; set; }
        public string AirportCity { get; set; }
        public string AirportName { get; set; }
    }
}
