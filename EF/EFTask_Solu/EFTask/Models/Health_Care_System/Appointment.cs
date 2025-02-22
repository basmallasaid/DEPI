using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask.Models.Health_Care_System
{
    public class Appointment
    {
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
