using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
