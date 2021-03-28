using Primeiro.ApiWeb.Data.Contract;
using Primeiro.ApiWeb.Data.Contract.VO;
using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro.ApiWeb.Data.Implementations
{
    public class BookConverter : IParser<BookVO, Books>, IParser<Books, BookVO>
    {
        public BookVO Parse(Books origem)
        {
            if (origem == null) return null;

            return new BookVO
            {
                Id = origem.Id,
                Autor = origem.Autor,
                Date = origem.Date,
                Prince = origem.Prince,
                Title = origem.Title
            };


        }



        public Books Parse(BookVO origem)
        {
            if (origem == null) return null;

            return new Books
            {
                Id = origem.Id,
                Autor = origem.Autor,
                Date = origem.Date,
                Prince = origem.Prince,
                Title = origem.Title
            };

        }

        public List<Books> Parse(List<BookVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Books> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }
    }
}
