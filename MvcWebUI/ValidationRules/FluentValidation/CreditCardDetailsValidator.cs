using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class CreditCardDetailsValidator : AbstractValidator<CreditCardDetails>
    {
        public CreditCardDetailsValidator()
        {
            RuleFor(c => c.CardHolder).NotEmpty();
            RuleFor(c => c.CardHolder).MinimumLength(2);
            RuleFor(c => c.CardNumber).NotEmpty();
            RuleFor(c => c.CardNumber).MinimumLength(16);
            RuleFor(c => c.ExpireDate).NotEmpty();
            RuleFor(c => c.CvcCode).NotEmpty();
            RuleFor(c => c.CvcCode).MinimumLength(3);
        }
    }
}
