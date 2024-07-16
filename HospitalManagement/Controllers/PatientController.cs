using HM.Models.DBModels;
using HM.Models.VM;
using HM.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        [HttpPost("patientdetails")]

        public PatientDetails InsertPatient(PatientVM patient)
        {
            var result = _patientService.InsertPatient(patient);
            return result;
        }

        [HttpPut("patientdetails")]
        public PatientDetails UpdatePatient(PatientVM patient)
        {
            var res = _patientService.UpdatePatient(patient);
            return res;
        }

        [HttpGet("{id}")]

        public PatientDetails GetPatientById(int id)
            {
            return _patientService.GetPatientById(id);
        }

        [HttpDelete("patientdetails")]

        public ResponseMessage DeletePatient(int id)
        {
            var res = _patientService.DeletePatient(id);
            return res;
        }
    }
}
