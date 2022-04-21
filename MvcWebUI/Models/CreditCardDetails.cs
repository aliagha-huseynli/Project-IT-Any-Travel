using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class CreditCardDetails
    {
        
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CvcCode { get; set; }

    }
}
