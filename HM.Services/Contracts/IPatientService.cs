using HM.Models.DBModels;
using HM.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Services.Contracts
{
    public interface IPatientService
    {
        PatientDetails InsertPatient(PatientVM patient);

        PatientDetails UpdatePatient(PatientVM patient);

        PatientDetails GetPatientById(int searchString);

        ResponseMessage DeletePatient(int id);
    }
}
