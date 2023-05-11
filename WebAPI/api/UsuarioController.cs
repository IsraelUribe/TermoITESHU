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
    public class UsuarioController : GenericController<Usuario>
    {
        public UsuarioController() : base(new GenericRepositorio<Usuario>(new UsuarioValidator()))
        {

        }
    }
}
