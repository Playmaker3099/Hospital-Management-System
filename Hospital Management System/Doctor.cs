using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string Diagnosis { get; set; }
        
        public Doctor(string name, string gender, int age, string doctorDepartment) : base(name, gender, age)
        {
            Specialization = doctorDepartment;
        }

        public void RecordDiagnosis(string diagnosis)
        {
            Diagnosis = diagnosis;

            Console.WriteLine($"The illness recorded is {diagnosis}");

        }
    }
}
