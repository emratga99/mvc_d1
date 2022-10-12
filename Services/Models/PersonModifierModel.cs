using mvc.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class PersonModifierModel
    {

        public PersonModifierModel(PersonModel model)
        {
            Id = model.Id;
            FirstName = model.FirstName;
            LastName = model.LastName;
            PhoneNumber = model.PhoneNumber;
            BirthPlace = model.BirthPlace;
            IsGraduated = model.IsGraduated;
            DateOfBirth = model.DateOfBirth;
            Gender = model.Gender;  
        }
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public bool IsGraduated { get; set; }
        public string sDateOfBirth {
            get { return DateOfBirth.Value.ToShortDateString(); }
        }
        public string sIsGraduated
        {
            get { return IsGraduated == true ? "true" : "false"; }
        }
    }
}