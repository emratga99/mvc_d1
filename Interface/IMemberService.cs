using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Services;
using mvc.DataAccess;

namespace mvc_d2.Interface
{
    public interface IMemberService
    {

        public List<PersonViewModel> getViewList();
        public List<PersonModel> getData();
        public List<PersonViewModel> getOldestOnes();
        public List<string> getFullNames();
        public List<PersonViewModel> GetMembersBasedOnAge(int logicCase);
    }
}