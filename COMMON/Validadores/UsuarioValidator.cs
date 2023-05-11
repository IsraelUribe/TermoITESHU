using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON.Entidades;
using FluentValidation;
namespace COMMON.Validadores
{
    public class UsuarioValidator:BaseValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Password).NotEmpty().MinimumLength(8);
            RuleFor(u => u.Nombre).NotEmpty().MinimumLength(5);
        }
    }
}
