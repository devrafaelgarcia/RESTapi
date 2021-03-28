using Primeiro.ApiWeb.Data.Contract.VO;
using Primeiro.ApiWeb.Data.Implementations;
using Primeiro.ApiWeb.Models;
using Primeiro.ApiWeb.Services.Interface;
using Primeiro.ApiWeb.Services.Repository.Generic;
using System.Collections.Generic;

namespace Primeiro.ApiWeb.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;
     
        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            //Quando ele chega ele é um VO, não da para persistir na base da dados
            var personEntity = _converter.Parse(person);
            //Converto ele em um Person dnv
            personEntity = _repository.Create(personEntity);
            //Criamos o create
            return _converter.Parse(personEntity); //E basicamente voltamos ele para VO
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));

        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }


    }


}
