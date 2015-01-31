using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Student
{
    class StudentSpecialty
    {
        private string specialityName;
        private int facultyNumber;

        public string SpecialityName 
        {
            get { return this.specialityName; }
            set { this.specialityName = value; }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set 
            { 
                this.facultyNumber = value; 
            }
        }
        public StudentSpecialty(string specialityName, int facultyNumber) 
        {
            this.FacultyNumber = facultyNumber;
            this.SpecialityName = specialityName;
        }
    }
}
