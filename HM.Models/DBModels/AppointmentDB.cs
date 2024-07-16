using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Models.DBModels
{
    public class AppointmentDB
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        public DateTime ScheduledOn { get; set; }
        public DateTime DateOfVisit { get; set; }

        [ForeignKey("DepartmentDB")]
        public int DepartmentId { get; set; }

        [ForeignKey("PatientDetails")]
        public int PatientId { get; set; }

        public virtual PatientDetails PatientDetails { get; set; }  

        public virtual DepartmentDB DepartmentDB { get; set; }

    }
}
