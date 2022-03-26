using Domain.Exceptions;
using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderModel : BaseModel
    {
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public decimal TotalAmount { get; set; }

        public override bool Validate()
        {
            var validator = new OrderValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                    _errors.Add(error.ErrorMessage);

                throw new DomainException($"Alguns campos estão inválidos!", _errors);
            }

            return true;
        }
    }
}
