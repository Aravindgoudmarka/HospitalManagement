using HM.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM.Models;

namespace HM.Services
{
    public class HMContext : DbContext
    {
        

        public HMContext(DbContextOptions<HMContext> options)
        : base(options)
        {
        }

        public DbSet<PatientDetails>PatientDetail{ get; set; }

        public DbSet<DepartmentDB>Department{ get; set; }

        public DbSet<AppointmentDB> Appointment { get; set; }


    }
}
