using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models;
using mvc_d2.Interface;


namespace mvc.DataAccess
{
    public class StaticDataAccess : IDataAccess
    {
        private List<PersonModel> _people = new List<PersonModel>{
            new PersonModel{
                Id = "CE32A03C-61E5-45A4-8EAE-5DF22DDEE2BB",
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                Id = "4D58E2B3-E991-49C4-A4D9-E4E60CA10E09",
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "2",
                DateOfBirth = new DateTime(1999,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                Id = "E3EED164-2BA9-48CC-932E-DDE1B2D30598",
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                Id = "170818CF-EB85-4B3F-920E-A3C4B7E1A25A",
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "2",
                DateOfBirth = new DateTime(1999,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                Id = "27057231-07C0-4714-8168-F360D64D6F19",
                FirstName = "abc",
                LastName = "abc xyz",
                Gender = "1",
                DateOfBirth = new DateTime(2000,03,20),
                PhoneNumber = "231313",
                BirthPlace = "hanoi",
                IsGraduated = false
            },
            new PersonModel{
                Id = "CD5AF0C0-5E23-4B91-A0E0-FB49E031282B",
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