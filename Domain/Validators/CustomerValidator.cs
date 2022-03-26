using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("A entidade não pode ser nula");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("O primeiro nome não pode ser vazio")

                .NotNull()
                .WithMessage("O primeiro nome não pode ser nulo")

                .MinimumLength(3)
                .WithMessage("O primeiro nome deve ter no mínimo 3 caracteres")
                .MaximumLength(60)
                .WithMessage("O primeiro nome deve ter no máximo 60 caracteres");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("O ultimo nome não pode ser vazio")

                .NotNull()
                .WithMessage("O ultimo nome não pode ser nulo")

                .MinimumLength(3)
                .WithMessage("O ultimo nome deve ter no mínimo 3 caracteres")
                .MaximumLength(60)
                .WithMessage("O ultimo nome deve ter no máximo 60 caracteres");


            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("A cidade não pode ser vazio")

                .NotNull()
                .WithMessage("A cidade nome não pode ser nulo")

                .MaximumLength(60)
                .WithMessage("O ultimo nome deve ter no máximo 60 caracteres");


            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("O estado não pode ser vazio")

                .NotNull()
                .WithMessage("O estado não pode ser nulo")

                .MaximumLength(60)
                .WithMessage("O ultimo nome deve ter no máximo 60 caracteres");


            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("O telefone não pode ser vazio")

                .NotNull()
                .WithMessage("O telefone pode ser nulo")

                .MaximumLength(12)
                .WithMessage("O tefalone deve ter no máximo 12 caracteres");




        }
    }
}
