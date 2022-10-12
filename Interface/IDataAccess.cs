using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Services;
using mvc.DataAccess;

namespace mvc_d2.Interface
{
    public interface IDataAccess
    {
        public List<PersonModel> getList();
    }
}