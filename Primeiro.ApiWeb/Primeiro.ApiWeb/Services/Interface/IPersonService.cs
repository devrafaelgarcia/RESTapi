using Primeiro.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services.Interface
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);
        Person FindById(long id);
    }
}
