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
    public class LecturaController : GenericController<Lectura>
    {
        public LecturaController():base(new GenericRepositorio<Lectura>(new LecturaValidator()))
        {

        }
    }
}
