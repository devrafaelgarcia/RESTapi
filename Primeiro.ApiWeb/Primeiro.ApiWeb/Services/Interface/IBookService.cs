using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services.Interface
{
    public interface IBookService
    {
        void Create(BookVO person);
        void Update(BookVO person);
        List<BookVO> FindAll();
        void Delete(long id);
        BookVO FindById(long id);
    }
}
