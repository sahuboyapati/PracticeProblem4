using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Program
    {
        static void AddStudents(List<Students> STUDENTS)
        {

            Console.WriteLine("Enter Students Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Students Class");
            int clasS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Students Class Section(Characters Only Eg..A)");
            char Sec = char.Parse(Console.ReadLine());
            var students = new Students { Name = name, Class = clasS, Section = Sec };
            STUDENTS.Add(students);


        }
        static void DisplayStudentData(List<Students> studentS)
        {

            foreach (var student in studentS)
            {
                Console.WriteLine("Student Name is    : " + student.Name);
                Console.WriteLine("Student class is   : " + student.Class);
                Console.WriteLine("Student Section is : " + student.Section);

            }

        }
        static void DisplayClassData(List<Students> studentS, int clasS)
        {
            Console.WriteLine($"Displaying student Data in the {clasS}th class");
            foreach (var student in studentS)
            {
                if (student.Class == clasS)
                {
                    Console.WriteLine($"{student.Name} is a {clasS}th Student");
                }
            }
        }
        static void AddTeachers(List<Teachers> teachers)
        {

            Console.WriteLine("Enter Teacher Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Teacher Class");
            int clasS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Teacher Class Section (Characters Only Eg..A)");
            char Sec = char.Parse(Console.ReadLine());
            var teacher = new Teachers { Name = name, Class = clasS, Section = Sec };
            teachers.Add(teacher);


        }
        static void DisplayTeachersData(List<Teachers> teachers)
        {

            foreach (var teacher in teachers)
            {
                Console.WriteLine("Teacher Name is    : " + teacher.Name);
                Console.WriteLine("Teacher class is   : " + teacher.Class);
                Console.WriteLine("Teacher Section is : " + teacher.Section);

            }

        }
        static void AddSubjects(List<Subjects> subjectS)
        {

            Console.WriteLine("Enter Subject Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Subject Code (Characters Only Eg..A)");
            char SubCode = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Teacher Name");
            string teacher = Console.ReadLine();
            var subjects = new Subjects { SubjectName = name, SubjectCode = SubCode, Teacher = teacher };
            subjectS.Add(subjects);


        }
        static void DisplaySubjectsTaughtNyTeacher(List<Subjects> subjectS, string teacher)
        {
            Console.WriteLine($"{teacher} teaches the following Subjects");
            foreach (var subject in subjectS)
            {
                if (subject.Teacher == teacher)
                {
                    Console.WriteLine(subject.SubjectName);
                }
            }
        }
        static void DisplaySubjectsData(List<Subjects> subjects)
        {

            foreach (var subject in subjects)
            {
                Console.WriteLine("Subject Name is           : " + subject.SubjectName);
                Console.WriteLine("Subject Code is           : " + subject.SubjectCode);
                Console.WriteLine("Subject's Teacher Name is : " + subject.Teacher);

            }

        }
        static void Main(string[] args)
        {
            var student1 = new Students
            {
                Name = "Rahul",
                Class = 5,
                Section = 'A',
            };
            var student2 = new Students
            {
                Name = "Karthik",
                Class = 7,
                Section = 'B',
            };
            var student3 = new Students
            {
                Name = "Ram",
                Class = 9,
                Section = 'B',
            };
            var student4 = new Students
            {
                Name = "Satwick",
                Class = 10,
                Section = 'A',
            };
            var student5 = new Students
            {
                Name = "Nani",
                Class = 10,
                Section = 'B',
            };
            var students = new List<Students>()
     {
         student1,
         student2,
         student3,
         student4,
         student5,

  };
            var teacher1 = new Teachers
            {
                Name = "Vijay",
                Class = 5,
                Section = 'B',
            };
            var teacher2 = new Teachers
            {
                Name = "Laxmi",
                Class = 10,
                Section = 'A',
            };
            var teacher3 = new Teachers
            {
                Name = "Shiva",
                Class = 7,
                Section = 'C',
            };
            var teachers = new List<Teachers>
{
    teacher1,
    teacher2,
    teacher3,
};
            var subject1 = new Subjects
            {
                SubjectName = "hindi",
                SubjectCode = 'H',
                Teacher = "Vijay"
            };
            var subject2 = new Subjects
            {
                SubjectName = "english",
                SubjectCode = 'E',
                Teacher = "Laxmi"
            };
            var subject3 = new Subjects
            {
                SubjectName = "physics",
                SubjectCode = 'P',
                Teacher = "Shiva"
            };


            var subjects = new List<Subjects>
            {
                subject1,
                subject2,
                subject3,


            };
            Console.WriteLine("Choose Which of the Following Data You Want to Access \n1.Students \n2.Teachers \n3.Subjects");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Students Data \n1.Add New Student Data \n2.Display All Students Data\n3.Students Data in a Particular Class \n4.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddStudents(students);
                        break;
                    case 2:
                        DisplayStudentData(students);
                        break;
                    case 3:
                        Console.WriteLine("We have 10,9,8 classes");
                        Console.WriteLine("Which Class Student data You Want Please Enter ");
                        int x = int.Parse(Console.ReadLine());
                        DisplayClassData(students, x);
                        break;
                    case 4:
                        AddStudents(students);
                        DisplayStudentData(students);
                        Console.WriteLine("We have 10,9,8 classes");
                        Console.WriteLine("Which Class Student data You Want Please Enter ");
                        int y = int.Parse(Console.ReadLine());
                        DisplayClassData(students, y);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation !!!");
                        break;
                }
            }
            else if (op == 2)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Teachers Data \n1.Add New Teachers Data \n2.Display Teachers Data\n3.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTeachers(teachers);
                        break;
                    case 2:
                        DisplayTeachersData(teachers);
                        break;
                    case 3:
                        AddTeachers(teachers);
                        DisplayTeachersData(teachers);
                        break;
                    default:
                        Console.WriteLine("Inalid Operation !!!");
                        break;
                }
            }
            else if (op == 3)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Teachers Data \n1.Add New Subject Data \n2.Display Subjects Data \n3.Teacher Who taughts the Subjects \n4.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddSubjects(subjects);
                        break;
                    case 2:
                        DisplaySubjectsData(subjects);
                        break;
                    case 3:
                        Console.WriteLine("We have three Teachers\n1.Vijay \n2.Laxmi \n3.Shiva  \nEnter one Teacher Name to Know Which subjects he teches");
                        string name = Console.ReadLine();
                        DisplaySubjectsTaughtNyTeacher(subjects, name);
                        break;
                    case 4:
                        AddSubjects(subjects);
                        DisplaySubjectsData(subjects);
                        Console.WriteLine("We have three Teachers\n1.Vijay \n2.Laxmi \n3.Shiva  \nEnter one Teacher Name to Know Which subjects he teaches");
                        string name1 = Console.ReadLine();
                        DisplaySubjectsTaughtNyTeacher(subjects, name1);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation !!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }

            Console.ReadKey();
        }


    }
}