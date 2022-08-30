using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using LinqAssignment;

internal class Program
{
    static void Main(string[] Mick)
        {
           /* 1.
                        //The two types of filtering operators include:
                        // 1. Where operator.
                        // 2. OfType operator.
                        //CORRECT

          2. 
                        // The two types of projection operators we have include:
                        // 1. Select Operator.
                        // 2. SelectMany Operator.
                        //CORRECT
          3.
                3a
                        List<object> objects = new List<object>() { 1, 2, 3, 4, 5, "John", "Charity", "Favour", "Michael", "Shedrach" };//CORRECT

        //3b
        var methodSyntax = objects.OfType<string>().ToList();//CORRECT
        /*foreach(var it in methodSyntax)
        {
            Console.WriteLine(it);
        }

        Console.ReadLine();*/

        //3c
       // var ms = objects.OfType<string>().Where(obj => obj.Length >= 5).ToList();//CORRECT

        //4.
        /* The sorting operator helps to sort out values which are contained in a particular variables based on certain specified conditions
           In other words, there are operations used to display values based on a particular choice of arrangement CORRECT
                The five types of sorting operators include:
                    1. OrderBy.
                    2. OrderByDescending.
                    3. ThenBy.
                    4. ThenByDescending.
                    5. Reverse. */
                    //CORRECT
        //5.

           /*             List<Student> students = new List<Student>()
                        {
                            new Student
                            {
                                Id=2,
                                Name="Isama Michael",
                                Email="isamamichael2005@gmail.com"
                            },
                            new Student
                            {
                                Id=3,
                                Name="Adikwu Maria",
                                Email="marigoldperi344@gmail.com"
                            },
                            new Student
                            {
                                Id=1,
                                Name="Christian Samuel",
                                Email="christiansamuel567@gmail.com"
                            },
                            new Student
                            {
                                Id=4,
                                Name="Onoja Augustine",
                                Email="austinadoujah2004@gmail.com"
                            }
                        };

                        var MethodSyntax = students.OrderBy(x => x.Id).ToList();//CORRECT

                        Console.WriteLine("=================================================================================");

                        var MSyntax = students.OrderByDescending(x => x.Id).ToList();//CORRECT


        //6.
        List<Employee> employees = new List<Employee>()
                       {
                           new Employee
                           {
                               Id=1,
                               FirstName="Isama",
                               LastName="Michael",
                               Salary=15000
                           },
                           new Employee
                           {
                               Id=2,
                               FirstName="Isama",
                               LastName="Cynthia",
                               Salary=25000
                           },
                           new Employee
                           {
                               Id=1,
                               FirstName="Alechenu",
                               LastName="Precious",
                               Salary=30000
                           },
                           new Employee
                           {
                               Id=1,
                               FirstName="Isama",
                               LastName="Precious",
                               Salary=15000
                           },
                           new Employee
                           {
                               Id=1,
                               FirstName="Alechenu",
                               LastName="Kelvin",

                               Salary=35000
                           },
                           new Employee
                           {
                               Id=1,
                               FirstName="Alechenu",
                               LastName="Destiny",
                               Salary=15000
                           }
                       };

                       var Ms = employees.OrderBy(emp => emp.FirstName).ThenBy(emp => emp.LastName).ToList();//CORRECT

        //7.

                      int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
                      var Methodsyntax = number.Reverse().ToList();  */

        List<Pupil> pupils = new List<Pupil>()
        {
            new Pupil
            {
                Name="Isama Michael",
                Average=98.6,
                subjects=new List<Subjects>()
                {
                    new Subjects{ SubjectName="English Language", SubjectScore=99,},
                    new Subjects{ SubjectName="Biology", SubjectScore=98,},
                    new Subjects{ SubjectName="Physics", SubjectScore=95,},
                    new Subjects{ SubjectName="Chemistry", SubjectScore=97,}
                }
            },
              new Pupil
            {
                Name="Basil Precious",
                Average=96.5,
                subjects=new List<Subjects>()
                {
                    new Subjects{ SubjectName="English Language", SubjectScore=90,},
                    new Subjects{ SubjectName="Biology", SubjectScore=93,},
                    new Subjects{ SubjectName="Physics", SubjectScore=91,},
                    new Subjects{ SubjectName="Chemistry", SubjectScore=98,}
                }
            },
                new Pupil
            {
                Name="Onoja Augustine",
                Average=94.2,
                subjects=new List<Subjects>()
                {
                    new Subjects{ SubjectName="English Language", SubjectScore=87,},
                    new Subjects{ SubjectName="Biology", SubjectScore=90,},
                    new Subjects{ SubjectName="Physics", SubjectScore=86,},
                    new Subjects{ SubjectName="Chemistry", SubjectScore=85,}
                }
            },
                  new Pupil
            {
                Name="Matthew Blessing",
                Average=89.6,
                subjects=new List<Subjects>()
                {
                    new Subjects{ SubjectName="English Language", SubjectScore=79,},
                    new Subjects{ SubjectName="Biology", SubjectScore=90,},
                    new Subjects{ SubjectName="Physics", SubjectScore=84,},
                    new Subjects{ SubjectName="Chemistry", SubjectScore=70,}
                }
            }
        };

        var MS = pupils.Where(pup => pup.subjects.All(pup => pup.SubjectScore >69)).Select(pup => pup.Name).ToList();

        var QuerySyntax = (from pup in pupils
                           where pup.subjects.All(pup => pup.SubjectScore >= 90)
                           select pup).ToList();

        var MethodSyntax = pupils.Where(pup => pup.subjects.Any(pup => pup.SubjectScore < 80)).Select(pup => pup).ToList();

        var QS = (from pup in pupils
                  where pup.subjects.Any(pup => pup.SubjectScore > 90)
                  select pup).ToList();


        Console.ReadLine();
    }
}
