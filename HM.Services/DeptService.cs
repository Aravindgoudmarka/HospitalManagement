using HM.Models.DBModels;
using HM.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HM.Services
{
    public class DeptService : IDeptService
    {
        private readonly HMContext _hMContext;

        public DeptService(HMContext hMContext)
        {
            _hMContext = hMContext;
        }
        public DepartmentDB InsertDept(DepartmentDB dept)
        {
            DepartmentDB insertDept = new DepartmentDB();

            insertDept.DepartmentId = dept.DepartmentId;
            insertDept.DepartmentName = dept.DepartmentName;    
            insertDept.EmpCount = dept.EmpCount;

            _hMContext.Department.Add(insertDept);
            _hMContext.SaveChanges();
            return insertDept;
        }
        public DepartmentDB UpdateDept(DepartmentDB dept)
        {
            DepartmentDB updateDept = new DepartmentDB();

            updateDept.DepartmentId = dept.DepartmentId;
            updateDept.DepartmentName= dept.DepartmentName;
            updateDept.EmpCount= dept.EmpCount;

            _hMContext .Update(updateDept);
            _hMContext.SaveChanges();
            return updateDept;
        }

        public DepartmentDB GetDeptById(int id)
        {
            var details = _hMContext.Department.FirstOrDefault(d => d.DepartmentId == id);

            if(details != null)
            {
                var dept = new DepartmentDB();
                {
                    dept.DepartmentId = id;
                    dept.DepartmentName= details.DepartmentName;
                    dept.EmpCount= details.EmpCount;
                }
            }
            return details;
        }
    }
}
