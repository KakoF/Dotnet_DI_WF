using Domain.Exceptions;
using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductModel : BaseModel
    {
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public SupplierModel Supplier { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public int Stock { get; set; }
        public bool IsDiscontinued { get; set; }

        public override bool Validate()
        {
            var validator = new ProductValidator();
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
