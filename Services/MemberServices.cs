using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.DataAccess;
using Microsoft.Office.Interop;
namespace mvc.Services
{
    public class MemberServices
    {
        public List<PersonViewModel> getViewList()
        {
            var memberList = new DataAccess.StaticDataAccess().getList();
            List<PersonViewModel> viewList = memberList.Select(o => new PersonViewModel(o)).ToList();
            return viewList;
        }
        public List<PersonModel> getData()
        {
            return new DataAccess.StaticDataAccess().getList(); 
        }
        public List<PersonViewModel> getOldestOnes()
        {
            var memberList = new DataAccess.StaticDataAccess().getList();
            List<PersonViewModel> viewList = memberList.Where(o => o.Age == memberList.Max(o => o.Age)).Select(o => new PersonViewModel(o)).ToList();
            return viewList;
        }
        public List<string> getFullNames()
        {
            var memberList = new DataAccess.StaticDataAccess().getList();
            List<string> viewList = memberList.Select(o => o.FullName).ToList();
            return viewList;
        }
        public List<PersonViewModel> GetMembersBasedOnAge(int logicCase)
        {
            var memberList = new DataAccess.StaticDataAccess().getList();
            switch (logicCase)
            {
                case 1:
                    return memberList.Where(o => o.DateOfBirth != null && o.DateOfBirth.Value.Year < 2000).Select(o => new PersonViewModel(o)).ToList();
                case 2:
                    return memberList.Where(o => o.DateOfBirth != null && o.DateOfBirth.Value.Year == 2000).Select(o => new PersonViewModel(o)).ToList();
                case 3:
                    return memberList.Where(o => o.DateOfBirth != null && o.DateOfBirth.Value.Year > 2000).Select(o => new PersonViewModel(o)).ToList();
                default:
                    return new List<PersonViewModel>();
            }
        }
    }
}