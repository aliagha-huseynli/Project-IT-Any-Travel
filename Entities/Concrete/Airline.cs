using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Airline : IEntity
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
    }
}
