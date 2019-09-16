using EntityCore.Models.BusinessModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EntityTeste.Models.Repositories
{
    public class BaseRepository<TPrimaryEntity> where TPrimaryEntity : class
    {

        protected readonly Context bd;
        protected readonly DbSet<TPrimaryEntity> PrimaryDatabaseSet;


        public BaseRepository(Context _bd)
        {
            this.bd = _bd;
            this.PrimaryDatabaseSet = bd.Set<TPrimaryEntity>();
        }

        public virtual async Task<TPrimaryEntity> Obter(long id)
        {
            return await PrimaryDatabaseSet.FindAsync(id).ConfigureAwait(false);
        }

        public virtual IQueryable<TPrimaryEntity> Obter()
        {
            return this.PrimaryDatabaseSet;
        }

        public virtual IQueryable<TPrimaryEntity> Obter(Expression<Func<TPrimaryEntity, bool>> expressao)
        {
            return PrimaryDatabaseSet.Where(expressao);

        }

        public virtual async Task Criar(TPrimaryEntity Objeto)
        {
            if (Objeto == null)
            {
                throw new ArgumentNullException("Objeto: Não é possível adicionar entidade com valores nulos.");
            }

            await this.PrimaryDatabaseSet.AddAsync(Objeto);
        }

        public virtual Task Excluir(TPrimaryEntity Objeto)
        {
            if (Objeto == null)
            {
                throw new ArgumentNullException("Objeto: Não é possível excluir entidade com valores nulos.");
            }
            this.PrimaryDatabaseSet.Remove(Objeto);
            return Task.CompletedTask;
        }

        public virtual Task Excluir(Func<TPrimaryEntity, bool> expressao)
        {

            PrimaryDatabaseSet.RemoveRange(PrimaryDatabaseSet.ToList().Where(expressao));
            return Task.CompletedTask;
        }

        public virtual Task Editar(TPrimaryEntity Objeto, long key)
        {
            this.Update<TPrimaryEntity>(Objeto, key);
            return Task.CompletedTask;
        }

        private void Update<T>(T model, long key) where T : class
        {
            if (model == null)
            {
                throw new ArgumentNullException(model.ToString() + ": Não é possível atualizar objeto com valores nulos.");
            }
            var entry = this.bd.Entry(model);
            if (entry.State == EntityState.Detached)
            {
                var currentEntry = this.bd.Set<T>().Find(key);
                if (currentEntry != null)
                {
                    var attachedEntry = this.bd.Entry(currentEntry);
                    attachedEntry.CurrentValues.SetValues(model);
                }
                else
                {
                    this.bd.Set<T>().Attach(model);
                    entry.State = EntityState.Modified;
                }
            }

        }

        public async Task Persistir()
        {
            await this.bd.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}

