using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON.Entidades;
using FluentValidation;

namespace COMMON.Validadores
{
    public abstract class BaseValidator <T>:AbstractValidator<T> where T : Base
    {
        public BaseValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.FechaHora).NotEmpty();
        }
    }
}
