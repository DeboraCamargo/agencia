using MrCasting.Domain.Entities;
using MrCasting.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MrCasting.Infra.Data.Repositories
{
    public class RepositoryList<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly List<TEntity> _list;
        public bool Commited;

        public RepositoryList(List<TEntity> list)
        {
            _list = list;
            Commited = false;
        }

        public void Add(TEntity obj)
        {
            obj.DtInclusao = DateTime.Now;
            _list.Add(obj);
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
            _list.Remove(obj);
        }

        public void Delete(int id)
        {
            _list.Remove(GetById(id));
        }

        public TEntity GetById(int id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }

        public TEntity First()
        {
            return _list.FirstOrDefault();
        }

        public IQueryable<TEntity> Get()
        {
            return _list.AsQueryable();
        }

        public void Update(TEntity obj)
        {
            obj.DtAlteracao = DateTime.Now;
            _list[_list.IndexOf(GetById(obj.Id))] = obj;
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
            Commited = true;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _list.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
