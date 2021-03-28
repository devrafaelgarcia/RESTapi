using Primeiro.ApiWeb.Data.Contract;
using Primeiro.ApiWeb.Data.Contract.VO;
using Primeiro.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Data.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public PersonVO Parse(Person origem)
        {
            if (origem == null) return null;

            return new PersonVO {
                Id = origem.Id,
                FirstName = origem.FirstName,
                LastName = origem.LastName,
                Andress = origem.Andress,
                Gender = origem.Gender
            };


        }



        public Person Parse(PersonVO origem)
        {
            if (origem == null) return null;

            return new Person
            {
                Id = origem.Id,
                FirstName = origem.FirstName,
                LastName = origem.LastName,
                Andress = origem.Andress,
                Gender = origem.Gender
            };

        }

        public List<Person> Parse(List<PersonVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> Parse(List<Person> origem)
        {
            if (origem == null) return null;
            return origem.Select(item => Parse(item)).ToList();
        }
    }
}
