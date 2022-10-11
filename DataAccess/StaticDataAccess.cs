using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models;

namespace mvc.DataAccess
{
    public class StaticDataAccess
    {
        private List<PersonModel> _people = new List<PersonModel>{
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "2",
                DateOfBirth = new DateTime(1999,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "2",
                DateOfBirth = new DateTime(1999,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "3",
                DateOfBirth = new DateTime(2001,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
        };

        public List<PersonModel> getList()
        {
            return _people;
        }
    }
}