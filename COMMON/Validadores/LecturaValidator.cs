using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON.Entidades;
using FluentValidation;

namespace COMMON.Validadores
{
    public class LecturaValidator:BaseValidator<Lectura>
    {
        public LecturaValidator()
        {
            RuleFor(l => l.IdDIspositivo).NotEmpty();
            RuleFor(l => l.Temperatura).NotEmpty();
            RuleFor(l => l.Humedad).NotEmpty();
            RuleFor(l => l.Luminosidad).NotEmpty();
        }
    }
}
