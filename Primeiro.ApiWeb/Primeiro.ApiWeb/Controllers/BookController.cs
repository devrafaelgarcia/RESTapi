using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Primeiro.ApiWeb.Data.VO;
using Primeiro.ApiWeb.Services.Interface;
using System;

namespace Primeiro.ApiWeb.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var teste = _bookService.FindById(id);
            return Ok(teste);
        }

        [HttpPost]
        public IActionResult Create(BookVO book)
        {
            _bookService.Create(book);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(BookVO book)
        {
            try
            {
                _bookService.Update(book);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
           
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return Ok();
        }
    }
}
