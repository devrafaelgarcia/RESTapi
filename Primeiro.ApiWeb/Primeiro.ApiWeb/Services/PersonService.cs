﻿using Primeiro.ApiWeb.Models;
using Primeiro.ApiWeb.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Primeiro.ApiWeb.Services
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
           ;
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 10; i++)
            {
                Person p = MockPerson(i);
                persons.Add(p);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person() {
            Id = 1, 
            FirstName = "Rafael",
            LastName = "Garcia",
            Andress = "Uberlandia, MG, Brazil",
            Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {
            return new Person()
            {
            Id = IncrementAndGet(), 
            FirstName = "Person Name" + i,
            LastName = "Last Name" + i,
            Andress = "Some Andress" + i,
            Gender = i % 2 == 0 ? "Male" : "Female"
            }; 
    }

        private long IncrementAndGet()
        {
           return Interlocked.Increment(ref count);
        }
    }
}
