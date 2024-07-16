using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace HM.Models.VM
{
    public class PatientVM
    {
        public int PatientId { get; set; }
        public string PatientFullName { get; set; }
        public string Gender { get; set; }

        public string BloodGroup { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Condition { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DOB { get; set; }

        public bool IsActive { get; set; }

        public List<AppointmentVM> Appointments { get; set; }
    }
    public class AppointmentVM
    {
        public int AppointmentId { get; set; }
        public DateTime ScheduledOn { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int DepartmentId { get; set; }
        public int PatientId { get; set; }
    }
}
