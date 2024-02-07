using ShellLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLesson.Services
{
    public class StudentsService
    {
        private List<Student> students;
        public StudentsService()
        {
            students = new List<Student>();

            InitStudents();
        }
        private void InitStudents()
        {
            this.students.Add(new Student
            {
                Id = 1,
                FirstName = "Ofer",
                LastName = "Zadikario",
                BirthDate = new DateTime(1972, 11, 15),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                Id = 2,
                FirstName = "Tal",
                LastName = "Simon",
                BirthDate = new DateTime(1975, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                Id = 3,
                FirstName = "Racheli",
                LastName = "Zosiman",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                Id = 4,
                FirstName = "Smadar",
                LastName = "Vechter",
                BirthDate = new DateTime(1965, 1, 11),
                AverageScore = 90
            });

            this.students.Add(new Student
            {
                Id = 5,
                FirstName = "Adi",
                LastName = "Menahem",
                BirthDate = new DateTime(1980, 1, 11),
                AverageScore = 90
            });

        }

        public async Task<List<Student>> GetStudents()
        {
            return students;
        }

        public async Task<Student> GetStudentById(int id)
        {
            foreach (Student student in this.students)
            {
                if (student.Id == id) return student;
            }
            return null;
        }
    }
}
