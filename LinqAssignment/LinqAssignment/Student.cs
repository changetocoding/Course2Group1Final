using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }
    }
    internal class Pupil
    {
        public string Name { get; set; }
        public double Average { get; set; }
        public List<Subjects> subjects { get; set; }
    }
    internal class Subjects
    {
        public string SubjectName { get; set; }
        public int SubjectScore { get; set; }
       
    }
}
