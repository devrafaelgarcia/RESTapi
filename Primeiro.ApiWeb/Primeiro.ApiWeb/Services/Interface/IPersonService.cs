using Primeiro.ApiWeb.Data.Contract.VO;
using System.Collections.Generic;

namespace Primeiro.ApiWeb.Services.Interface
{
    public interface IPersonService
    {
        PersonVO Create(PersonVO PersonVO);
        PersonVO Update(PersonVO PersonVO);
        List<PersonVO> FindAll();
        void Delete(long id);
        PersonVO FindById(long id);
    }
}
