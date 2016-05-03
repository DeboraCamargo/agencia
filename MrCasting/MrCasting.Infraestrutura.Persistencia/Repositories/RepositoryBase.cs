using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using MrCasting.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace MrCasting.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly GeneralContext Db;

        public RepositoryBase(GeneralContext context)
        {
            Db = context;
        }

        private DbSet<TEntity> Entity { get { return Db.Set<TEntity>(); } }

        public void Add(TEntity obj)
        {
            obj.DtInclusao = DateTime.Now;
            Entity.Add(obj);
        }

        public void AddAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Add(entity);
        }

        public void DeleteAll(IEnumerable<TEntity> obj)
        {
            foreach (var entity in obj)
                Delete(entity);
        }

        public void Delete(TEntity obj)
        {
            Entity.Remove(obj);
        }

        public void Delete(int id)
        {
            Entity.Remove(GetById(id));
        }

        public virtual TEntity GetById(int id)
        {
            return Entity.Find(id);
        }

        public TEntity First()
        {
            return Entity.FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entity;
        }

        public IQueryable<TEntity> Get()
        {
            return Entity;
        }

        public void Update(TEntity obj)
        {
            obj.DtAlteracao = DateTime.Now;
            Db.Entry(obj).State = EntityState.Modified;
        }

        public void AddOrUpdate(TEntity obj)
        {
            if (obj.Id > 0)
                Update(obj);
            else
                Add(obj);
        }

        public void Commit()
        {
            try
            {
                Db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void Dispose()
        {}

        
    }
}
