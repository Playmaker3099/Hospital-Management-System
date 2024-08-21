using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Patient : Person
    {
        public string PatientId { get; set; }
        
        public Patient(string name, string gender, int age, string patientId) : base(name, gender, age) 
        {
            PatientId = patientId;

        }

        public void ScheduleAppointment(DateTime appointTime, string patient) 
        {
            PatientId = patient;

            Console.WriteLine($"The Patient {patient} has made an appointment for {appointTime}");
        }
    }
}
