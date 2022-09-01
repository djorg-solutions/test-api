using Sentry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Models;

namespace Test.Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly testContext _testcontext;
        public UnitOfWork(testContext testcontext)
        {
            if (testcontext == null)
            {
                throw new ArgumentNullException("dbContext");
            }

            _testcontext = testcontext;
        }

        Repository<PermissaoSistema> permissaoSistemaRepository;
        Repository<CaoUsuario> usuarioRepository;
        Repository<CaoFatura> facturaRepository;
        Repository<CaoO> osRepository;
        Repository<CaoSalario> salarioRepository;

        public Repository<PermissaoSistema> PermissaoSistemaRepository
        {
            get
            {
                if (this.permissaoSistemaRepository == null)
                {
                    this.permissaoSistemaRepository = new Repository<PermissaoSistema>(this._testcontext);
                }
                return this.permissaoSistemaRepository;
            }
        }

        public Repository<CaoUsuario> UsuarioRepository
        {
            get
            {
                if (this.usuarioRepository == null)
                {
                    this.usuarioRepository = new Repository<CaoUsuario>(this._testcontext);
                }
                return this.usuarioRepository;
            }
        }
        public Repository<CaoFatura> FacturaRepository
        {
            get
            {
                if (this.facturaRepository == null)
                {
                    this.facturaRepository = new Repository<CaoFatura>(this._testcontext);
                }
                return this.facturaRepository;
            }
        }
        public Repository<CaoO> OSRepository
        {
            get
            {
                if (this.osRepository == null)
                {
                    this.osRepository = new Repository<CaoO>(this._testcontext);
                }
                return this.osRepository;
            }
        }

        public Repository<CaoSalario> SalarioRepository
        {
            get
            {
                if (this.salarioRepository == null)
                {
                    this.salarioRepository = new Repository<CaoSalario>(this._testcontext);
                }
                return this.salarioRepository;
            }
        }


        public void SaveChanges()
        {
            this._testcontext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await this._testcontext.SaveChangesAsync();
        }
    }
}
