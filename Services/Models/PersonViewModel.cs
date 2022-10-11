using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.DataAccess;

namespace mvc.Services
{
    public class PersonViewModel
    {
        public PersonViewModel(PersonModel model)
        {
            Id = model.Id;
            FirstName = model.FirstName;
            LastName = model.LastName;
            Gender = model.Gender;
            Age = model.Age;
            Gender = model.Gender == "1" ? "Male" : model.Gender == "2" ? "Female" : "";
        }
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}