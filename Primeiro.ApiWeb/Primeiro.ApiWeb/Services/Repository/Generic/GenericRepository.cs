using Microsoft.EntityFrameworkCore;
using Primeiro.ApiWeb.Models.Base;
using Primeiro.ApiWeb.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro.ApiWeb.Services.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {


        private readonly ContextMySql _context;

        private DbSet<T> dataset;


        public GenericRepository(ContextMySql context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }



        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return item;
        }


        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(x => x.Id.Equals(id));

            if (result != null)
            {

                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }
        }

        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return dataset.ToList(); ;
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(x => x.Id.Equals(id));
        }

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(x => x.Id.Equals(item.Id));

            if (result != null)
            {

                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
            else return null;

        }
    }

}

