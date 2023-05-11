using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON.Entidades;
using FluentValidation;

namespace COMMON.Validadores
{
    public class DispositivoValidator:BaseValidator<Dispositivo>
    {
        public DispositivoValidator()
        {
            RuleFor(d => d.FechaColocacion).NotEmpty();
            RuleFor(d => d.Nombre).NotEmpty();
            RuleFor(d => d.NombreReLe1).NotEmpty();
            RuleFor(d => d.NombreReLe2).NotEmpty();
            RuleFor(d => d.NombreReLe3).NotEmpty();
            RuleFor(d => d.NombreReLe4).NotEmpty();
            RuleFor(d => d.Ubicacion).NotEmpty();
        }
    }
}
