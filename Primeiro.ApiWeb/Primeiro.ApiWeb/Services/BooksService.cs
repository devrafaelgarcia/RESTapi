using Primeiro.ApiWeb.Data.Implementations;
using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Models;
using Primeiro.ApiWeb.Services.Interface;
using Primeiro.ApiWeb.Services.Repository;
using Primeiro.ApiWeb.Services.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services
{
    public class BooksService : IBookService
    {
        private readonly IRepository<Books> _bookRepository;
        private readonly BookConverter _bookConverter;

        public BooksService(IRepository<Books> bookRepository)
        {
            _bookRepository = bookRepository;
            _bookConverter = new BookConverter();
        }

        public void Create(BookVO book)
        {
            var bookEntity = _bookConverter.Parse(book);
            _bookRepository.Create(bookEntity);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }

        public List<BookVO> FindAll()
        {
            return _bookConverter.Parse(_bookRepository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _bookConverter.Parse(_bookRepository.FindById(id));
        }

        public void Update(BookVO book)
        {
            var bookEntity = _bookConverter.Parse(book);
            _bookRepository.Update(bookEntity);
        }
    }
}