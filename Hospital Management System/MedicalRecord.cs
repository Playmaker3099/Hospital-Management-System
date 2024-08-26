using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class MedicalRecord
    {
        Patient patient {  get; set; }
        Doctor doctor { get; set; }
        Appointment appointment { get; set; }

        public MedicalRecord(Patient patient, Doctor doctor)
        {
            this.patient = patient;
            this.doctor = doctor;

            /*patient.PatientId = this.patient.PatientId;
            patient.Gender = this.doctor.Gender;
            patient.Age = this.doctor.Age;
            patient.Name = this.doctor.Name;

            doctor.Name = this.doctor.Name;
            doctor.Specialization = this.doctor.Specialization;
            doctor.Diagnosis = this.doctor.Diagnosis;

            Console.WriteLine($"The Medical Record");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");*/
        }

        public void DisplayRecord(Patient patient, Doctor doctor) 
        {
            patient.PatientId = this.patient.PatientId;
            patient.Gender = this.doctor.Gender;
            patient.Age = this.doctor.Age;
            patient.Name = this.doctor.Name;

            doctor.Name = this.doctor.Name;
            doctor.Specialization = this.doctor.Specialization;
            doctor.Diagnosis = this.doctor.Diagnosis;

            Console.WriteLine($"The Medical Record");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine($" Patient's Name \t\tPatient's Age \t\tPatient's Gender \t\tPatient's ID");
            Console.WriteLine($"{patient.Name} \t\t{patient.Age} \t\t{patient.Gender} \t\t{patient.PatientId}");
        }


    }
}
