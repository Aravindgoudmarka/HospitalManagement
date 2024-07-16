using HM.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Services.Contracts
{
    public interface IDeptService
    {
        DepartmentDB InsertDept(DepartmentDB dept);

        DepartmentDB UpdateDept(DepartmentDB dept);

        DepartmentDB GetDeptById(int searchString);

        
    }
}
