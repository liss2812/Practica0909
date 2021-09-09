using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public int age { get; set; }
        public string nacionalidades { get; set; }
   
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent= 1001, firstName = "Jose", lastName = "Robles", age = 25, nacionalidades="Hondureño" },
                new Student{idStudent= 1002, firstName = "Ana", lastName = "Lopez", age = 20, nacionalidades="Africano" },
                new Student{idStudent= 1003, firstName = "Rafael", lastName = "Gonzalez", age = 21, nacionalidades="Panama" },
                new Student{idStudent= 1004, firstName = "Alfredo", lastName = "Valladares", age = 23, nacionalidades="Venezolense" },
                new Student{idStudent= 1005, firstName = "Amanda", lastName = "Flores", age = 22, nacionalidades="Salvadoreña" },
            };
            return students; 
        }
    }
}
