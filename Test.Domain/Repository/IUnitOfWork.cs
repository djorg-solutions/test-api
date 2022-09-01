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
        Repository<CaoUsuario> UsuarioRepository { get; }
        Repository<CaoFatura> FacturaRepository { get; }
        Repository<CaoO> OSRepository { get; }
        Repository<CaoSalario> SalarioRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
