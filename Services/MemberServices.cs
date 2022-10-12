using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft;
using mvc.DataAccess;
using mvc_d2.Interface;

namespace mvc.Services
{
    public class MemberServices : IMemberService
    {
        private readonly IDataAccess _da; 
        public MemberServices(IDataAccess dataAccess)
        {
            _da = dataAccess;
        }
        public List<PersonViewModel> getViewList()
        {
            var memberList = _da.getList();
            List<PersonViewModel> viewList = memberList.Select(o => new PersonViewModel(o)).ToList();
            return viewList;
        }
        public List<PersonModel> getData()
        {
            var memberList = _da.getList();
            return memberList;
        }
        public List<PersonViewModel> getOldestOnes()
        {
            var memberList = _da.getList();
            List<PersonViewModel> viewList = memberList.Where(o => o.Age == memberList.Max(o => o.Age)).Select(o => new PersonViewModel(o)).ToList();
            return viewList;
        }
        public List<string> getFullNames()
        {
            var memberList = _da.getList();
            List<string> viewList = memberList.Select(o => o.FullName).ToList();
            return viewList;
        }
        public List<PersonViewModel> GetMembersBasedOnAge(int logicCase)
        {
            var memberList = _da.getList();
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