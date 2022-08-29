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
