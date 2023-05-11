using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;
using DAL.Mongo;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivoController : GenericController<Dispositivo>
    {
        public DispositivoController() : base(new GenericRepositorio<Dispositivo>(new DispositivoValidator()))
        {

        }
    }
}
