using Primeiro.ApiWeb.Models.Base;
using System.Collections.Generic;

namespace Primeiro.ApiWeb.Services.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        List<T> FindAll();
        void Delete(long id);
        T FindById(long id);

        bool Exists(long id);
    }
}
