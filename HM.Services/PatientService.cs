using HM.Models.DBModels;
using HM.Models.VM;
using HM.Services.Contracts;
using System.Security.AccessControl;

namespace HM.Services
{
    public class PatientService : IPatientService
    {
        private readonly HMContext _hMContext;
        public PatientService(HMContext hMContext)
        {
            _hMContext = hMContext;
        }
        public PatientDetails InsertPatient(PatientVM patient)
        {
            PatientDetails insertPatient = new PatientDetails();

            insertPatient.PatientId = patient.PatientId;
            insertPatient.PatientFullName = patient.PatientFullName;
            insertPatient.Gender = patient.Gender;
            insertPatient.BloodGroup = patient.BloodGroup;
            insertPatient.Phone = patient.Phone;
            insertPatient.Email = patient.Email;
            insertPatient.Condition = patient.Condition;
            insertPatient.AdmissionDate = patient.AdmissionDate;
            insertPatient.DOB = patient.DOB;
            insertPatient.IsActive = patient.IsActive;

            var createAppointment = new List<AppointmentDB>();
            foreach( var patients in patient.Appointments)
            {
                var appointmentDetails = new AppointmentDB();

                appointmentDetails.ScheduledOn = patients.ScheduledOn;   
                appointmentDetails.DateOfVisit = patients.DateOfVisit;
                appointmentDetails.DepartmentId = patients.DepartmentId; 
                appointmentDetails.PatientId = patients.PatientId;   
                appointmentDetails.AppointmentId = patients.AppointmentId;   
                createAppointment.Add(appointmentDetails);
            }
            insertPatient._Appointment = createAppointment;
            _hMContext.PatientDetail.Add(insertPatient);
            _hMContext.SaveChanges();
            return insertPatient;
        }
        public PatientDetails UpdatePatient(PatientVM patient)
        {
            //var details = _hMContext.PatientDetail.FirstOrDefault(p => p.PatientId == patient);
            PatientDetails updatePatient = new PatientDetails();

            updatePatient.PatientId = patient.PatientId;
            updatePatient.PatientFullName = patient.PatientFullName;
            updatePatient.Gender = patient.Gender;
            updatePatient.BloodGroup = patient.BloodGroup;
            updatePatient.Phone = patient.Phone;
            updatePatient.Email = patient.Email;
            updatePatient.Condition = patient.Condition;
            updatePatient.AdmissionDate = patient.AdmissionDate;
            updatePatient.DOB = patient.DOB;
            updatePatient.IsActive = patient.IsActive;

            var updateAppointment = new List<AppointmentDB>();
            foreach (var appointment in patient.Appointments)
            {
                var appointmentDetails = new AppointmentDB();
                
                appointmentDetails.ScheduledOn = appointment.ScheduledOn;
                appointmentDetails.DateOfVisit = appointment.DateOfVisit;
                appointmentDetails.DateOfVisit = appointment.DateOfVisit;
                appointmentDetails.DepartmentId = appointment.DepartmentId; 
                appointmentDetails.PatientId = appointment.PatientId;
                updateAppointment.Add(appointmentDetails);
            }
            updatePatient._Appointment = updateAppointment;
            _hMContext.PatientDetail.Update(updatePatient);
            _hMContext.SaveChanges();
            return updatePatient;
        }

        public PatientDetails GetPatientById(int id)
        {
            var details = _hMContext.PatientDetail.FirstOrDefault(p => p.PatientId == id);

            if (details != null)
            {
                var patient = new PatientDetails();
                {
                    patient.PatientId = id;
                    patient.PatientFullName = details.PatientFullName;
                    patient.Gender = details.Gender;
                    patient.BloodGroup = details.BloodGroup;
                    patient.Phone = details.Phone;
                    patient.Email = details.Email;
                    patient.Condition = details.Condition;
                    patient.AdmissionDate = details.AdmissionDate;
                    patient.DOB = details.DOB;
                    patient.IsActive = details.IsActive;

                }
            }
            return details;
        }

        public ResponseMessage DeletePatient(int id)
        {
            ResponseMessage responseMessage = new ResponseMessage();
            try
            {
                var patient = _hMContext.PatientDetail.FirstOrDefault(p => p.PatientId == id);
                if (patient != null)
                {
                    patient.IsActive = false;
                    _hMContext.PatientDetail.Update(patient);
                    _hMContext.SaveChanges();
                    responseMessage.IsError = false;
                    return responseMessage;
                }
                else
                {
                    responseMessage.IsError = true;
                    responseMessage.ErrorMessage = $"Patient With {id} Does Not Exist";
                    return responseMessage;
                }
            }
            catch (Exception ex)
            {
                responseMessage.IsError = true;
                responseMessage.ErrorMessage = $"Something went wrong while deleting patient {id}";
                return responseMessage;
            }
        }
    }

}
