using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Models;

namespace Test.Domain.Repository
{
    public interface IUnitOfWork
    {
        Repository<PermissaoSistema> PermissaoSistemaRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
