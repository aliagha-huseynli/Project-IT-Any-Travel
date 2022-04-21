using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public int MobileNumber { get; set; }
    }
}
