using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Models.DBModels
{
    public class DepartmentDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId {  get; set; }
        public string DepartmentName { get; set;}
        public int EmpCount { get; set; }

        public virtual ICollection<AppointmentDB> _Appointment { get; set; }

    }
}
