using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Application.Services;
using Test.Domain.Models;
using Test.Domain.Repository;

namespace Test.Application.src
{
    public class PermissaoSistemaService : IPermissaoSistemaService
    {
        private readonly IUnitOfWork _uow;
        public PermissaoSistemaService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IEnumerable<PermissaoSistema> GetAll()
        {
            return _uow.PermissaoSistemaRepository.List();
        }

        public PermissaoSistema FindById(int? id)
        {
            return _uow.PermissaoSistemaRepository.Find(id);
        }

        public IEnumerable<UsuarioDto> GetConsultants()
        {
            IEnumerable<ulong> types = new List<ulong>() { 0,1,2 };
            return from u in _uow.UsuarioRepository.Queryable()
                   join p in _uow.PermissaoSistemaRepository.Queryable()
                   on u.CoUsuario equals p.CoUsuario
                   where p.CoSistema == 1 && p.InAtivo == "S" && types.Contains(p.CoTipoUsuario) 
                   select new UsuarioDto() { CoUsuario = u.CoUsuario, NoUsuario = u.NoUsuario };
        }

    }
}
