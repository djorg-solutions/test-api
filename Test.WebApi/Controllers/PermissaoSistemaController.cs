using Test.Domain;
using Test.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Application.Services;
using Test.Domain.Models;
using Test.Application.Dto;

namespace Test.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissaoSistemaController : ControllerBase
    {
        private readonly IPermissaoSistemaService _permissaoSistemaService;

        public PermissaoSistemaController(IPermissaoSistemaService permissaoSistemaService)
        {
            _permissaoSistemaService = permissaoSistemaService;
        }

        /// <summary>
        /// Get all
        /// </summary>
        [HttpGet]
        public IEnumerable<PermissaoSistema> Get()
        {
            return _permissaoSistemaService.GetAll();
        }


        /// <summary>
        /// Get consultants
        /// </summary>
        [HttpGet]
        [Route("consultants")]
        public IEnumerable<UsuarioDto> GetConsultants()
        {
            return _permissaoSistemaService.GetConsultants();
        }

    }
}
