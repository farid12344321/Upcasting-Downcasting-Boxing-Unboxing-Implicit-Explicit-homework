using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentServices : IStudentServices
    {
        public int EmailStartingWithTheLetter()
        {
            throw new NotImplementedException();
        }

        public int ShowingTheNumberOfStudents()
        {
            var students = GetAll();
            int count = 0;
            foreach (var student in students)
            {
                count++;
            }
            return count;
        }

        public int MumericalMean()
        {
            throw new NotImplementedException();
        }

        public int ShowTheList()
        {
            ;
            int count = 0;
            var students = GetAll();

            foreach (var item in students)
            {
                count++;

            }
            return count;
        }

        public int WithTheSameNames()
        {

            var students = GetAll();
            int count = 0;

            foreach (var item in students)
            {
                if (item.Name == item.Name)
                {
                    count++;
                }
            }
            return count;
        }

        public int WithTheWordEhmedliInTheAddress()
        {
            int count = 0;
            var students = GetAll();
            foreach (var item in students)
            {
                if (item.Address == "Ehmedli")
                {
                    count++;
                }
            }
            return count;
        }

        private Student[] GetAll()
        {
            Student s1 = new Student()
            {
                Id = 1,
                Name = "Farid",
                Surname = "Abdullayev",
                Email = "Farid@code.edu.az",
                Age = 17,
                Education="Code Academy",
                Address="Ehmedli"
            };

            Student s2 = new Student()
            {
                Id = 2,
                Name = "Shaiq",
                Surname = "Kazimov",
                Email = "Shaiq@code.edu.az",
                Age = 25,
                Education = "Code Academy",
                Address = "Nesimi"
            };

            Student s3 = new Student()
            {
                Id= 3,
                Name = "Cavid",
                Surname = "Ismayilzade",
                Email = "Cavid@code.edu.az",
                Age = 22,
                Education = "Code Academy",
                Address = "Sulutepe"
            };

            Student s4 = new Student()
            {
                Id = 4,
                Name = "Mubarizh",
                Surname = "Aghayev",
                Email = "Mubariz@code.edu.az",
                Age = 18,
                Education = "Code Academy",
                Address = "Ehmedli"
            };

            Student[] students = { s1, s2, s3, s4, };
            return students;
        }
    }
}
