using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Models.DBModels
{
    [Table("PatientDetails")]
    public class PatientDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string PatientFullName { get; set; }
        public string Gender { get; set; }

        public string BloodGroup { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Condition { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DOB { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Age { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<AppointmentDB> _Appointment { get; set; }
    }
}
