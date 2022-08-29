using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Models;

namespace Test.Application.Services
{
    public interface IPermissaoSistemaService
    {
        IEnumerable<PermissaoSistema> GetAll();
        PermissaoSistema FindById(int? id);
    }
}
