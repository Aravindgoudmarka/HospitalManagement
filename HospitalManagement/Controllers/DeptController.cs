using HM.Models.DBModels;
using HM.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        private readonly IDeptService _deptService;

        public DeptController(IDeptService deptService)
        {
            _deptService = deptService;
        }
        [HttpPost]
        public DepartmentDB InsertDept(DepartmentDB department)
        {
            var res = _deptService.InsertDept(department);
            return res;
        }

        [HttpPut]
        public DepartmentDB UpdateDept(DepartmentDB dept)
        {
            var res = _deptService.UpdateDept(dept);
            return res;
        }

        [HttpGet("{id}")]
        public DepartmentDB GetDeptById(int id)
        {
            var res = _deptService.GetDeptById(id);
            return res;
        }
    }
}
